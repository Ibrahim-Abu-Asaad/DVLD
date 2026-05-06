using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsUser
    {

        // Properties
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;

        // Enum Mode
        public enum enMode
        {
            AddNew,
            Update
        }
        public enMode Mode = enMode.AddNew;


        // Constructors
        public clsUser()
        {

            ID = -1;
            PersonID = -1;
            PersonInfo = new clsPerson();
            Username = "";
            Password = "";
            IsActive = false;
            
        }

        public clsUser(int ID, int PersonID, string Username, string Password, bool IsActive)
        {
            this.ID = ID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
        }

        private clsUser(int PersonID, string Username, string Password, bool IsActive)
        {
            this.ID = -1;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonID = PersonID;
        }

        // Functions Perosn

        public static clsUser GetUserByID(int ID)
        {

            int PersonID = -1;
            string Username = "";
            string Password = "";
            bool IsActive = false;

            bool IsUserFound = clsDataUser.GetUserInfoByID(ID, ref PersonID, ref Username, ref Password, ref IsActive);

            if (IsUserFound)
                return new clsUser(ID, PersonID, Username, Password, IsActive);
            else return new clsUser();

        }

        public static clsUser GetUserByPersonID(int PersonID)
        {

            int ID = -1;
            string Username = "";
            string Password = "";
            bool IsActive = false;

            bool IsUserFound = clsDataUser.GetUserInfoByPersonID(ref ID, PersonID, ref Username, ref Password, ref IsActive);

            if (IsUserFound)
                return new clsUser(ID, PersonID, Username, Password, IsActive);
            else return new clsUser();

        }

        public static clsUser GetUserByUsername(string Username)
        {

            int ID = -1;
            int PersonID = -1;
            string Password = "";
            bool IsActive = false;

            bool IsUserFound = clsDataUser.GetUserInfoByUsername(ref ID, ref PersonID, Username, ref Password, ref IsActive);

            if (IsUserFound)
                return new clsUser(ID, PersonID, Username, Password, IsActive);
            else return new clsUser();

        }

        public static bool IsUserExistByID(int ID)
            => clsDataUser.IsUserExistByID(ID);

        public static bool IsUserExistByPersonID(int PersonID)
            => clsDataUser.IsUserExistByPersonID(PersonID);

        public static bool IsUserExistByUsername(string Username)
            => clsDataUser.IsUserExistByUsername(Username);

        private bool _AddNewUser()
        {

            this.ID = clsDataUser.AddNewUser(this.PersonID, this.Username, this.Password, this.IsActive);

            return this.ID != -1;

        }

        private bool _UpdateUser()
            => clsDataUser.UpdateUser(this.ID, this.PersonID, this.Username, this.Password, this.IsActive);


        public bool Save()
        {

            switch (Mode)
            {


                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    _UpdateUser();
                    break;


            }

            return false;

        }

        public static DataTable GetAllUsers()
            => clsDataUser.GetAllUsers();

        public static int NumberOfTotalUsersAndAdmins()
            => clsDataUser.NumberOfTotalUsersAndAdmins();


        //public static int NumberOfTotalUsersOnly()
        //    => clsDataUser.NumberOfTotalUsersOnly();



    }
}
