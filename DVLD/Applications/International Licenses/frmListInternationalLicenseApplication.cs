using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Drivers;
using DVLD.Licenses.International_Licenses;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD.Applications.International_Licenses
{
    public partial class frmListInternationalLicenseApplication : UIForm
    {

        private DataTable _dtInternationalLicenseApplications;

        public frmListInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListInternationalLicenseApplication_Load(object sender, EventArgs e)
        {

            _Refresh();

        }

        private void _Refresh()
        {

            cbSearchBy.Items.Clear();
            cbSearchBy.Items.Add("None");
            cbSearchBy.Items.Add("International License ID");
            cbSearchBy.Items.Add("Application ID");
            cbSearchBy.Items.Add("Driver ID");
            cbSearchBy.Items.Add("Local License ID");
            cbSearchBy.Items.Add("Is Active");

            _dtInternationalLicenseApplications = clsInternationalLicense.GetAllInternationalLicenses();
            cbSearchBy.SelectedIndex = 0;

            dgvManageInternationalDrivingLicenseApps.DataSource = _dtInternationalLicenseApplications;
            lblTotalInternationalApps.Text = dgvManageInternationalDrivingLicenseApps.Rows.Count.ToString();

            if (dgvManageInternationalDrivingLicenseApps.Rows.Count > 0)
            {
                dgvManageInternationalDrivingLicenseApps.Columns[0].HeaderText = "Int.License ID";
                dgvManageInternationalDrivingLicenseApps.Columns[0].Width = 160;

                dgvManageInternationalDrivingLicenseApps.Columns[1].HeaderText = "Application ID";
                dgvManageInternationalDrivingLicenseApps.Columns[1].Width = 150;

                dgvManageInternationalDrivingLicenseApps.Columns[2].HeaderText = "Driver ID";
                dgvManageInternationalDrivingLicenseApps.Columns[2].Width = 130;

                dgvManageInternationalDrivingLicenseApps.Columns[3].HeaderText = "L.License ID";
                dgvManageInternationalDrivingLicenseApps.Columns[3].Width = 130;

                dgvManageInternationalDrivingLicenseApps.Columns[4].HeaderText = "Issue Date";
                dgvManageInternationalDrivingLicenseApps.Columns[4].Width = 180;

                dgvManageInternationalDrivingLicenseApps.Columns[5].HeaderText = "Expiration Date";
                dgvManageInternationalDrivingLicenseApps.Columns[5].Width = 180;

                dgvManageInternationalDrivingLicenseApps.Columns[6].HeaderText = "Is Active";
                dgvManageInternationalDrivingLicenseApps.Columns[6].Width = 120;

            }

            lblTotalInternationalApps.Text = _dtInternationalLicenseApplications.DefaultView.Count.ToString();

        }

        private void imgbtnAddNewApp_Click(object sender, EventArgs e)
        {

            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();

            _Refresh();

        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbSearchBy.Text == "Is Active")
            {

                txtSearchBy.Visible = false;
                cbIsReleased.Visible = true;

                cbIsReleased.Items.Clear();
                cbIsReleased.Items.Add("All");
                cbIsReleased.Items.Add("Yes");
                cbIsReleased.Items.Add("No");

                cbIsReleased.Location = txtSearchBy.Location;
                cbIsReleased.SelectedIndex = 0;
                cbIsReleased.Focus();

            }

            else

            {

                txtSearchBy.Visible = (cbSearchBy.Text != "None");
                cbIsReleased.Visible = false;

                if (cbSearchBy.Text == "None")
                {
                    txtSearchBy.Enabled = false;

                }
                else
                    txtSearchBy.Enabled = true;

                txtSearchBy.Text = "";
                txtSearchBy.Focus();
            }

            lblTotalInternationalApps.Text = _dtInternationalLicenseApplications.DefaultView.Count.ToString();

        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "IsActive";
            string FilterValue = cbIsReleased.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
            else
                _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            //lblTotalInternationalApps.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();
            lblTotalInternationalApps.Text = _dtInternationalLicenseApplications.DefaultView.Count.ToString();
        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            switch (cbSearchBy.Text)
            {
                case "International License ID":
                    FilterColumn = "ID";
                    break;

                case "Application ID":
                    FilterColumn = "ApplicationID";
                    break;

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtSearchBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                lblTotalInternationalApps.Text = _dtInternationalLicenseApplications.DefaultView.Count.ToString();
                return;
            }

            _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '{1}%'", FilterColumn, txtSearchBy.Text.Trim());

            lblTotalInternationalApps.Text = _dtInternationalLicenseApplications.DefaultView.Count.ToString();


        }

        private void txtSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvManageInternationalDrivingLicenseApps.CurrentRow.Cells[2].Value;
            int PersonID = clsDriver.GetDriverByID(DriverID).PersonID;

            frmShowPersonDetails frm = new frmShowPersonDetails(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int InternationalLicenseID = (int)dgvManageInternationalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(InternationalLicenseID);
            frm.ShowDialog();

        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvManageInternationalDrivingLicenseApps.CurrentRow.Cells[2].Value;
            int PersonID = clsDriver.GetDriverByID(DriverID).PersonID;
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            //

        }

        private void dgvManageInternationalDrivingLicenseApps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //

        }

        private void dgvManageInternationalDrivingLicenseApps_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    dgvManageInternationalDrivingLicenseApps.ClearSelection();

                    dgvManageInternationalDrivingLicenseApps.Rows[e.RowIndex].Selected = true;

                    dgvManageInternationalDrivingLicenseApps.CurrentCell = dgvManageInternationalDrivingLicenseApps.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    cmsInternational.Show(Cursor.Position);

                }
            }

        }


    }
}
