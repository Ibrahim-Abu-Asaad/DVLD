using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Global_Classes;
using DVLD.Licenses.Local_Licenses;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    public partial class frmReplaceLostOrDamagedLicenseApplication : UIForm
    {
        public frmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += DriverLicenseInfoWithFilterControl_OnLicenseSelected;
        }

        private enum enIssueReason { Damaged, Lost }
        private enIssueReason IssueReason = enIssueReason.Damaged;

        private int _LicenseID = -1;
        private clsLicense _License = new clsLicense();
        private clsLicense _NewLicense = new clsLicense();

        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {

            llblShowLicensesHistory.Enabled = false;
            llblShowNewLicenseInfo.Enabled = false;
            rbtnDamaged.Checked = true;
            rbtnLost.Checked = false;

            btnIssueReplacement.Enabled = false;

        }

        private void DriverLicenseInfoWithFilterControl_OnLicenseSelected(int LicenseID)
        {

            _LicenseID = LicenseID;
            _License = clsLicense.Find(_LicenseID);

            gbReplaceFor.Enabled = true;
            lblReplacedLicenseID.Text = "[????]";
            lblRLApplicationID.Text = "[????]";

            llblShowNewLicenseInfo.Enabled = false;

            if (!clsLicense.IsLicenseExistByID(_LicenseID))
                llblShowLicensesHistory.Enabled = false;
            else llblShowLicensesHistory.Enabled = true;

            if (!_Validation())
                return;

            _LoadData();
            btnIssueReplacement.Enabled = true;

        }

        private bool _Validation()
        {

            //llblShowNewLicenseInfo.Enabled = (_LicenseID != -1);

            if (_LicenseID == -1)
                return false;

            if (!clsLicense.IsLicenseExistByID(_LicenseID))
            {
                //MessageBox.Show("This license is not exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetForm();
                return false;

            }

            if (!_License.IsActive)
            {
                MessageBox.Show("This license is not active, you can not replace it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetForm();
                return false;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show("This license is detained, you can not replace it", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetForm();
                return false;
            }

            return true;

        }

        private void _ResetForm()
        {

            btnIssueReplacement.Enabled = false;

            lblApplicationDate.Text = "[????]";

            lblOldLicenseID.Text = "[????]";

            lblCreatedBy.Text = "[????]";

        }

        private void _LoadData()
        {

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            decimal fees = 0;
            if (rbtnDamaged.Checked)
                fees = clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense).Fees;
            else fees = clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceLostDrivingLicense).Fees;

            lblApplicationFees.Text = fees.ToString();
            lblOldLicenseID.Text = _LicenseID.ToString();

            string Name = clsUser.GetUserByUsername(clsGlobal.CurrentUser.Username).PersonInfo.FirstName + ' ' + clsUser.GetUserByUsername(clsGlobal.CurrentUser.Username).PersonInfo.LastName;
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username + '(' + Name + ')';



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnDamaged_CheckedChanged(object sender, EventArgs e)
        {
            IssueReason = enIssueReason.Damaged;
            decimal fees = clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense).Fees;
            lblApplicationFees.Text = fees.ToString();
        }

        private void rbtnLost_CheckedChanged(object sender, EventArgs e)
        {
            IssueReason = enIssueReason.Lost;
            decimal fees = clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceLostDrivingLicense).Fees;
            lblApplicationFees.Text = fees.ToString();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {



            //_NewLicense = _License.Replace(clsLicense.enIssueReason.DamagedReplacement, clsGlobal.CurrentUser.ID);
            //MessageBox.Show("Replace");
            if (IssueReason == enIssueReason.Damaged)
                _NewLicense = _License.Replace(clsLicense.enIssueReason.DamagedReplacement, clsGlobal.CurrentUser.ID);
            else _NewLicense = _License.Replace(clsLicense.enIssueReason.LostReplacement, clsGlobal.CurrentUser.ID);

            if (_NewLicense == null)
            {
                MessageBox.Show("Data is not saved!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                MessageBox.Show("Data is saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueReplacement.Enabled = false;
            lblReplacedLicenseID.Text = _NewLicense.ID.ToString();
            lblRLApplicationID.Text = _NewLicense.ApplicationID.ToString();
            llblShowNewLicenseInfo.Enabled = true;
            ctrlDriverLicenseInfoWithFilter1.RefreshInformation();
            gbReplaceFor.Enabled = false;

        }

        private void ctrlDriverLicenseInfoWithFilter1_Click(object sender, EventArgs e)
        {
            //
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_NewLicense == null)
                return;

            frmShowLicenseInfo frm = new frmShowLicenseInfo(_NewLicense.ID, true);
            frm.ShowDialog();
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //
        }



    }
}
