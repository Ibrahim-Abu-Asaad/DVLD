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
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
            txtSearchBy.Focus();
        }

        private int _LicenseID = -1;

        private void _LoadData(int LicenseID)
        {
            _LicenseID = LicenseID;
            clsLicense License = clsLicense.Find(LicenseID);
            ctrlDriverLicenseInfo1.LoadAllDataByLicenseID(LicenseID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchBy.Text, out int licenseId))
                _LicenseID = licenseId;
            _LoadData(_LicenseID);
        }

        private void txtSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }
    }
}
