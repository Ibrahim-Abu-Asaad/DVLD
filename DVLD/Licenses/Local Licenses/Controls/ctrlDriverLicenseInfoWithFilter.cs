using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using DVLD_BLL;

namespace DVLD.Licenses.Local_Licenses.Controls
{
    public partial class ctrlDriverLicenseInfoWithFilter : UIUserControl
    {


        public delegate void LicenseSelectedEventHandler(int LicenseID);

        public event LicenseSelectedEventHandler OnLicenseSelected;
        protected virtual void PersonSelected(int LicenseID)
        {
            LicenseSelectedEventHandler handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }

        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
            txtSearchBy.Focus();
        }

        //public void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected()
        //{
        //    //



        //}

        private int _LicenseID = -1;
        public int LicenseID
        {
            get { return ctrlDriverLicenseInfo1.LicenseID; }
        }
        public clsLicense SelectedLicense
        {
            get { return clsLicense.Find(_LicenseID); }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private void _LoadData(int LicenseID)
        {
            _LicenseID = LicenseID;
            clsLicense License = clsLicense.Find(LicenseID);
            ctrlDriverLicenseInfo1.LoadAllDataByLicenseID(LicenseID);

            if (OnLicenseSelected != null && FilterEnabled)
                OnLicenseSelected(_LicenseID);

        }

        public void RefreshInformation()
        {
            if (!clsLicense.IsLicenseExistByID(_LicenseID))
                return;

            ctrlDriverLicenseInfo1.RefreshInformation();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchBy.Text.IsNullOrEmpty())
            {
                MessageBox.Show("You have to enter an ID", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlDriverLicenseInfo1.ResetInformationToDefault();
                return;
            }


            if (int.TryParse(txtSearchBy.Text, out int licenseId))
                _LicenseID = licenseId;
            _LoadData(_LicenseID);
        }

        public void txtSearchByFocus()
            => txtSearchBy.Focus();

        private void txtSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void txtSearchBy_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearchBy.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSearchBy, "This field is required!");
                ctrlDriverLicenseInfo1.ResetInformationToDefault();
            }
            else
            {
                errorProvider1.SetError(txtSearchBy, null);
            }

        }
    }
}
