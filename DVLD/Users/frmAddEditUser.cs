using DVLD.Global_Classes;
using DVLD.Helpers;
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


namespace DVLD.Users
{
    public partial class frmAddEditUser : UIForm
    {

        public enum enMode { AddNew, Update }
        public enMode _Mode = enMode.AddNew;

        int _UserID = -1;
        clsUser _User = new clsUser();

        public frmAddEditUser()
        {
            InitializeComponent();
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _User = clsUser.GetUserByID(_UserID);
            _Mode = enMode.Update;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //
        }

        private void _Next()
        {

            if (_Mode == enMode.AddNew)
            {

                if (clsUser.IsUserExistByPersonID(ctrlShowPersonDetailsWithFilter1.PersonID))
                {
                    tabControl1.SelectedTab = tbPersonalInfo;
                    MessageBox.Show("This person is already a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            if (ctrlShowPersonDetailsWithFilter1.PersonID != -1)
            {
                tabControl1.SelectedTab = tbLoginInfo;
                btnSave.Enabled = true;
            }
            else
            {
                tabControl1.SelectedTab = tbPersonalInfo;
                MessageBox.Show("Select a person first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            _Next();

        }

        private void _Back()
        {
            tabControl1.SelectedTab = tbPersonalInfo;
        }

        private void ClearAllErrors()
        {
            errorProvider1.SetError(txtUsername, "");
            errorProvider1.SetError(txtPassword, "");
            errorProvider1.SetError(txtConfirmPassword, "");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            _Back();
            btnSave.Enabled = false;
            ClearAllErrors();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (tabControl1.SelectedTab == tbLoginInfo)
            {

                if (ctrlShowPersonDetailsWithFilter1.PersonID == -1)
                {
                    tabControl1.SelectedTab = tbPersonalInfo;
                    MessageBox.Show("Select a person first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                }
                else
                {

                    if (_Mode == enMode.AddNew)
                    {

                        if (clsUser.IsUserExistByPersonID(ctrlShowPersonDetailsWithFilter1.PersonID))
                        {
                            tabControl1.SelectedTab = tbPersonalInfo;
                            MessageBox.Show("This person is already a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    btnSave.Enabled = true;

                    _User.PersonID = ctrlShowPersonDetailsWithFilter1.PersonID;


                }

            }
            else btnSave.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadUserData();
        }

        private void _ResetDefaultValues()
        {

            btnSave.Enabled = false;

            if (_Mode == enMode.AddNew)
            {

                lblTitle.Text = "Add New User";
                this.Text = "Add New User";

            }
            else
            {

                lblTitle.Text = "Update User";
                this.Text = "Update User";

            }


            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            chbIsActive.Checked = true;

            llblChangePassword.Visible = false;

        }

        private void _LoadUserData()
        {

            if (_User == null)
                return;

            ctrlShowPersonDetailsWithFilter1.LoadPersonInfo(_User.PersonID);
            ctrlShowPersonDetailsWithFilter1.FilterEnabled = false;

            txtUsername.Text = _User.Username;
            txtPassword.Visible = false;
            txtConfirmPassword.Visible = false;
            llblChangePassword.Visible = true;
            chbIsActive.Location = txtPassword.Location;
            lblPassword.Visible = false;
            lblConfirmPassword.Visible = false;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_Validate())
                return;

            //MessageBox.Show("SAVING");

            _FillTheUserObjectWithDataFromTheForm();

            if (_Mode == enMode.AddNew)
                _User.Mode = clsUser.enMode.AddNew;
            else _User.Mode = clsUser.enMode.Update;

            if (_User.Save())
            {

                string message = _Mode == enMode.AddNew ? "User added successfully!" : "User updated successfully!";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_Mode == enMode.AddNew)
                {

                    //_ResetDefaultValues();
                    _UserID = _User.ID;
                    _Mode = enMode.Update;
                    _LoadUserData();


                }
                else
                {

                    //this.DialogResult = DialogResult.OK;
                    //this.Close();

                }

            }
            else
            {
                MessageBox.Show("Failed to save user information!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(_User.error);
            }




        }

        private void _FillTheUserObjectWithDataFromTheForm()
        {


            _User.PersonID = ctrlShowPersonDetailsWithFilter1.PersonID;
            _User.PersonInfo = clsPerson.Find(_User.PersonID);

            _User.Username = txtUsername.Text;
            _User.IsActive = chbIsActive.Checked;

            if (_Mode == enMode.AddNew)
            {
                _User.Password = clsGlobal.PasswordHash(txtPassword.Text);
            }
            else
            {
                //
            }




        }

        //private string _PasswordHash(string RealPassword)
        //    => BCrypt.Net.BCrypt.HashPassword(RealPassword);

        //private bool _PasswordMatches(string enteredPassword, string storedHash)
        //    => BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);





        private bool _Validate()
        {

            string errorMessage = "";

            if (!clsValidation.IsUsernameValid(txtUsername.Text, ref errorMessage, _UserID))
            {
                errorProvider1.SetError(txtUsername, errorMessage);
                return false;
            }

            if (_Mode == enMode.AddNew)
            {
                if (!clsValidation.IsPasswordValid(txtPassword.Text, ref errorMessage))
                {
                    errorProvider1.SetError(txtPassword, errorMessage);
                    return false;
                }

                if (!clsValidation.IsConfirmPasswordValid(txtPassword.Text, txtConfirmPassword.Text, ref errorMessage))
                {
                    errorProvider1.SetError(txtConfirmPassword, errorMessage);
                    return false;
                }
            }


            return true;

        }

        private void txt_Leave(object sender, EventArgs e)
        {
            //ClearAllErrors();
            //_Validate();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

            ClearAllErrors();
            _Validate();

        }

        private void llblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmChangePassword frm = new frmChangePassword(_User.ID);
            frm.ShowDialog();



        }

        private void tbLoginInfo_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
