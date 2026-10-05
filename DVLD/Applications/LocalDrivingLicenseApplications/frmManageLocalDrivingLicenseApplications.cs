using DVLD.Licenses.Local_Licenses;
using DVLD.Tests;
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

            // LDLAppID stands for: Local Driving License Application ID
            // LDLApp   stands for: Local Driving License Application

            int LDLAppID = (int)dgvManageLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);

            int TotalPassedTests = (int)dgvManageLocalDrivingLicenseApps.CurrentRow.Cells[5].Value;

            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = TotalPassedTests == 3;
            showLicenseToolStripMenuItem.Enabled = false;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = false;

            if (LDLApp.IsLicenseIssued())
            {
                showLicenseToolStripMenuItem.Enabled = true;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            }

            editToolStripMenuItem1.Enabled = LDLApp.AppStatus == clsApplication.enApplicationStatus.New;

            cancelToolStripMenuItem.Enabled = LDLApp.AppStatus == clsApplication.enApplicationStatus.New;

            //We only allow delete incase the application status is new not complete or Cancelled.
            deleteApplicationToolStripMenuItem.Enabled = LDLApp.AppStatus == clsApplication.enApplicationStatus.New;

            bool PassedVisionTest = LDLApp.DoesPassTestType(clsTestType.enTestType.VisionTest); ;
            bool PassedWrittenTest = LDLApp.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LDLApp.DoesPassTestType(clsTestType.enTestType.StreetTest);

            //scheduleStreetTestToolStripMenuItem.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.AppStatus == clsApplication.enApplicationStatus.New);

            if (PassedVisionTest && PassedWrittenTest && PassedStreetTest)
                scheduleTestToolStripMenuItem.Enabled = false;
            else scheduleTestToolStripMenuItem.Enabled = true;

            if (scheduleTestToolStripMenuItem.Enabled)
            {

                scheduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                scheduleWrittenTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                scheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }

            if (LDLApp.AppStatus == clsApplication.enApplicationStatus.Cancelled)
            {
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                scheduleTestToolStripMenuItem.Enabled = false;
            }

        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Issue License");
            int LDLAppID = (int)dgvManageLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime(LDLAppID);
            frm.ShowDialog();
            _ListAppsAndRefreshPage();
            if (LDLApp.IsLicenseIssued())
            {
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                //showDetailsToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = true;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
            }

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

            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            int LDLAppID = (int)dgvManageLocalDrivingLicenseApps.CurrentRow.Cells["ID"].Value;
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);

            if (LDLApp == null)
            {
                MessageBox.Show("Application Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (LDLApp.Cancel())
                MessageBox.Show("This application is cancelled!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("This application is NOT cancelled!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            _ListAppsAndRefreshPage();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LDLAppID = (int)dgvManageLocalDrivingLicenseApps.CurrentRow.Cells["ID"].Value;
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);
            if (LDLApp.GetActiveLicenseID() == -1)
            {
                MessageBox.Show("There is no license for this person: " + LDLApp.PersonInfo.GetFullName(), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowLicenseInfo frm = new frmShowLicenseInfo(LDLAppID);
            frm.ShowDialog();
            _ListAppsAndRefreshPage();


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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.VisionTest);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.WrittenTest);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.StreetTest);
        }

        private void _ScheduleTest(clsTestType.enTestType TestType)
        {
            int LDLAppID = (int)dgvManageLocalDrivingLicenseApps.CurrentRow.Cells[0].Value;
            frmListTestAppointments frm = new frmListTestAppointments(LDLAppID, TestType);
            frm.ShowDialog();
            _ListAppsAndRefreshPage();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalApps_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
