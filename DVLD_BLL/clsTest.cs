using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsTest
    {

        public enum enMode { AddNew,Update};
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public int TestAppointmentID { set; get; }
        public clsTestAppointment TestAppointmentInfo { get; set; }
        public bool TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }

        public clsTest()
        {
            this.ID = -1;
            this.TestAppointmentID = -1;
            this.TestAppointmentInfo = null;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;

            this.Mode = enMode.AddNew;
        }

        public clsTest(int ID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {

            this.ID = ID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestAppointmentInfo = clsTestAppointment.Find(TestAppointmentID);

            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            this.Mode = enMode.Update;

        }

        public static DataTable GetAllTests() 
            => clsDataTest.GetAllTests();

        //public bool _AddNewTest()
        //    => clsDataTest.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID) != -1;

        private bool _AddNewTest()
        {
            this.ID = clsDataTest.AddNewTest(
                this.TestAppointmentID,
                this.TestResult,
                this.Notes,
                this.CreatedByUserID
            );

            return (this.ID != -1);
        }

        public bool _UpdateTest()
            => clsDataTest.UpdateTest(this.ID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

        public static clsTest Find(int ID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

            if (clsDataTest.GetTestInfoByID(ID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new clsTest(ID,TestAppointmentID, TestResult,Notes, CreatedByUserID);
            else
                return null;

        }

        public static clsTest FindLastTestPerPersonAndLicenseClass
            (int PersonID, int LicenseClassID, clsTestType.enTestType TestTypeID)
        {
            int ID = -1;
            int TestAppointmentID = -1;
            bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

            if (clsDataTest.GetLastTestByPersonAndTestTypeAndLicenseClass(PersonID, LicenseClassID, (int)TestTypeID, ref ID,ref TestAppointmentID, ref TestResult,ref Notes, ref CreatedByUserID))
                return new clsTest(ID,TestAppointmentID, TestResult,Notes, CreatedByUserID);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    return _UpdateTest();

            }

            return false;
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
            => clsDataTest.GetPassedTestCount(LocalDrivingLicenseApplicationID);

        public static bool IsPassedAllTests(int LocalDrivingLicenseApplicationID)
            => GetPassedTestCount(LocalDrivingLicenseApplicationID) == 3;

    }
}
