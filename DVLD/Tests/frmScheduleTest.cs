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
    public partial class frmScheduleTest : UIForm
    {

        private int _LDLAppID = -1;
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;
        private int _TestAppointmentID = -1;

        public frmScheduleTest(int LDLAppID, clsTestType.enTestType TestType, int TestAppointmentID = -1)
        {
            InitializeComponent();

            _LDLAppID = LDLAppID;
            _TestType = TestType;
            _TestAppointmentID = TestAppointmentID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlSheduleTest1.TestTypeID = _TestType;
            ctrlSheduleTest1.LoadInfo(_LDLAppID, _TestAppointmentID);
        }
    }
}
