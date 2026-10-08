using DVLD.Drivers;
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

namespace DVLD.Applications.Release_Local_License
{
    public partial class frmReleaseDetainedLicense : UIForm
    {

        private int _LicenseID = -1;
        clsLicense _License;

        public enum enMode { OnlyOneID, AcceptAnyID}
        public enMode Mode = enMode.AcceptAnyID;

        public frmReleaseDetainedLicense(int licenseID)
        {
            InitializeComponent();
            Mode = enMode.OnlyOneID;
            _LicenseID = licenseID;
            _License = clsLicense.Find(_LicenseID);
            ctrlDriverLicenseInfoWithFilter1.WriteInTheTextBox(licenseID);
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            ctrlDriverLicenseInfoWithFilter1.FillInformation(licenseID);
            _LoadDetainedLicenseData();
        }

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
            Mode = enMode.AcceptAnyID;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += CtrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
        }

        private void _EnabledWhenNeeded()
        {
            llblShowPersonLicensesHistory.Enabled = true;
            btnRelease.Enabled = true;
        }

        private void _DisabledWhenNeeded()
        {
            llblShowPersonLicensesHistory.Enabled = false;
            btnRelease.Enabled = false;
        }


        private void CtrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int LicenseID)
        {

            _LicenseID = LicenseID;
            _License = clsLicense.Find(LicenseID);

            if (!_Validation())
                return;

            _EnabledWhenNeeded();

            _LoadDetainedLicenseData();

        }

        private void _LoadDetainedLicenseData()
        {
            lblDetainID.Text = _License.DetainedInfo.ID.ToString();
            lblDetainDate.Text = _License.DetainedInfo.DetainDate.TimeString();
            lblLicenseID.Text = _LicenseID.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.ID.ToString();
            float fees = (float)clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense).Fees;
            lblApplicationFees.Text = fees.ToString();
            lblFineFees.Text = _License.DetainedInfo.FineFees.ToString();
            float totalFees = fees + (float)_License.DetainedInfo.FineFees;
            lblTotalFees.Text = totalFees.ToString();
        }

        private void _ResetForm()
        {
            _DisabledWhenNeeded();
            lblDetainID.Text = "[????]";
            lblDetainDate.Text = "[????]";
            lblLicenseID.Text = "[????]";
            lblCreatedBy.Text = "[????]";
            lblApplicationFees.Text = "[$$$$]";
            lblFineFees.Text = "[$$$$]";
            lblTotalFees.Text = "[$$$$]";
            lblApplicationID.Text = "[????]";
        }

        private bool _Validation()
        {

            if (_License == null)
            {
                //MessageBox.Show("This license is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetForm();
                return false;
            }

            if (!_License.IsActive)
            {
                MessageBox.Show("This license is not active, you can't release it.", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!_License.IsDetained)
            {
                MessageBox.Show("This license is not detained, you can not release it.", "Not Detained", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.AcceptAnyID)
                _DisabledWhenNeeded();
            else _EnabledWhenNeeded();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.No)
                return;

            int ApplicationID = -1;
            bool IsReleased = _License.ReleaseDetainedLicense(clsGlobal.CurrentUser.ID, ref ApplicationID);

            if (!IsReleased)
            {
                MessageBox.Show("This license still detained and not released, please talk to the officer", "Not Released", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("The license is released successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblApplicationID.Text = ApplicationID.ToString();

            btnRelease.Enabled = false;

            if (Mode == enMode.AcceptAnyID)
                ctrlDriverLicenseInfoWithFilter1.RefreshInformation();
            else
                ctrlDriverLicenseInfoWithFilter1.RefreshInformationByThisLicenseID(_LicenseID);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowPersonLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(_License.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
