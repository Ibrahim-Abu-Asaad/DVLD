using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Drivers;
using DVLD.Global_Classes;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD.Applications.International_Licenses
{
    public partial class frmNewInternationalLicenseApplication : UIForm
    {

        private int _LicenseID = -1;
        private clsLicense _License;
        private int _InternationalLicenseID = -1;

        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += CtrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
        }

        private void CtrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int licenseID)
        {

            llblShowInternationalLicenseInfo.Enabled = false;
            lblLocalLicenseID.Text = licenseID.ToString();

            _LicenseID = licenseID;
            _License = clsLicense.Find(_LicenseID);

            if (clsLicense.IsLicenseExistByID(licenseID))
                llblShowLicensesHistory.Enabled = true;
            else
            {
                _Disabled();
                return;
            }


            if (!_Validation())
                return;

            _Enabled();

        }

        private bool _Validation()
        {

            if (_LicenseID == -1)
                return false;

            if (!_License.IsActive)
            {
                MessageBox.Show("This license is not active, you can not issue an international license for this person", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show("This license is detained, you can not issue an international license for this person", "Detained", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_License.LicenseClass != 3)
            {
                MessageBox.Show("Your local license is not class 3, you can not issue an international license for this person", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int ActiveInternationalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(_License.DriverID);

            if (ActiveInternationalLicenseID != -1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternationalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblShowInternationalLicenseInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternationalLicenseID;
                btnIssueInternationalLicense.Enabled = false;
                return false;
            }


            return true;

        }

        private void ctrlDriverLicenseInfoWithFilter1_Click(object sender, EventArgs e)
        {
            //
        }

        private void _Disabled()
        {
            btnIssueInternationalLicense.Enabled = false;
            llblShowInternationalLicenseInfo.Enabled = false;
            llblShowLicensesHistory.Enabled = false;
        }

        private void _Enabled()
        {
            btnIssueInternationalLicense.Enabled = true;
            //llblShowInternationalLicenseInfo.Enabled = true;
            llblShowLicensesHistory.Enabled = true;
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            _Disabled();
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(1));
            float fees = (float)clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalDrivingLicense).Fees;
            lblFees.Text = fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
        }

        private void btnIssueInternationalLicense_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsInternationalLicense internationalLicense = new clsInternationalLicense();

            internationalLicense.ApplicantPersonID = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.DriverInfo.PersonID;
            internationalLicense.Date = DateTime.Now;
            internationalLicense.AppStatus = clsApplication.enApplicationStatus.Completed;
            internationalLicense.LastStatusDate = DateTime.Now;
            internationalLicense.PaidFees = (float)clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalDrivingLicense).Fees;
            internationalLicense.CreatedByUserID = clsGlobal.CurrentUser.ID;


            internationalLicense.DriverID = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.DriverID;
            internationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.ID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);

            internationalLicense.CreatedByUserID = clsGlobal.CurrentUser.ID;

            if (!internationalLicense.Save())
            {
                MessageBox.Show("Failed to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblInternationalLicenseApplicationID.Text = internationalLicense.ApplicationID.ToString();
            _InternationalLicenseID = internationalLicense.ID;
            lblInternationalLicenseID.Text = internationalLicense.ID.ToString();
            MessageBox.Show("International License Issued Successfully with ID=" + internationalLicense.ID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ctrlDriverLicenseInfoWithFilter1.RefreshInformationByThisLicenseID(_LicenseID);

            btnIssueInternationalLicense.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llblShowInternationalLicenseInfo.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(_License.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llblShowInternationalLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //
        }
    }
}
