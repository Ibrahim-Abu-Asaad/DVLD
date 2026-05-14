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

namespace DVLD.Applications.TestTypes
{
    public partial class frmEditTestTypes : UIForm
    {

        int _TestTypeID = -1;
        clsTestType _TestType = new clsTestType();

        public frmEditTestTypes(int TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
            _TestType = clsTestType.GetTestTypeByID(TestTypeID);
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {

            _FillTestTypeInfoInTheForm();

        }

        private void _FillTestTypeInfoInTheForm()
        {

            txtTitle.Text = _TestType.Title;
            rtxtDescription.Text = _TestType.Description;
            txtFees.Text = _TestType.Fees.ToString();



        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
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

            if (clsValidation.IsEmpty(rtxtDescription.Text, ref ErrorMessage))
            {
                errorProvider1.SetError(rtxtDescription, "Description is required");
                return false;
            }

            if (clsValidation.IsEmpty(txtFees.Text, ref ErrorMessage))
            {
                errorProvider1.SetError(txtFees, "Fees is required");
                return false;
            }




            return true;

        }

        private void _FilltxtInfosIntoObject()
        {

            _TestType.Title = txtTitle.Text.Trim();
            _TestType.Description = rtxtDescription.Text;

            if (decimal.TryParse(txtFees.Text, out decimal fees))
                _TestType.Fees = fees;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_Validation())
                return;

            _FilltxtInfosIntoObject();

            if (_TestType.Save())
                MessageBox.Show("Data Saved Successfully.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data Failed to Save.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();

        }
    }
}
