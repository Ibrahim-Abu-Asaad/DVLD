using DVLD.Drivers;
using DVLD.Global_Classes;
using DVLD.Licenses.Local_Licenses;
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

namespace DVLD.Applications.Detain_Local_License
{
    public partial class frmDetainLocalDrivingLicense : UIForm
    {
        private int _LicenseID = -1;
        private clsLicense _License;

        public frmDetainLocalDrivingLicense()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += CtrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            _DisabledWhenNedded();
        }

        public frmDetainLocalDrivingLicense(int licenseID)
        {
            InitializeComponent();
            //_PersonID = personID;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            _LicenseID = licenseID;
            _License = clsLicense.Find(licenseID);
        }

        private void _DisabledWhenNedded()
        {
            btnDetain.Enabled = false;
            llblShowLicenseInfo.Enabled = false;
            //llblShowPersonLicensesHistory.Enabled = false;

            txtFineFees.Text = string.Empty;
            txtFineFees.Enabled = false;
        }

        private void _EnabledWhenNedded()
        {
            btnDetain.Enabled = true;
            llblShowLicenseInfo.Enabled = true;
            llblShowPersonLicensesHistory.Enabled = true;
            txtFineFees.Enabled = true;
        }

        private void CtrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int LicenseID)
        {

            _LicenseID = LicenseID;
            _License = clsLicense.Find(LicenseID);

            if (!_Validation())
                return;

            _EnabledWhenNedded();

            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.ID.ToString();
            lblLicenseID.Text = _LicenseID.ToString();


        }

        private bool _Validation()
        {

            if (_License == null)
            {
                MessageBox.Show("License is not exist!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            llblShowPersonLicensesHistory.Enabled = true;

            if (!_License.IsActive)
            {
                MessageBox.Show("This license is not active, you can not detain it!", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show("This license is already detained, you can not detain it again!", "Already Detained", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {

            if (txtFineFees.Text == string.Empty)
                MessageBox.Show("Enter Fine Fees!", "Fine Fees Needed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            int FineFees = 0;
            if (int.TryParse(txtFineFees.Text, out int fineAmount))
                FineFees = fineAmount;

            int DetainID = _License.Detain(FineFees, clsGlobal.CurrentUser.ID);

            if (DetainID == -1)
            {
                MessageBox.Show("License is not detained!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("License is detained successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblDetainID.Text = DetainID.ToString();
            ctrlDriverLicenseInfoWithFilter1.RefreshInformation();
            _DisabledWhenNedded();
            llblShowPersonLicensesHistory.Enabled = true;
            //ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;

        }

        private void txtFineFees_TextChanged(object sender, EventArgs e)
        {

            //

        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(_License.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LicenseID, true);
            frm.ShowDialog();
        }

        private void frmDetainLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            llblShowLicenseInfo.Visible = false;
            llblShowPersonLicensesHistory.Enabled = false;
        }

        private void ctrlDriverLicenseInfoWithFilter1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
