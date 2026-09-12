using DVLD.Global_Classes;
using DVLD.Tests.Controls;
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

namespace DVLD.Tests
{
    public partial class frmTakeTest : UIForm
    {

        private int _AppointmentID;
        private clsTestType.enTestType _TestType;

        private int _TestID = -1;
        private clsTest _Test;


        public frmTakeTest(int AppointmentID, clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestType = TestType;

            ctrlScheduledTest1.TestTypeID = _TestType;

            ctrlScheduledTest1.LoadInfo(_AppointmentID);

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            //ctrlScheduledTest1.TestTypeID = _TestType;

            //ctrlScheduledTest1.LoadInfo(_AppointmentID);

            if (ctrlScheduledTest1.TestAppointmentID == -1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;

            //
            _TestID = ctrlScheduledTest1.TestID;
            if (_TestID != -1)
            {
                _Test = clsTest.Find(_TestID);

                if (_Test.TestResult)
                    rbtnPass.Checked = true;
                else
                    rbtnFail.Checked = true;
                rtxtNotes.Text = _Test.Notes;

                lblMessage.Visible = true;
                rbtnFail.Enabled = false;
                rbtnPass.Enabled = false;
            }
            else
                _Test = new clsTest();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
               )
            {
                return;
            }

            if (_Test == null)
                _Test = new clsTest();

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rbtnPass.Checked;
            _Test.Notes = rtxtNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.ID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
