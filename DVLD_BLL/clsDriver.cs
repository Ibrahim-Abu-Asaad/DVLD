using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsDriver
    {

        public enum enMode {AddNew, Update};
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public int PersonID { set; get; }
        public clsPerson PersonInfo;

        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUserInfo;

        public DateTime CreatedDate { get; }

        public clsDriver()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.PersonInfo = null;
            this.CreatedByUserID = -1;
            this.CreatedByUserInfo = null;
            this.CreatedDate = DateTime.Now;

            this.Mode = enMode.AddNew;
        }

        public clsDriver(int ID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            this.ID = ID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.GetUserByID(CreatedByUserID);
            this.CreatedDate = CreatedDate;

            this.Mode = enMode.Update;

        }

        public static clsDriver GetDriverByID(int ID)
        {

            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = new DateTime();

            if (clsDataDriver.GetDriverByID(ID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(ID, PersonID, CreatedByUserID, CreatedDate);
            else return new clsDriver();


        }

        public static clsDriver GetDriverByPersonID(int PersonID)
        {

            int ID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = new DateTime();

            if (clsDataDriver.GetDriverByPersonID(PersonID, ref ID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(ID, PersonID, CreatedByUserID, CreatedDate);
            else return new clsDriver();


        }

        public static DataTable GetAllDrivers()
            => clsDataDriver.GetAllDrivers();

        private bool _AddNew()
        {

            this.ID = clsDataDriver.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return this.ID != -1;

        }

        private bool _Update()
            => clsDataDriver.UpdateDriver(this.ID, this.PersonID, this.CreatedByUserID, this.CreatedDate);

        public bool Save()
        {

            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;


                case enMode.Update:
                    return _Update();

            }

            return false;

        }


    }
}
