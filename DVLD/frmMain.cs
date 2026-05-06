using DVLD.Users;
using Sunny.UI;

namespace DVLD
{
    public partial class frmMain : UIForm
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
