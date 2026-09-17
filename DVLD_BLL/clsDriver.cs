using System;
using System.Collections.Generic;
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









    }
}
