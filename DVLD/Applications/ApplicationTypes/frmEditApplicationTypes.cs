using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Helpers;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD
{
    public partial class frmEditApplicationTypes : UIForm
    {

        int _ApplicationTypeID = -1;
        clsApplicationType _ApplicationType = new clsApplicationType();

        public frmEditApplicationTypes(int ApplicationTypeID)
        {
            InitializeComponent();

            _ApplicationType = clsApplicationType.Find(ApplicationTypeID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_Validation())
                return;

            _FilltxtInfosIntoObject();

            if (_ApplicationType.Save())
                MessageBox.Show("Data Saved Successfully.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data Failed to Save.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();

        }

        private void _FilltxtInfosIntoObject()
        {

            _ApplicationType.Title = txtTitle.Text.Trim();

            if (decimal.TryParse(txtFees.Text, out decimal fees))
                _ApplicationType.Fees = fees;

        }

        private bool _Validation()
        {
            //

            errorProvider1.Clear();

            string ErrorMessage = "";
            if (clsValidation.IsEmpty(txtTitle.Text, ref ErrorMessage))
            {
                errorProvider1.SetError(txtTitle, "Title is required");
                return false;
            }

            if (clsValidation.IsEmpty(txtFees.Text, ref ErrorMessage))
            {
                errorProvider1.SetError(txtFees, "Fees is required");
                return false;
            }


            return true;

        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            _FillApplicationTypeDataInForm();
        }

        private void _FillApplicationTypeDataInForm()
        {

            txtTitle.Text = _ApplicationType.Title;
            txtFees.Text = _ApplicationType.Fees.ToString(); ;



        }



    }
}
