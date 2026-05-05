using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using DVLD_BLL;
using Sunny.UI;
using Sunny.UI.Win32;

namespace DVLD
{
    public partial class ctrlShowPersonDetails2 : UIUserControl
    {

        private int _PersonID = -1;
        private clsPerson _Person;

        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        private string _NationalNO = "";

        public string NationalNO
        {
            get { return _NationalNO; }
        }

        public ctrlShowPersonDetails2()
        {
            InitializeComponent();
        }

        public void ResetToDefault()
        {

            _PersonID = -1;
            _Person = null;


            lblName.Text = "[?????]";
            lblNationalNO.Text = "[?????]";
            lblGender.Text = "[?????]";
            lblEmail.Text = "[?????]";
            lblAddress.Text = "[?????]";
            lblDateOfBirth.Text = "[?????]";
            lblPhone.Text = "[?????]";
            lblCountry.Text = "[?????]";
            pbPersonImage.Image = Resources.Male_512;

        }

        private void _LoadPersonImage()
        {

            if (_Person == null) return;

            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else pbPersonImage.Image = Resources.Female_512;

            string PersonImagePath = _Person.ImagePath;

            if (PersonImagePath != "")
                if (File.Exists(PersonImagePath))
                    pbPersonImage.ImageLocation = PersonImagePath;
                else
                    MessageBox.Show("Could Not Find The Image");




        }

        public void LoadPersonDataAndFillPersonCard(int ID)
        {

            _PersonID = ID;
            _Person = clsPerson.Find(ID);

            if (_Person == null)
            {
                ResetToDefault();
                MessageBox.Show("No Person with ID = " + ID);
                return;
            }

            _PersonID = _Person.ID;

            lblNationalNO.Text = _Person.NationalNO;
            lblName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();

            lblGender.Text = (_Person.Gender == 0) ? "Male" : "Female";

            lblCountry.Text = _Person.CountryInfo.CountryName;

            _LoadPersonImage();

        }

        public void LoadPersonDataAndFillPersonCard(string NationalNO)
        {

            _Person = clsPerson.Find(NationalNO);

            if (_Person == null)
            {

                ResetToDefault();
                MessageBox.Show("No Person with National No = [" + NationalNO + "]",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _PersonID = _Person.ID;

            lblNationalNO.Text = _Person.NationalNO;
            lblName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();

            lblGender.Text = (_Person.Gender == 0) ? "Male" : "Female";

            lblCountry.Text = _Person.CountryInfo.CountryName;

            _LoadPersonImage();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (_PersonID == -1 || _Person == null)
            {
                MessageBox.Show("Person Not Found",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();

            LoadPersonDataAndFillPersonCard(_PersonID);

        }

    }
}
