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

namespace DVLD.Licenses.International_Licenses.Controls
{
    public partial class ctrlDriverInternationalLicenseInfo : UIUserControl
    {

        private int _InternationalLicenseID = -1;
        private clsInternationalLicense _InternationalLicense;

        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public int InternationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }

        public void LoadData(int internationalLicenseID)
        {
            _InternationalLicenseID = internationalLicenseID;
            _InternationalLicense = clsInternationalLicense.Find(internationalLicenseID);

            if(_InternationalLicense == null)
            {
                _InternationalLicenseID = -1;
                MessageBox.Show("International license is not exist!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblInternationalLicenseID.Text = internationalLicenseID.ToString();
            lblName.Text = _InternationalLicense.DriverInfo.PersonInfo.GetFullName();
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNO.ToString();
            lblGender.Text = _InternationalLicense.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();

            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";

            lblDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();

            _LoadPersonImage();

        }

        private void _LoadPersonImage()
        {

            if (_InternationalLicense.DriverInfo.PersonInfo.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }




    }
}
