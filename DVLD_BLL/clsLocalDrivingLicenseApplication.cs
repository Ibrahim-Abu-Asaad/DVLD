using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {

        public enum enMode
        {
            AddNew = 0, Update = 1
        }
        public enMode Mode = enMode.AddNew;


        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        // clsLicens...

        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;

            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime Date, int AppTypeID,
            enApplicationStatus AppStatus, DateTime LastStatusDate,
            float PaidFees, int CreatedByUserID, int LicenseClassID)
        {

            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.Date = Date;
            this.AppTypeID = AppTypeID;
            this.AppStatus = AppStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.GetUserByID(CreatedByUserID);

            this.LicenseClassID = LicenseClassID;

        }

        private bool _AddNewLocalDrivingLicenseApplication()
            => clsDataLocalDrivingLicenseApplication.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID) != -1;


        private bool _UpdateLocalDrivingLicenseApplication()
            => clsDataLocalDrivingLicenseApplication.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);

        public static clsLocalDrivingLicenseApplication FindLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID)
        {

            int applicationID = -1;
            int licenseClassID = -1;

            bool IsFound = false;

            if (clsDataLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID, ref applicationID, ref licenseClassID))
                IsFound = true;

            if (IsFound)
            {

                clsApplication App = clsApplication.FindBaseApplication(applicationID);

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, App.ApplicationID, App.ApplicantPersonID, App.Date, App.AppTypeID, App.AppStatus, App.LastStatusDate, App.PaidFees, App.CreatedByUserID, licenseClassID);

            }
            else return null;

        }

        public static clsLocalDrivingLicenseApplication FindLocalDrivingLicenseApplicationByApplicationID(int ApplicationID)
        {

            int LocalDrivingLicenseApplicationID = -1;
            int LicenseClassID = -1;

            bool IsFound = false;

            if (clsDataLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByApplicationID(ref LocalDrivingLicenseApplicationID, ApplicationID, ref LicenseClassID))
                IsFound = true;

            if (IsFound)
            {

                clsApplication App = clsApplication.FindBaseApplication(ApplicationID);

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, App.ApplicationID, App.ApplicantPersonID, App.Date, App.AppTypeID, App.AppStatus, App.LastStatusDate, App.PaidFees, App.CreatedByUserID, LicenseClassID);

            }
            else return null;

        }

        public bool Save()
        {

            base.Mode = (clsApplication.enMode)Mode;

            if (!base.Save())
                return false;

            switch (Mode)
            {

                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();

            }

            return false;








        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
            => clsDataLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

        public bool Delete()
        {

            bool IsLocalDrivingLicenseApplicationDeleted = false;
            bool IsAppDeleted = false;

            IsLocalDrivingLicenseApplicationDeleted = clsDataLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);

            if (IsLocalDrivingLicenseApplicationDeleted)
                IsAppDeleted = base.Delete();

            return IsAppDeleted;

        }

        public bool DoesPassTestType(clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);

        public bool DoesPassPreviousTest(clsTestType.enTestType CurrentTestType)
        {

            switch (CurrentTestType)
            {

                case clsTestType.enTestType.VisionTest:
                    return this.DoesPassTestType(clsTestType.enTestType.VisionTest);

                case clsTestType.enTestType.WrittenTest:
                    return this.DoesPassTestType(clsTestType.enTestType.WrittenTest);

                case clsTestType.enTestType.StreetTest:
                    return this.DoesPassTestType(clsTestType.enTestType.StreetTest);

                default:
                    return false;




            }



        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.DoesPassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);

        public bool DoesAttendTestType(clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);

        public bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.DoesAttendTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);

        public byte TotalTrialPerTest(clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);

        public byte TotalTrialPerTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);

        public static bool AttendedTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;

        public bool AttendedTest(clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);

        public bool IsThereAnActiveScheduledTest(clsTestType.enTestType TestTypeID)
            => clsDataLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);











    }
}
