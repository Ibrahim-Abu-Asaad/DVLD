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


        //public ctrlDriverLicenseInfo(int LDLAppID)
        //{
        //    InitializeComponent();

        //    _LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(_LDLAppID);
        //    _LicenseID = _LDLApp.GetActiveLicenseID();
        //    _License = clsLicense.Find(_LicenseID);

        //    //LoadAllData();
        //}

        public void LoadAllData(int LDLAppID)
        {

            _LDLAppID = LDLAppID;
            _LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(_LDLAppID);
            _LicenseID = _LDLApp.GetActiveLicenseID();
            _License = clsLicense.Find(_LicenseID);

            lblClass.Text = _LDLApp.LicenseClassInfo.Name;

            string FullName = clsFormat.FullNameOf4Names(_LDLApp.PersonInfo.FirstName, _LDLApp.PersonInfo.SecondName, _LDLApp.PersonInfo.ThirdName, _LDLApp.PersonInfo.LastName);
            lblName.Text = FullName;

            lblNationalNo.Text = _LDLApp.PersonInfo.NationalNO;

            lblGender.Text = _LDLApp.PersonInfo.GetPersonGender();

            lblIssueDate.Text = _License.IssueDate.ToString();

            lblIssueReason.Text = _License.IssueReasonText;

            lblNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;

            lblIsActive.Text = _License.IsActive ? "Yes" : "No";

            lblDateOfBirth.Text = _LDLApp.PersonInfo.DateOfBirth.ToString();

            lblExpirationDate.Text = _License.ExpirationDate.ToString();

            lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";

            _LoadPersonImage();

        }

        private void _LoadPersonImage()
        {
            if (_LDLApp.PersonInfo.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _LDLApp.PersonInfo.ImagePath;

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
