using DVLD.Users;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD
{
    public partial class frmMain : UIForm
    {

        int _CurrentUserID = -1;
        clsUser _CurrentUser = new clsUser();

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
    }
}
