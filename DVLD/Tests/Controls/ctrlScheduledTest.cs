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
using static DVLD_BLL.clsTestType;

namespace DVLD.Tests.Controls
{
    public partial class ctrlScheduledTest : UIUserControl
    {

        private clsTestType.enTestType _TestTypeID;
        private int _TestID = -1;

        private clsLocalDrivingLicenseApplication _LDLApp;

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

        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }

        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        private int _TestAppointmentID = -1;
        private int _LDLAppID = -1;
        private clsTestAppointment _TestAppointment;

        public void LoadInfo(int TestAppointmentID)
        {

            _TestAppointmentID = TestAppointmentID;


            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }

            _TestID = _TestAppointment.TestID;

            _LDLAppID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(_LDLAppID);

            if (_LDLApp == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LDLAppID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDLAppID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = _LDLApp.LicenseClassInfo.Name;

            clsPerson person = clsPerson.Find(_LDLApp.ApplicantPersonID);
            lblName.Text = clsFormat.FullNameOf3Names(person.FirstName, person.SecondName, person.LastName);

            lblTrial.Text = _LDLApp.TotalTrialPerTest(_TestTypeID).ToString();



            lblDate.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblTestID.Text = (_TestAppointment.TestID == -1) ? "Not Taken Yet" : _TestAppointment.TestID.ToString();



        }

        public ctrlScheduledTest()
        {
            InitializeComponent();
        }
    }
}
