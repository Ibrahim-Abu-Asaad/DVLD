using DVLD.Global_Classes;
using DVLD.Properties;
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

namespace DVLD.Tests.Controls
{
    public partial class ctrlSheduleTest : UIUserControl
    {
        public ctrlSheduleTest()
        {
            InitializeComponent();
        }

        public enum enMode { AddNew, Update };
        private enMode _Mode = enMode.AddNew;

        public enum enCreationMode { FirstTimeSchedule, RetakeTestSchedule };
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private int _LDLAppID = -1;
        private clsTestAppointment _TestAppointment;
        private int _TestAppointmentID = -1;

        public clsTestType.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {

                _TestTypeID = value;

                switch (_TestTypeID)
                {

                    case clsTestType.enTestType.VisionTest:
                        {
                            lblTestType.Text = "Vision Test";
                            pbTestImage.Image = Resources.Vision_512;
                            break;
                        }
                    case clsTestType.enTestType.WrittenTest:
                        {
                            lblTestType.Text = "Written Test";
                            pbTestImage.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clsTestType.enTestType.StreetTest:
                        {
                            lblTestType.Text = "Street Test";
                            pbTestImage.Image = Resources.driving_test_512;
                            break;
                        }

                }

            }
        }

        public void LoadInfo(int LDLAppID, int TestAppointmentID = -1)
        {

            if (TestAppointmentID != -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            _LDLAppID = LDLAppID;
            _LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);
            _TestAppointmentID = TestAppointmentID;
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);

            if (_LDLApp == null)
            {
                MessageBox.Show("There is no local driving license application with ID = " + _LDLAppID.ToString(), "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbRetakeTest.Enabled = false;
                return;
            }

            if (_LDLApp.DoesAttendTestType(_TestTypeID))
                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;

            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {

                lblRAppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest).Fees.ToString();
                gbRetakeTest.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRTestAppID.Text = "0";

            }
            else
            {

                gbRetakeTest.Enabled = false;
                lblTitle.Text = "Schedule Test";
                lblFees.Text = "0";
                lblRTestAppID.Text = "N/A";

            }

            lblDLAppID.Text = _LDLAppID.ToString();
            lblDClass.Text = _LDLApp.LicenseClassInfo.Name;
            lblName.Text = clsFormat.FullNameOf4Names(_LDLApp.PersonInfo.FirstName, _LDLApp.PersonInfo.SecondName, _LDLApp.PersonInfo.ThirdName, _LDLApp.PersonInfo.LastName);

            lblTrial.Text = _LDLApp.TotalTrialPerTest(_TestTypeID).ToString();

            if (_Mode == enMode.AddNew)
            {

                lblFees.Text = clsTestType.GetTestTypeByID((int)_TestTypeID).Fees.ToString();
                dtpDate.MinDate = DateTime.Now;
                lblRTestAppID.Text = "N/A";

                _TestAppointment = new clsTestAppointment();

            }
            else
            {

                if (!_LoadTestAppointmentData())
                    return;

            }

            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRAppFees.Text)).ToString();

            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            //if (!HandlePrviousTestConstraint())
            //    return;



        }

        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = _TestAppointment.PaidFees.ToString();

            //we compare the current date with the appointment date to set the min date.
            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtpDate.MinDate = DateTime.Now;
            else
                dtpDate.MinDate = _TestAppointment.AppointmentDate;

            dtpDate.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lblFees.Text = "0";
                lblRTestAppID.Text = "N/A";
            }
            else
            {
                lblFees.Text = _TestAppointment.RetakeTestAppInfo.PaidFees.ToString();
                gbRetakeTest.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();

            }
            return true;
        }

        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LDLAppID, _TestTypeID))
            {
                lblMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dtpDate.Enabled = false;
                return false;
            }

            return true;
        }

        private bool _HandleAppointmentLockedConstraint()
        {

            if (_TestAppointment.IsLocked)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Person already sat for the test, appointment locked.";
                dtpDate.Enabled = false;
                btnSave.Enabled = false;
                return false;

            }
            else
                lblMessage.Visible = false;

            return true;
        }

        //private bool _HandlePrviousTestConstraint()
        //{

        //    switch (TestTypeID)
        //    {
        //        case clsTestType.enTestType.VisionTest:

        //            lblMessage.Visible = false;

        //            return true;

        //        case clsTestType.enTestType.WrittenTest:
        //            if (!_LDLApp.DoesPassTestType(clsTestType.enTestType.VisionTest))
        //            {
        //                lblMessage.Text = "Cannot Schedule, Vision Test should be passed first";
        //                lblMessage.Visible = true;
        //                btnSave.Enabled = false;
        //                dtpDate.Enabled = false;
        //                return false;
        //            }
        //            else
        //            {
        //                lblMessage.Visible = false;
        //                btnSave.Enabled = true;
        //                dtpDate.Enabled = true;
        //            }


        //            return true;

        //        case clsTestType.enTestType.StreetTest:

        //            if (!_LDLApp.DoesPassTestType(clsTestType.enTestType.WrittenTest))
        //            {
        //                lblMessage.Text = "Cannot Schedule, Written Test should be passed first";
        //                lblMessage.Visible = true;
        //                btnSave.Enabled = false;
        //                dtpDate.Enabled = false;
        //                return false;
        //            }
        //            else
        //            {
        //                lblMessage.Visible = false;
        //                btnSave.Enabled = true;
        //                dtpDate.Enabled = true;
        //            }


        //            return true;

        //    }
        //    return true;

        //}

        private bool _HandleRetakeApplication()
        {

            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {

                clsApplication Application = new clsApplication();

                Application.ApplicantPersonID = _LDLApp.ApplicantPersonID;
                Application.Date = DateTime.Now;
                Application.AppTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                Application.AppStatus = clsApplication.enApplicationStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = (float)clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest).Fees;
                Application.CreatedByUserID = clsGlobal.CurrentUser.ID;

                if (!Application.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Failed to Create application", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = Application.ApplicationID;

            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LDLApp.LocalDrivingLicenseApplicationID;
            _TestAppointment.AppointmentDate = dtpDate.Value;
            _TestAppointment.PaidFees = Convert.ToSingle(lblFees.Text);
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.ID;

            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

