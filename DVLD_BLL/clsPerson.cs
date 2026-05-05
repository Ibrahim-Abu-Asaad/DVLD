using DVLD_DAL;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsPerson
    {

        // Properties
        public int ID { get; private set; }
        public string NationalNO { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public clsCountry CountryInfo { get; set; }
        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        // ENUM for handle the mode(AddNew, Update)
        public enum enMode
        {
            AddNew,
            Update
        }
        public enMode Mode = enMode.AddNew;





        // Constructors
        public clsPerson()
        {

            this.ID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        private clsPerson(string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            this.ID = -1;
            this.NationalNO = NationalNO;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            this.ImagePath = ImagePath;

            Mode = enMode.Update;

        }

        public clsPerson(int ID, string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, int NationalityCountryID , string ImagePath)
                        : this(NationalNO, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath)
                        => this.ID = ID;


        // Functions
        public static DataTable GetPeople()
            => clsDataPerson.GetPeople();

        public static DataTable GetPeopleAndHideSomeColumns()
            => clsDataPerson.GetPeopleAndHideSomeColumns();


        public static bool GetPersonInfoByID(int ID, ref string NationalNO, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
            => clsDataPerson.GetPersonInfoByID(ID, ref NationalNO, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);


        private bool _AddNewPerson()
        {

            this.ID = clsDataPerson.AddNewPerson(this.NationalNO, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return this.ID != -1;

        }

        private bool _UpdatePerson()
            => clsDataPerson.UpdatePerson(this.ID, this.NationalNO, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

        public static clsPerson Find(int ID)
        {

            string NationalNO = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsDataPerson.GetPersonInfoByID(ID, ref NationalNO, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(ID, NationalNO, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else return null;
                    


        }

        public static clsPerson Find(string NationalNO)
        {

            int ID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsDataPerson.GetPersonInfoByNationalNO(ref ID, NationalNO, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new clsPerson(ID, NationalNO, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else return null;



        }



        public bool Save()
        {

            switch (Mode)
            {

                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:
                    return _UpdatePerson();

            }

            return false;

        }

        public static bool DeletePerson(int ID)
            => clsDataPerson.DeletePerson(ID);
        public static bool IsPersonExist(int ID)
            => clsDataPerson.IsPersonExist(ID);
        public static bool IsPersonExist(string NationalNO)
            => clsDataPerson.IsPersonExist(NationalNO);

        public static bool IsPhoneExist(string Phone)
            => clsDataPerson.IsPhoneExist(Phone);


        public static bool IsPhoneExist(string Phone, int ExcludePersonID)
            => clsDataPerson.IsPhoneExist(Phone, ExcludePersonID);

        public static bool IsEmailExist(string Email)
            => clsDataPerson.IsEmailExist(Email);

        public static bool IsEmailExist(string Email, int ExcludePersonID)
            => clsDataPerson.IsEmailExist(Email, ExcludePersonID);




    }
}
