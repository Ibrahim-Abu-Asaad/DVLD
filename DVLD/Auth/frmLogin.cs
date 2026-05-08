using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Global_Classes;
using DVLD.Helpers;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD.Auth
{
    public partial class frmLogin : UIForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '●';
            txtUsername.Text = "ibr";
            txtPassword.Text = "Ibrahim1";

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chbShowPassword.Checked ? '\0' : '●';
        }

        private bool _Validation()
        {


            errorProvider1.Clear();


            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Username Required!!");
                return false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password Required!!");
                return false;
            }

            bool IsUserExist = clsUser.IsUserExistByUsername(txtUsername.Text);

            if (!IsUserExist)
            {
                errorProvider1.SetError(txtUsername, "User with this username does not exist");
                return false;
            }

            clsUser user = clsUser.GetUserByUsername(txtUsername.Text);

            if (!user.IsActive)
            {
                errorProvider1.SetError(txtUsername, "This user is inactive, please contact admin");
                return false;
            }

            if (!clsGlobal.PasswordMatches(txtPassword.Text, user.Password))
            {
                errorProvider1.SetError(txtPassword, "Wrong Password");
                return false;
            }

            return true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!_Validation())
                return;

            clsUser user = clsUser.GetUserByUsername(txtUsername.Text);

            frmMain frm = new frmMain(user.ID);
            frm.ShowDialog();

        }
    }
}
