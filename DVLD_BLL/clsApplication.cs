using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsApplication
    {

        public int ID { get; set; }
        public int ApplicantPersonID { get; set; }
        //public string ApplicantFullName
        //{
        //    get { return clsPerson.Find(ApplicantPersonID).FirstName; }
        //}
        public DateTime Date { get; set; }
        public int AppTypeID { get; set; }
        public clsApplicationType ApplicationTypeInfo;
        public enApplicationStatus AppStatus { get; set; }
        public string AppStatusText
        {
            get
            {
                switch (AppStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Uknown";
                }
            }
        }
        public DateTime LastStatusDate { get; set; }

        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;

        public clsPerson PersonInfo
        {
            get
            {
                return clsPerson.Find(ApplicantPersonID);
            }
        }

        public enum enMode { AddNew, Update }
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2,
            ReplaceLostDrivingLicense = 3, ReplaceDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5, NewInternationalDrivingLicense = 6, RetakeTest = 7
        };
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };
        public enMode Mode = enMode.AddNew;

        private clsApplication(int ID, int ApplicantPersonID,
            DateTime Date, int AppTypeID,
            enApplicationStatus AppStatus, DateTime LastStatusDate,
            float PaidFees, int CreatedByUserID)
        {
            this.ID = ID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.Date = Date;
            this.AppTypeID = AppTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find(AppTypeID);
            this.AppStatus = AppStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.GetUserByID(CreatedByUserID);

            this.Mode = enMode.Update;
        }

        public clsApplication()
        {
            this.ID = -1;
            this.ApplicantPersonID = -1;
            this.Date = DateTime.Now;
            this.AppTypeID = -1;
            this.AppStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;

            this.Mode = enMode.AddNew;
        }

        private bool _AddNewApplication()
        {


            this.ID = clsDataApplication.AddNewApplication(
                this.ApplicantPersonID, this.Date,
                this.AppTypeID, (byte)this.AppStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ID != -1);
        }

        private bool _UpdateApplication()
        {


            return clsDataApplication.UpdateApplication(this.ID, this.ApplicantPersonID, this.Date,
                this.AppTypeID, (byte)this.AppStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

        }

        public static clsApplication FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now; int ApplicationTypeID = -1;
            byte ApplicationStatus = 1; DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0; int CreatedByUserID = -1;

            bool IsFound = clsDataApplication.GetApplicationInfoByID
                                (
                                    ApplicationID, ref ApplicantPersonID,
                                    ref ApplicationDate, ref ApplicationTypeID,
                                    ref ApplicationStatus, ref LastStatusDate,
                                    ref PaidFees, ref CreatedByUserID
                                );

            if (IsFound)

                return new clsApplication(ApplicationID, ApplicantPersonID,
                                     ApplicationDate, ApplicationTypeID,
                                    (enApplicationStatus)ApplicationStatus, LastStatusDate,
                                     PaidFees, CreatedByUserID);
            else
                return null;
        }

        public bool Cancel()
            => clsDataApplication.UpdateStatus(ID, 2);

        public bool SetComplete()
            => clsDataApplication.UpdateStatus(ID, 3);

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();

            }

            return false;
        }

        public bool Delete()
            => clsDataApplication.DeleteApplication(this.ID);

        public static bool IsApplicationExist(int ApplicationID)
            => clsDataApplication.IsApplicationExist(ApplicationID);

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
            => clsDataApplication.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);

        public bool DoesPersonHaveActiveApplication(int ApplicationTypeID)
            => DoesPersonHaveActiveApplication(this.ApplicantPersonID, ApplicationTypeID);

        public static int GetActiveApplicationID(int PersonID, clsApplication.enApplicationType ApplicationTypeID)
            => clsDataApplication.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplication.enApplicationType ApplicationTypeID, int LicenseClassID)
            => clsDataApplication.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);

        public int GetActiveApplicationID(clsApplication.enApplicationType ApplicationTypeID)
            => GetActiveApplicationID(this.ApplicantPersonID, ApplicationTypeID);












    }
}
