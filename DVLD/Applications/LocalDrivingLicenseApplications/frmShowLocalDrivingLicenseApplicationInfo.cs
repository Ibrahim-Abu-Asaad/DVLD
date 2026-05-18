using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD.Applications.LocalDrivingLicenseApplications
{
    public partial class frmShowLocalDrivingLicenseApplicationInfo : UIForm
    {

        int _LDLAppID = -1;

        clsLocalDrivingLicenseApplication _LDLApp = new clsLocalDrivingLicenseApplication();

        int _ApplicationID = -1;
        clsApplication _Application = new clsApplication();

        public frmShowLocalDrivingLicenseApplicationInfo(int LDLAppID)
        {
            InitializeComponent();

            _LDLAppID = LDLAppID;
            _LDLApp = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LDLAppID);

            _ApplicationID = _LDLApp.ApplicationID;
            _Application = clsApplication.FindBaseApplication(_ApplicationID);


        }

        public frmShowLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void frmShowLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {



            ctrlLocalDrivingLicenseAppInfo1.LoadAllData(_LDLAppID);

        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Not implement yet
        }

        private void llblShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            int PersonID = _Application.PersonInfo.ID;

            frmShowPersonDetails frm = new frmShowPersonDetails(PersonID);
            frm.ShowDialog();

        }
    }
}
