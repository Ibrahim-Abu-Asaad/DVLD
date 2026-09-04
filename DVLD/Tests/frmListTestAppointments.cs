using DVLD.Applications.LocalDrivingLicenseApplications;
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

namespace DVLD.Tests
{
    public partial class frmListTestAppointments : UIForm
    {

        private DataTable _dtLicenseTestAppointments;
        private int _LDLAppID = -1;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;

        public frmListTestAppointments(int LDLAppID, clsTestType.enTestType TestTypeID)
        {
            _LDLAppID = LDLAppID;
            _TestTypeID = TestTypeID;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestTypeID)
            {

                case clsTestType.enTestType.VisionTest:
                    {
                        lblTestType.Text = "Vision Test Appointments";
                        this.Text = lblTestType.Text;
                        pbTestType.Image = Resources.Vision_512;
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        lblTestType.Text = "Written Test Appointments";
                        this.Text = lblTestType.Text;
                        pbTestType.Image = Resources.Written_Test_512;
                        break;
                    }
                case clsTestType.enTestType.StreetTest:
                    {
                        lblTestType.Text = "Street Test Appointments";
                        this.Text = lblTestType.Text;
                        pbTestType.Image = Resources.driving_test_512;
                        break;
                    }
            }
        }

        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {

            _LoadTestTypeImageAndTitle();

            ctrlLocalDrivingLicenseAppInfo1.LoadAllData(_LDLAppID);
            _dtLicenseTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LDLAppID, _TestTypeID);

            dgvLicenseTestAppointments.DataSource = _dtLicenseTestAppointments;
            lblTotalAppointments.Text = dgvLicenseTestAppointments.Rows.Count.ToString();

            if (dgvLicenseTestAppointments.Rows.Count > 0)
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }

        }

        





    }
}
