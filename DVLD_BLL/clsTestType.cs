using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_BLL
{
    public class clsTestType
    { 
        
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        // Properties
        public clsTestType.enTestType ID { set; get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }


        // Constructors
        public clsTestType()
        {
            this.ID = enTestType.VisionTest;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;
            
        }

        public clsTestType(enTestType ID, string Title, string Description, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
        }

        public clsTestType(string Title, string Description, decimal Fees)
        {
            this.Title = Title;
            this.Description = Title;
            this.Fees = Fees;
        }

        // Functions

        public static DataTable GetAllTestTypes()
            => clsDataTestType.GetTestTypes();


        public static clsTestType GetTestTypeByID(int ID)
        {

            string title = "";
            string description = "";
            decimal fees = 0;

            if (clsDataTestType.GetTestTypeByID(ID, ref title, ref description, ref fees))
                return new clsTestType((enTestType)ID, title, description, fees);
            else return null;

        }


        public bool Save()
            => clsDataTestType.UpdateTestType((int)this.ID, this.Title, this.Description, this.Fees);










    }
}
