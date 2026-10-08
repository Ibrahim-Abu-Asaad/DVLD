using DVLD.Global_Classes;
using DVLD.Properties;
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

namespace DVLD.Licenses.Local_Licenses
{
    public partial class ctrlDriverLicenseInfo : UIUserControl
    {


        private int _LDLAppID = -1;
        private clsLocalDrivingLicenseApplication _LDLApp;

        private int _LicenseID = -1;
        private clsLicense _License;


        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get { return _License; }
        }

        public void RefreshInformation()
        {
            if (!clsLicense.IsLicenseExistByID(_LicenseID))
                return;

            LoadAllDataByLicenseID(_LicenseID);
        }

        public void RefreshInformation(int licenseID)
        {
            if (!clsLicense.IsLicenseExistByID(licenseID))
                return;

            LoadAllDataByLicenseID(licenseID);
        }
        public void LoadAllData(int LDLAppID)
        {


            _LDLAppID = LDLAppID;
            _LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(_LDLAppID);
            //_LicenseID = _LDLApp.GetActiveLicenseID();
            //_License = clsLicense.Find(_LicenseID);

            //lblClass.Text = _License.LicenseClassInfo.Name;

            //lblName.Text = _License.DriverInfo.PersonInfo.GetFullName();

            //lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNO;

            //lblGender.Text = _License.DriverInfo.PersonInfo.GetPersonGender();

            //lblIssueDate.Text = _License.IssueDate.ToString();

            //lblIssueReason.Text = _License.IssueReasonText;

            //lblNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;

            //lblIsActive.Text = _License.IsActive ? "Yes" : "No";

            //lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString();

            //lblExpirationDate.Text = _License.ExpirationDate.ToString();

            //lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";

            //_LoadPersonImage();

            LoadAllDataByLicenseID(_LDLApp.GetActiveLicenseID());

        }

        public void LoadAllDataByLicenseID(int LicenseID)
        {

            _LicenseID = LicenseID;
            _License = clsLicense.Find(_LicenseID);

            if(_License == null)
            {
                MessageBox.Show("License With ID: " + _LicenseID + " is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetInformationToDefault();
                return;
            }

            lblLicenseID.Text = LicenseID.ToString();

            lblClass.Text = _License.LicenseClassInfo.Name;

            lblName.Text = _License.DriverInfo.PersonInfo.GetFullName();

            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNO;

            lblGender.Text = _License.DriverInfo.PersonInfo.GetPersonGender();

            lblIssueDate.Text = _License.IssueDate.ToString();

            lblIssueReason.Text = _License.IssueReasonText;

            lblNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;

            lblIsActive.Text = _License.IsActive ? "Yes" : "No";

            lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString();

            lblExpirationDate.Text = _License.ExpirationDate.ToString();

            lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";

            _LoadPersonImage();

        }

        public void ResetInformationToDefault()
        {

            _LicenseID = -1;
            _License = new clsLicense();

            lblLicenseID.Text = "[????]";

            lblClass.Text = "[????]";

            lblName.Text = "[????]";

            lblNationalNo.Text = "[????]";

            lblGender.Text = "[????]";

            lblIssueDate.Text = "[????]";

            lblIssueReason.Text = "[????]";

            lblNotes.Text = "[????]";

            lblIsActive.Text = "[????]";

            lblDateOfBirth.Text = "[????]";

            lblExpirationDate.Text = "[????]";

            lblIsDetained.Text = "[????]";

            pbPersonImage.Image = Resources.Male_512;

        }

        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }








        private void uiGroupBox1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
