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

namespace DVLD.Applications.Renew_Local_License
{
    public partial class frmRenewLocalDrivingLicenseApplication : UIForm
    {
        public frmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
        }

        private int _NewLicenseID = -1;
        private int _SelectedLicenseID = -1;

        public void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int LicenseID)
        {

            //if (LicenseID == -1)
            //    return;
            _SelectedLicenseID = LicenseID;

            if (!clsLicense.IsLicenseExistByID(LicenseID))
            {
                //MessageBox.Show("There is no license with this ID", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                return;
            }

            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicense.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("This license still active and is not expired", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnRenew.Enabled = true;

            int SelectedLicenseID = LicenseID;

            lblOldLicenseID.Text = SelectedLicenseID.ToString();

            llblShowLicensesHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
                return;

            int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.LicenseClassInfo.DefaultValidityLength;
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            decimal LicenseFees = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.LicenseClassInfo.ClassFees;
            lblLicenseFees.Text = LicenseFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            rtxtNotes.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicense.Notes;


            //check the license is not Expired.
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicense.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expired, it will expire on: " + clsFormat.DateToShort(ctrlDriverLicenseInfoWithFilter1.SelectedLicense.ExpirationDate)
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            //check the license is not Active.
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicense.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }



            btnRenew.Enabled = true;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlDriverLicenseInfoWithFilter1_Click(object sender, EventArgs e)
        {
            //
        }

        private void frmRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.txtSearchByFocus();


            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;

            lblExpirationDate.Text = "???";
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
            _ResetDefaultValues();
            

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {

            if(ctrlDriverLicenseInfoWithFilter1.SelectedLicense.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("This license still active and is not expired", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            clsLicense NewLicense =
                ctrlDriverLicenseInfoWithFilter1.SelectedLicense.RenewLicense(rtxtNotes.Text.Trim(),
                clsGlobal.CurrentUser.ID);

            if (NewLicense == null)
            {
                MessageBox.Show("Failed to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblRLApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.ID;
            lblRenewdLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llblShowNewLicenseInfo.Enabled = true;

        }

        private void _ResetDefaultValues()
        {
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;

            lblExpirationDate.Text = "[???]";
            lblOldLicenseID.Text = "[???]";
            lblRenewdLicenseID.Text = "[???]";
            lblRLApplicationID.Text = "[???]";

            decimal ApplicationFees = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).Fees;
            lblApplicationFees.Text = ApplicationFees.ToString();
            lblLicenseFees.Text = "[$$$]";
            lblTotalFees.Text = "[$$$]";

            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
            rtxtNotes.Text = "";

            btnRenew.Enabled = false;
            llblShowLicensesHistory.Enabled = false;
            llblShowNewLicenseInfo.Enabled = false;
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!clsLicense.IsLicenseExistByID(_NewLicenseID))
            {
                MessageBox.Show("No License with this ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowLicenseInfo frm = new frmShowLicenseInfo(_NewLicenseID, true);
            frm.ShowDialog();
        }
    }
}
