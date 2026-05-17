using DVLD.Global_Classes;
using DVLD.Helpers;
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

namespace DVLD.Applications
{
    public partial class frmAddEditLocalDrivingLicenseApplication : UIForm
    {

        int _LocalDrivingLicenseApplicationID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
        clsLocalDrivingLicenseApplication.enMode Mode = clsLocalDrivingLicenseApplication.enMode.AddNew;

        public frmAddEditLocalDrivingLicenseApplication()
        {
            InitializeComponent();

            Mode = clsLocalDrivingLicenseApplication.enMode.AddNew;
        }

        public frmAddEditLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID);
            Mode = clsLocalDrivingLicenseApplication.enMode.Update;

        }

        private void tbApplicationInfo_Click(object sender, EventArgs e)
        {
            if (!_IsPersonExist())
            {
                tabControl1.SelectedTab = tbPersonalInfo;
                MessageBox.Show("Choose Person First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabControl1.SelectedTab = tbApplicationInfo;
            btnSave.Enabled = true;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _ValidateNavigation();
            
        }

        private bool _IsPersonExist()
            => ctrlShowPersonDetailsWithFilter1.PersonID != -1;

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tbApplicationInfo)
                _ValidateNavigation();


        }

        private void _ValidateNavigation()
        {

            if (!_IsPersonExist())
            {
                tabControl1.SelectedTab = tbPersonalInfo;
                MessageBox.Show("Choose Person First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabControl1.SelectedTab = tbApplicationInfo;
            btnSave.Enabled = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPersonalInfo;
        }

        private void _ResetDefaultValues()
        {

            _FillComboBoxWithData();

            _FillDataInForm();

        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

            _ResetDefaultValues();


            if (Mode == clsLocalDrivingLicenseApplication.enMode.Update)
                _UpdateModeState();
            else _AddNewModeState();



        }

        private void _AddNewModeState()
        {

            lblTitle.Text = "New Local Driving License Application";
            this.Text = "New Local Driving License Application";
            _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            ctrlShowPersonDetailsWithFilter1.FilterFocus();
            btnSave.Enabled = false;



        }

        private void _UpdateModeState()
        {

            ctrlShowPersonDetailsWithFilter1.FilterEnabled = false;
            ctrlShowPersonDetailsWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            cbLisenceClass.SelectedValue = _LocalDrivingLicenseApplication.LicenseClassID;

            lblTitle.Text = "Update Local Driving License Application";
            this.Text = "Update Local Driving License Application";
            lblAppDate.Text = _LocalDrivingLicenseApplication.Date.ToShortDateString();

            lblCreatedBy.Text = _LocalDrivingLicenseApplication.CreatedByUserInfo.Username;
            string Name = _LocalDrivingLicenseApplication.CreatedByUserInfo.PersonInfo.FirstName + " " + _LocalDrivingLicenseApplication.CreatedByUserInfo.PersonInfo.LastName;
            lblFullName.Text = Name;

            //MessageBox.Show(_LocalDrivingLicenseApplication.CreatedByUserID.ToString());
            //MessageBox.Show(_LocalDrivingLicenseApplication.CreatedByUserInfo.PersonInfo.FirstName);

            ctrlShowPersonDetailsWithFilter1.FilterEnabled = false;
            btnSave.Enabled = true;
        }

        private void _FillDataInForm()
        {

            clsApplicationType NewLocalApplicationType = new clsApplicationType();
            NewLocalApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationType.NewDrivingLicense);

            lblAppFees.Text = NewLocalApplicationType.Fees.ToString();

            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;

            string Name = clsGlobal.CurrentUser.PersonInfo.FirstName + " " + clsGlobal.CurrentUser.PersonInfo.LastName;
            lblFullName.Text = Name;


        }

        private void _FillComboBoxWithData()
        {

            cbLisenceClass.DataSource = clsLicenseClass.GetAllClassLisences();

            cbLisenceClass.DisplayMember = "ClassName";

            cbLisenceClass.ValueMember = "ID";

            cbLisenceClass.SelectedValue = 3;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlShowPersonDetailsWithFilter1.FilterFocus();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_Validation())
                return;

            int LicenseClassID = (int)cbLisenceClass.SelectedValue;

            _LocalDrivingLicenseApplication.ApplicantPersonID = ctrlShowPersonDetailsWithFilter1.PersonID; ;
            _LocalDrivingLicenseApplication.Date = DateTime.Now;
            _LocalDrivingLicenseApplication.AppTypeID = 1;
            _LocalDrivingLicenseApplication.AppStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToSingle(lblAppFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.ID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;

            _LocalDrivingLicenseApplication.Mode = Mode;
            if (_LocalDrivingLicenseApplication.Save())
            {
                Mode = clsLocalDrivingLicenseApplication.enMode.Update;
                lblTitle.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshApplicationInfoPage();

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            



        }

        private void _RefreshApplicationInfoPage()
        {

            clsApplicationType NewLocalApplicationType = new clsApplicationType();
            NewLocalApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationType.NewDrivingLicense);

            lblAppFees.Text = NewLocalApplicationType.Fees.ToString();

            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;

            string Name = clsGlobal.CurrentUser.PersonInfo.FirstName + " " + clsGlobal.CurrentUser.PersonInfo.LastName;
            lblFullName.Text = Name;
        }

        private bool _Validation()
        {

            if (ctrlShowPersonDetailsWithFilter1.PersonID == -1)
            {
                MessageBox.Show("Choose Person First");
                return false;
            }

            //ctrlShowPersonDetailsWithFilter1.LoadPersonInfo();

            DateTime DateOfBirth = ctrlShowPersonDetailsWithFilter1.SelectedPersonInfo.DateOfBirth;

            if (!IsValidAge(DateOfBirth))
            {
                int Years = CalculateAge(DateOfBirth).Years;
                int Months = CalculateAge(DateOfBirth).Months;
                int Days = CalculateAge(DateOfBirth).Days;
                MessageBox.Show("(Age Not Valid)\n" + $"Age: {Years} years, {Months} months, {Days} days", "Illegal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            int LicenseClassID = (int)cbLisenceClass.SelectedValue;

            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(ctrlShowPersonDetailsWithFilter1.PersonID, clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("This person has already an active application for this license!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                
            //               I M P O R A N T
            // IMPORTANT TO DO
            // if person already has a license then prevent him to apply to same license type;
            // if() // We will do it later
            //
            //
            //
            //
            //
            //
            //


            return true;

        }

        public bool IsValidAge(DateTime dateOfBirth)
        {

            DateTime today = DateTime.Today;

            int years = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-years))
                years--;

            if (years >= 21)
                return true;

            if (years >= 18 && years <= 20)
            {
                int licenseID = (int)cbLisenceClass.SelectedValue;
                return licenseID == 1 || licenseID == 3;
            }

            return false;

        }

        public (int Years, int Months, int Days) CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;

            int years = today.Year - dateOfBirth.Year;

            int months = 0;
            int days = 0;

            if (dateOfBirth.Date > today.AddYears(-years))
            {
                years--;
            }

            DateTime lastBirthday = dateOfBirth.AddYears(years);
            months = (today.Year - lastBirthday.Year) * 12 + (today.Month - lastBirthday.Month);

            if (today.Day < lastBirthday.Day)
            {
                months--;
                days = DateTime.DaysInMonth(lastBirthday.Year, lastBirthday.Month) - lastBirthday.Day + today.Day;
            }
            else
            {
                days = today.Day - lastBirthday.Day;
            }

            if (days < 0)
            {
                months--;
                DateTime previousMonth = today.AddMonths(-1);
                days = (today - previousMonth).Days;
            }

            return (years, months, days);
        }








    }
}
