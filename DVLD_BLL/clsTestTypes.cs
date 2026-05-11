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
    public class clsTestTypes
    {


        // Properties
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }


        // Constructors
        public clsTestTypes()
        {
            this.ID = -1;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;
            
        }

        public clsTestTypes(int ID, string Title, string Description, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
        }

        public clsTestTypes(string Title, string Description, decimal Fees)
        {
            this.Title = Title;
            this.Description = Title;
            this.Fees = Fees;
        }

        // Functions

        public static DataTable GetAllTestTypes()
            => clsDataTestTypes.GetTestTypes();


        public static clsTestTypes GetTestTypeByID(int ID)
        {

            string title = "";
            string description = "";
            decimal fees = 0;

            if (clsDataTestTypes.GetTestTypeByID(ID, ref title, ref description, ref fees))
                return new clsTestTypes(ID, title, description, fees);
            else return null;

        }


        public bool Save()
            => clsDataTestTypes.UpdateTestType(this.ID, this.Title, this.Description, this.Fees);










    }
}
