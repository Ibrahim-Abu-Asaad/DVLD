using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Helpers;
using DVLD.Properties;
using DVLD_BLL;
using Sunny.UI;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DVLD
{
    public partial class frmAddEditPerson : UIForm
    {

        public delegate void DataBackEventHandler(object sender, string NationalNO);

        public event DataBackEventHandler DataBack;


        public enum enMode { AddNew, Update };
        public enum enGenders { Male, Female };

        int _PersonID = -1;
        clsPerson _Person = new clsPerson();
        enMode _Mode;

        public frmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Person = clsPerson.Find(PersonID);

            _Mode = _Mode = enMode.Update;

        }


        private void _FillCountriesInComboBox()
        {

            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow country in dtCountries.Rows)
                cbCountry.Items.Add(country["CountryName"]);

        }

        private void _ResetDefaultValues()
        {

            rbMale.Checked = true;
            pbPersonImage.ImageLocation = null;
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
            llblRemove.Visible = false;


            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                _Person = new clsPerson();
                lblTitle.Text = "Add New Person";
                this.Text = "Add New Person";
            }
            else
            {
                lblTitle.Text = "Update Person";
                this.Text = "Update Person";
            }

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18).AddDays(-1);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Syria");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNO.Text = "";
            //rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

        }

        private void _LoadPersonData()
        {

            if (_Person == null)
            {
                MessageBox.Show("There is no person");
                this.Close();
                return;
            }

            lblTitle.Text = "Update Person";
            this.Text = "Update Person";

            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNO.Text = _Person.NationalNO;

            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;

            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);

            if (_Person.ImagePath != "")
                pbPersonImage.ImageLocation = _Person.ImagePath;

            llblRemove.Visible = _Person.ImagePath != "";


        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadPersonData();

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            // if press any key the error provider clearing
        }


        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private bool _IsInfoValid()
        {

            string ErrorMessage = "";
            bool isValid = true;

            errorProvider1.Clear();

            // Validate FirstName
            if (!clsValidation.IsNameValid(txtFirstName.Text, ref ErrorMessage))
            {
                errorProvider1.SetError(txtFirstName, ErrorMessage);
                isValid = false;
            }
            // Validate SecondName
            if (!clsValidation.IsNameValid(txtSecondName.Text, ref ErrorMessage))
            {
                errorProvider1.SetError(txtSecondName, ErrorMessage);
                isValid = false;
            }
            // Validate ThirdName
            if (!clsValidation.IsNameValid(txtThirdName.Text, ref ErrorMessage))
            {
                errorProvider1.SetError(txtThirdName, ErrorMessage);
                isValid = false;
            }
            // Validate LastName
            if (!clsValidation.IsNameValid(txtLastName.Text, ref ErrorMessage))
            {
                errorProvider1.SetError(txtLastName, ErrorMessage);
                isValid = false;
            }
            // Validate NationalNO
            if (!clsValidation.IsNationalNoValid(txtNationalNO.Text, ref ErrorMessage, _PersonID))
            {
                errorProvider1.SetError(txtNationalNO, ErrorMessage);
                isValid = false;
            }
            // Validate Date
            if (!clsValidation.IsDateValid(dtpDateOfBirth.Value, ref ErrorMessage))
            {
                errorProvider1.SetError(dtpDateOfBirth, ErrorMessage);
                isValid = false;
            }
            // Validate Phone
            if (!clsValidation.IsPhoneValid(txtPhone.Text, ref ErrorMessage, _PersonID))
            {
                errorProvider1.SetError(txtPhone, ErrorMessage);
                isValid = false;
            }
            // Validate Email
            if (!clsValidation.IsEmailValid(txtEmail.Text, ref ErrorMessage, _PersonID))
            {
                errorProvider1.SetError(txtEmail, ErrorMessage);
                isValid = false;
            }
            // Validate Address
            if (!clsValidation.IsAddressValid(txtAddress.Text, ref ErrorMessage))
            {
                errorProvider1.SetError(txtAddress, ErrorMessage);
                isValid = false;
            }
            return isValid;
        }

        private void _FillThePersonObjectWithDataFromTheForm()
        {

            string selectedCountry = cbCountry.Text;
            _Person.NationalityCountryID = clsCountry.Find(selectedCountry).ID;
            _Person.CountryInfo = clsCountry.Find(_Person.NationalityCountryID);

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNO = txtNationalNO.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gender = rbMale.Checked ? 0 : 1;
            _Person.Address = txtAddress.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

        }

        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        //
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {

                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_IsInfoValid())
                return;

            if (!_HandlePersonImage())
                return;

            _FillThePersonObjectWithDataFromTheForm();

            if (_Person.Save())
            {

                string message = _Mode == enMode.AddNew ? "Person added successfully!" : "Person updated successfully!";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_Mode == enMode.AddNew)
                {

                    //_ResetDefaultValues();
                    _PersonID = _Person.ID;
                    _Mode = enMode.Update;
                    _LoadPersonData();

                    txtFirstName.Focus();

                }
                else
                {

                    //this.DialogResult = DialogResult.OK;
                    //this.Close();

                }

            }
            else MessageBox.Show("Failed to save person information!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            //
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;

        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Title = "Select Person Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ////Set the image location
                //pbPersonImage.ImageLocation = openFileDialog.FileName;
                string selectedFilePath = openFileDialog.FileName;

                pbPersonImage.Load(selectedFilePath);

                llblRemove.Visible = true;
            }

        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else pbPersonImage.Image = Resources.Female_512;

            llblRemove.Visible = false;

        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            Sunny.UI.UITextBox txtBox = sender as Sunny.UI.UITextBox;
            if (txtBox != null)
            {
                errorProvider1.SetError(txtBox, "");
            }

            if (txtBox == txtPhone && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }


        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAddress, "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            //if (_PersonID != -1)
            //{
            //    DataBack?.Invoke(this, _Person.NationalNO);
            //    this.Close();
            //}
            //else
            //{
            //    this.Close();
            //}

            this.Close();

        }

        private void frmAddEditPerson_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (_PersonID != -1)
            {
                DataBack?.Invoke(this, _Person.NationalNO);
                //this.Close();
            }
            else
            {
                //this.Close();
            }

        }
    }
}
