using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD.Applications.LocalDrivingLicenseApplications
{
    public partial class ctrlLocalDrivingLicenseAppInfo : UIUserControl
    {

        private clsLocalDrivingLicenseApplication _LDLApp;

        private int _LDLAppID = -1;

        private int _LicenseID;

        public int LocalDrivingLicenseApplicationID
        {
            get { return _LDLAppID; }
        }

        public ctrlLocalDrivingLicenseAppInfo()
        {
            InitializeComponent();
        }

        public void LoadAllData(int LDLAppID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);
            if (_LDLApp == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadAllDataByLDLAppID(LDLAppID);
        }

        public void LoadLocalDrivingLicenseApplicationInfoByApplicationID(int ApplicationID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByApplicationID(ApplicationID);
            if (_LDLApp == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadAllDataByLDLAppID(_LDLApp.ApplicationID);
        }

        private void LoadAllDataByLDLAppID(int LDLAppID)
        {
            //_LicenseID = _LDLApp.GetActiveLicenseID();

            //incase there is license enable the show link.
            //llShowLicenceInfo.Enabled = (_LicenseID != -1);


            //lblAppliedForLicense.Text = clsLicenseClass.Find(_LDLApp.LicenseClassID).ClassName;
            //lblPassedTests.Text = _LDLApp.GetPassedTestCount().ToString() + "/3";
            ctrlApplicationBasicInfo1.LoadApplicationBasicInfoByApplicationID(_LDLApp.ApplicationID);

        }

        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            _LDLAppID = -1;
            ctrlApplicationBasicInfo1.ResetApplicationInfo();
            lblAppliedForLicense.Text = "[????]";


        }

        private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmShowLicenseInfo frm = new frmShowLicenseInfo(_LDLApp.GetActiveLicenseID());
            //frm.ShowDialog();

        }










    }
}
