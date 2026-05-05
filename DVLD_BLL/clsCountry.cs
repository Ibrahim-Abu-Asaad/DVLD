using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsCountry
    {

        public int ID { get; set; }
        public string CountryName { get; set; }


        // Constructors
        private clsCountry()
        {
            this.ID = -1;
            this.CountryName = "";
        }
        public clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }



        // Functions
        public static DataTable GetAllCountries()
            => clsDataCountry.GetAllCountries();


        public static clsCountry Find(int ID)
        {
            string CountryName = "";

            if (clsDataCountry.GetCountryByID(ID, ref CountryName))
                return new clsCountry(ID, CountryName);
            else
                return null;
        }
        public static clsCountry Find(string CountryName)
        {
            int ID = -1;

            if (clsDataCountry.GetCountryByName(CountryName, ref ID))
                return new clsCountry(ID, CountryName);
            else
                return null;
        }





    }
}
