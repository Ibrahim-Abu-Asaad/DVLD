using DVLD_BLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.LocalDrivingLicenseApplications
{
    public partial class frmManageLocalDrivingLicenseApplications : UIForm
    {

        DataTable _dtAllLocalDrivingLicenseApplications = new DataTable();

        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void _ListAppsAndRefreshPage()
        {
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgvManageLocalDrivingLicenseApps.DataSource = _dtAllLocalDrivingLicenseApplications;
            //editToolStripMenuItem1.Enabled = true;
            _Filtering();
        }

        private void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _ListAppsAndRefreshPage();
            _FillComboBox();
        }

        private void _FillComboBox()
        {

            cbSearchBy.Items.Clear();
            cbSearchBy.Items.Add("None");
            cbSearchBy.Items.Add("National No");
            cbSearchBy.Items.Add("Status");
            cbSearchBy.Items.Add("Full Name");
            cbSearchBy.SelectedIndex = 0;

            cbStatus.Items.Clear();
            cbStatus.Items.Add("All");
            cbStatus.Items.Add("New");
            cbStatus.Items.Add("Cancelled");
            cbStatus.Items.Add("Completed");
            cbStatus.SelectedIndex = 0;

            txtSearchBy.Visible = false;
            cbStatus.Visible = false;
        }

        private void imgbtnAddNewApp_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication();
            frm.ShowDialog();
            _ListAppsAndRefreshPage();
        }

        private void dgvManageLocalDrivingLicenseApps_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    dgvManageLocalDrivingLicenseApps.ClearSelection();

                    dgvManageLocalDrivingLicenseApps.Rows[e.RowIndex].Selected = true;

                    dgvManageLocalDrivingLicenseApps.CurrentCell = dgvManageLocalDrivingLicenseApps.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    cmsPersonRecord.Show(Cursor.Position);

                    //if (dgvManageLocalDrivingLicenseApps.SelectedRows[0].Cells["Status"].Value.ToString() == "Completed" || dgvManageLocalDrivingLicenseApps.SelectedRows[0].Cells["Status"].Value.ToString() == "Cancelled")
                    //    editToolStripMenuItem1.Enabled = false;

                    //if (dgvManageLocalDrivingLicenseApps.SelectedRows[0].Cells["Status"].Value.ToString() == "New")
                    //    editToolStripMenuItem1.Enabled = true;

                }
            }

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (dgvManageLocalDrivingLicenseApps.SelectedRows.Count > 0)
            {

                int ID = (int)dgvManageLocalDrivingLicenseApps.SelectedRows[0].Cells["ID"].Value;
                clsLocalDrivingLicenseApplication locApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(ID);

                if (locApp != null)
                {

                    frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication(ID);
                    frm.ShowDialog();

                    _ListAppsAndRefreshPage();
                }
                else
                {
                    MessageBox.Show("Application not found!", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void scheduleTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void cmsPersonRecord_Opening(object sender, CancelEventArgs e)
        {

            //editToolStripMenuItem1.Enabled = dgvManageLocalDrivingLicenseApps.CurrentRow.Cells["Status"].Value.ToString() == "New";
            //cancelToolStripMenuItem.Enabled = dgvManageLocalDrivingLicenseApps.CurrentRow.Cells["Status"].Value.ToString() == "New";

            int LocalDrivingLicenseApplicationID = (int)dgvManageLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)dgvManageLocalDrivingLicenseApps.CurrentRow.Cells[5].Value;

            //bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            //issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExists;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3);

            //showLicenseToolStripMenuItem.Enabled = LicenseExists;
            //editToolStripMenuItem1.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.AppStatus == clsApplication.enApplicationStatus.New);
            editToolStripMenuItem1.Enabled = LocalDrivingLicenseApplication.AppStatus == clsApplication.enApplicationStatus.New;
            //ScheduleTestsMenue.Enabled = !LicenseExists;

            cancelToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.AppStatus == clsApplication.enApplicationStatus.New);

            //We only allow delete incase the application status is new not complete or Cancelled.
            deleteApplicationToolStripMenuItem.Enabled = LocalDrivingLicenseApplication.AppStatus == clsApplication.enApplicationStatus.New;



            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreetTest);

            scheduleStreetTestToolStripMenuItem.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.AppStatus == clsApplication.enApplicationStatus.New);

            if (scheduleTestToolStripMenuItem.Enabled)
            {

                scheduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                scheduleWrittenTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                scheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }


        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Issue License");
        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {

            _Filtering();

        }

        //private void _Filtering()
        //{
        //    string filterCol = "";

        //    switch (cbSearchBy.Text)
        //    {
        //        case "National No":
        //            filterCol = "NationalNo";
        //            break;

        //        case "Full Name":
        //            filterCol = "FullName";
        //            break;

        //        case "Status":
        //            filterCol = "Status";
        //            break;

        //        default:
        //            filterCol = "None";
        //            break;
        //    }

        //    if (txtSearchBy.Text.Trim() == "" || filterCol == "None")
        //    {
        //        _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
        //        lblTotalApps.Text = dgvManageLocalDrivingLicenseApps.Rows.Count.ToString();
        //        return;
        //    }

        //    _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterCol, txtSearchBy.Text.Trim());

        //    lblTotalApps.Text = dgvManageLocalDrivingLicenseApps.Rows.Count.ToString();

        //    //txtSearchBy.Visible = false;
        //}

        private void _Filtering()
        {
            string filterCol = "";

            switch (cbSearchBy.Text)
            {
                case "National No":
                    filterCol = "NationalNo";
                    break;

                case "Full Name":
                    filterCol = "FullName";
                    break;

                case "Status":
                    filterCol = "Status";
                    break;

                default:
                    filterCol = "None";
                    break;
            }

            if (filterCol == "None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblTotalApps.Text = dgvManageLocalDrivingLicenseApps.Rows.Count.ToString();
                return;
            }

            if (filterCol == "Status")
            {
                if (cbStatus.Text == "All")
                {
                    _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                }
                else
                {
                    _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", filterCol, cbStatus.Text.Trim());
                }
            }
            else
            {
                if (txtSearchBy.Text.Trim() == "")
                {
                    _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                }
                else
                {
                    _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterCol, txtSearchBy.Text.Trim());
                }
            }

            lblTotalApps.Text = dgvManageLocalDrivingLicenseApps.Rows.Count.ToString();
        }



        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvManageLocalDrivingLicenseApps.SelectedRows.Count > 0)
            {

                int LDLAppID = (int)dgvManageLocalDrivingLicenseApps.SelectedRows[0].Cells["ID"].Value;
                clsLocalDrivingLicenseApplication locApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);

                if (locApp != null)
                {

                    frmShowLocalDrivingLicenseApplicationInfo frm = new frmShowLocalDrivingLicenseApplicationInfo(LDLAppID);
                    frm.ShowDialog();

                    _ListAppsAndRefreshPage();
                }
                else
                {
                    MessageBox.Show("Application not found!", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete it if not linked");
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancell it");
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing License");
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Showing Person History");
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {


            txtSearchBy.Text = "";
            cbStatus.SelectedIndex = 0;
            _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            lblTotalApps.Text = dgvManageLocalDrivingLicenseApps.Rows.Count.ToString();

            if (cbSearchBy.Text == "None")
            {
                txtSearchBy.Visible = false;
                cbStatus.Visible = false;
            }
            else if (cbSearchBy.Text == "Status")
            {
                txtSearchBy.Visible = false;
                cbStatus.Visible = true;
                cbStatus.Location = txtSearchBy.Location;
                cbStatus.Focus();
                _Filtering();
            }
            else
            {
                txtSearchBy.Visible = true;
                cbStatus.Visible = false;
                txtSearchBy.Focus();
            }

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Filtering();
        }
    }
}
