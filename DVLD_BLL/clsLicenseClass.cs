using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsLicenseClass
    {

        public enum enMode { AddNew,Update};
        public enMode Mode = enMode.AddNew;

        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }


        // Constructors
        public clsLicenseClass()
        {
            this.ID = -1;
            this.Name = "";
            this.Description = "";
            this.MinimumAllowedAge = 18;
            this.DefaultValidityLength = 10;
            this.ClassFees = 0;

            this.Mode = enMode.AddNew;
            
        }

        private clsLicenseClass(int ID, string Name, string Description, int MinimumAllowedAge, int DefaultValidityLength, decimal ClassFees)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            this.Mode = enMode.Update;
        }

        //private clsLicenseClass(string Name, string Description, int MinimumAllowedAge, int DefaultValidityLength, decimal ClassFees)
        //{
        //    this.Name = Name;
        //    this.Description = Description;
        //    this.MinimumAllowedAge = MinimumAllowedAge;
        //    this.DefaultValidityLength = DefaultValidityLength;
        //    this.ClassFees = ClassFees;
        //}

        // Functions

        public static DataTable GetAllClassLisences()
            => clsDataLicenseClass.GetAllLisenceClasses();

        public static clsLicenseClass FindByLicenseCLassID(int LC_ID)
        {

            clsLicenseClass LC = new clsLicenseClass();

            string Name = "";
            string Description = "";
            int MinimumAllowedAge = 0;
            int DefaultValidityLength = 0;
            decimal ClassFees = 0;

            bool IsFound = clsDataLicenseClass.FindByLicenseCLassID(LC_ID, ref Name, ref Description, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            if (IsFound)
                return new clsLicenseClass(LC_ID, Name, Description, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else return null;

        }

        public static clsLicenseClass FindByLicenseClassName(string ClassName)
        {

            clsLicenseClass LC = new clsLicenseClass();

            int LC_ID = -1;
            string Description = "";
            int MinimumAllowedAge = 0;
            int DefaultValidityLength = 0;
            decimal ClassFees = 0;

            bool IsFound = clsDataLicenseClass.FindByLicenseCLassName(ref LC_ID, ClassName, ref Description, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

            if (IsFound)
                return new clsLicenseClass(LC_ID, ClassName, Description, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else return null;

        }







    }
}
