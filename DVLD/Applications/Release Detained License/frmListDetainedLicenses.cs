using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Applications.Detain_Local_License;
using DVLD.Applications.Release_Local_License;
using DVLD.Drivers;
using DVLD.Licenses.Local_Licenses;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD.Applications.Release_Detained_License
{
    public partial class frmListDetainedLicenses : UIForm
    {

        private DataTable _dtDetainedLicenses = new DataTable();

        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {

            _dtDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();
            dgvManageDetainedLicenses.DataSource = _dtDetainedLicenses;

            lblTotalDetainedLicenses.Text = dgvManageDetainedLicenses.Rows.Count.ToString();

            cbSearchBy.Items.Clear();
            cbSearchBy.Items.Add("None");
            cbSearchBy.Items.Add("Detain ID");
            cbSearchBy.Items.Add("License ID");
            cbSearchBy.Items.Add("Is Released");
            cbSearchBy.SelectedIndex = 0;

            cbStatus.Items.Clear();
            cbStatus.Items.Add("All");
            cbStatus.Items.Add("Yes");
            cbStatus.Items.Add("No");
            cbStatus.SelectedIndex = 0;

            txtSearchBy.Visible = false;
            cbStatus.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgBtnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _RefreshForm();
        }

        private void imgBtnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLocalDrivingLicense frm = new frmDetainLocalDrivingLicense();
            frm.ShowDialog();
            _RefreshForm();
        }

        private void _RefreshForm()
        {
            _dtDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();
            dgvManageDetainedLicenses.DataSource = _dtDetainedLicenses;
            lblTotalDetainedLicenses.Text = dgvManageDetainedLicenses.Rows.Count.ToString();
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbSearchBy.Text == "Is Released")
            {
                txtSearchBy.Visible = false;
                cbStatus.Visible = true;
                cbStatus.Location = txtSearchBy.Location;
                cbStatus.SelectedIndex = 0;
            }
            else if (cbSearchBy.Text == "None")
            {
                txtSearchBy.Visible = false;
                cbStatus.Visible = false;
                //_dtDetainedLicenses.DefaultView.RowFilter = "";
            }
            else
            {
                txtSearchBy.Visible = true;
                cbStatus.Visible = false;
                txtSearchBy.Clear();
                txtSearchBy.Focus();
            }

            _dtDetainedLicenses.DefaultView.RowFilter = "";
            lblTotalDetainedLicenses.Text = dgvManageDetainedLicenses.Rows.Count.ToString();


        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";

            switch (cbSearchBy.Text)
            {
                case "Detain ID":
                    FilterColumn = "[Detain ID]";
                    break;

                case "License ID":
                    FilterColumn = "[License ID]";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            string filterText = txtSearchBy.Text.Trim();

            if (string.IsNullOrEmpty(filterText) || FilterColumn == "None")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                return;
            }

            _dtDetainedLicenses.DefaultView.RowFilter = string.Format("CONVERT({0}, 'System.String') LIKE '{1}%'", FilterColumn, filterText);
            lblTotalDetainedLicenses.Text = dgvManageDetainedLicenses.Rows.Count.ToString();

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterValue = cbStatus.Text;

            switch (FilterValue)
            {
                case "All":
                    _dtDetainedLicenses.DefaultView.RowFilter = "";
                    break;

                case "Yes":
                    _dtDetainedLicenses.DefaultView.RowFilter = "[Is Released] = true";
                    break;

                case "No":
                    _dtDetainedLicenses.DefaultView.RowFilter = "[Is Released] = false";
                    break;
            }

            lblTotalDetainedLicenses.Text = dgvManageDetainedLicenses.Rows.Count.ToString();

        }

        private void txtSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbSearchBy.Text == "Detain ID" || cbSearchBy.Text == "License ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvManageDetainedLicenses.CurrentRow.Cells[1].Value;
            int personID = clsLicense.Find(licenseID).DriverInfo.PersonID;

            frmShowPersonDetails frm = new frmShowPersonDetails(personID);
            frm.ShowDialog();

            _RefreshForm();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvManageDetainedLicenses.CurrentRow.Cells[1].Value;

            frmShowLicenseInfo frm = new frmShowLicenseInfo(licenseID, true);
            frm.ShowDialog();

            _RefreshForm();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvManageDetainedLicenses.CurrentRow.Cells[1].Value;
            int personID = clsLicense.Find(licenseID).DriverInfo.PersonID;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(personID);
            frm.ShowDialog();

            _RefreshForm();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)dgvManageDetainedLicenses.CurrentRow.Cells[1].Value;

            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(licenseID);
            frm.ShowDialog();

            _RefreshForm();
        }

        private void cmsDetainedLicenses_Opening(object sender, CancelEventArgs e)
        {

            int licenseID = (int)dgvManageDetainedLicenses.CurrentRow.Cells[1].Value;

            if (clsLicense.Find(licenseID).IsDetained)
                releaseDetainedLicenseToolStripMenuItem.Enabled = true;
            else releaseDetainedLicenseToolStripMenuItem.Enabled = false;

        }

        private void dgvManageDetainedLicenses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvManageDetainedLicenses.ClearSelection();
                dgvManageDetainedLicenses.Rows[e.RowIndex].Selected = true;

                dgvManageDetainedLicenses.CurrentCell = dgvManageDetainedLicenses.Rows[e.RowIndex].Cells[e.ColumnIndex];

                Rectangle cellRect = dgvManageDetainedLicenses.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point mousePosition = dgvManageDetainedLicenses.PointToScreen(new Point(cellRect.Left + e.X, cellRect.Top + e.Y));

                cmsDetainedLicenses.Show(mousePosition);
            }

        }



    }
}
