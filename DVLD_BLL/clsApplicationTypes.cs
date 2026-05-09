using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsApplicationTypes
    {

        //public enum enMode { Update = 0 };
        //public enMode Mode = enMode.Update;

        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }


        private clsApplicationTypes(int ID, string Title, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
            //Mode = enMode.Update;
        }


        public clsApplicationTypes()
        {
            this.ID = -1;
            this.Title = "";
            this.Fees = 0;
            //Mode = enMode.Update;
        }


        public static clsApplicationTypes Find(int ID)
        {
            
            string Title = "";
            decimal Fees = 0;

            if (clsDataApplicationTypes.GetApplicationTypeByID(ID, ref Title, ref Fees))
                return new clsApplicationTypes(ID, Title, Fees);
            else
                return null;


        }


        private bool _UpdateApplicationType()
            => clsDataApplicationTypes.UpdateApplicationType(this.ID, this.Title, this.Fees);


        public bool Save()
            => _UpdateApplicationType();


        public static DataTable GetApplicationTypes()
            => clsDataApplicationTypes.GetApplicationTypes();






    }
}
