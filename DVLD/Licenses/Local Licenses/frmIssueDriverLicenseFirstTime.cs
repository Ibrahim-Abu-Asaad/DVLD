using DVLD.Global_Classes;
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
    public partial class frmIssueDriverLicenseFirstTime : UIForm
    {

        private int _LDLAppID = -1;
        private clsLocalDrivingLicenseApplication _LDLApp;

        private int _LicenseID = -1;


        public frmIssueDriverLicenseFirstTime(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            _LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(_LDLAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {

            rtxtNotes.Focus();

            if (_LDLApp == null)
            {

                MessageBox.Show("No Application with ID=" + _LDLAppID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            if (!_LDLApp.IsPassedAllTests())
            {

                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = _LDLApp.GetActiveLicenseID();
            if (LicenseID != -1)
            {

                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }

            ctrlLocalDrivingLicenseAppInfo1.LoadAllData(_LDLAppID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int CreatedByUserID = clsGlobal.CurrentUser.ID;
            _LicenseID = _LDLApp.IssueLicenseForTheFirstTime(rtxtNotes.Text, CreatedByUserID);

            if (_LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + _LicenseID.ToString(),
                    "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("License Was not Issued ! ",
                 "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}
