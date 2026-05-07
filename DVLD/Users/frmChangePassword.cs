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

namespace DVLD.Users
{
    public partial class frmChangePassword : UIForm
    {

        int _UserID = -1;
        clsUser _User = new clsUser();

        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _User = clsUser.GetUserByID(UserID);
        }

        private bool _Validation()
        {

            string ErrorMSG = "ERROR";

            if (!CheckIfCurrentPasswordRight())
            {

                errorProvider1.SetError(txtCurrentPassword, "Wrong Password!!!");

                return false;

            }

            if (!clsValidation.IsPasswordValid(txtNewPassword.Text, ref ErrorMSG))
            {

                errorProvider1.SetError(txtNewPassword, ErrorMSG);

                return false;

            }

            if (!clsValidation.IsConfirmPasswordValid(txtNewPassword.Text, txtConfirmPassword.Text, ref ErrorMSG))
            {

                errorProvider1.SetError(txtConfirmPassword, ErrorMSG);

                return false;

            }





            return true;



        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_Validation())
                return;

            if (_User.ChangePassword(clsGlobal.PasswordHash(txtNewPassword.Text)))
            {

                MessageBox.Show("Password Changed Successfully", "Success",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed To Change Password", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

        }

        private bool CheckIfCurrentPasswordRight()
            => clsGlobal.PasswordMatches(txtCurrentPassword.Text, _User.Password);

        private void _ClearAllErrors()
        {
            errorProvider1.SetError(txtCurrentPassword, "");
            errorProvider1.SetError(txtNewPassword, "");
            errorProvider1.SetError(txtConfirmPassword, "");
        }

        private void txtCurrentPassword_TextChanged_1(object sender, EventArgs e)
        {

            _ClearAllErrors();
            _Validation();

        }
    }
}
