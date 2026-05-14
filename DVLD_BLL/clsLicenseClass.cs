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
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;
        }

        private clsLicenseClass(int ID, string Name, string Description, int MinimumAllowedAge, int DefaultValidityLength, decimal ClassFees)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        private clsLicenseClass(string Name, string Description, int MinimumAllowedAge, int DefaultValidityLength, decimal ClassFees)
        {
            this.Name = Name;
            this.Description = Description;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        // Functions

        public static DataTable GetAllClassLisences()
            => clsDataLicenseClass.GetAllLisenceClasses();








    }
}
