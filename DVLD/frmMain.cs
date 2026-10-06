using DVLD.Applications;
using DVLD.Applications.LocalDrivingLicenseApplications;
using DVLD.Applications.Renew_Local_License;
using DVLD.Applications.ReplaceLostOrDamagedLicense;
using DVLD.Applications.TestTypes;
using DVLD.Drivers;
using DVLD.Global_Classes;
using DVLD.Licenses.Local_Licenses;
using DVLD.Users;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD
{
    public partial class frmMain : UIForm
    {

        int _CurrentUserID = -1;
        clsUser _CurrentUser = new clsUser();
        //clsUser _CurrentUser = clsGlobal.CurrentUser;

        public frmMain(int userID)
        {
            InitializeComponent();

            _CurrentUserID = userID;
            _CurrentUser = clsUser.GetUserByID(userID);
        }

        private void trebuchetMS12ptToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmManagePeople frm = new frmManagePeople();
            frm.ShowDialog();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmManageUsers frm = new frmManageUsers();
            frm.ShowDialog();

        }

        private void showAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(_CurrentUserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(_CurrentUserID);
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CurrentUserID = -1;
            _CurrentUser = new clsUser();
            this.Close();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication();
            frm.ShowDialog();


        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication(44);
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplications frm = new frmManageLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void MainFormMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTesting frm = new frmTesting();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRenewLocalDrivingLicenseApplication frm = new frmRenewLocalDrivingLicenseApplication();
            frm.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicenseApplication frm = new frmReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
        }

        private void replacementForDamagedOrLostLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicenseApplication frm = new frmReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TEST frm = new TEST();
            frm.ShowDialog();

        }

    }
}
