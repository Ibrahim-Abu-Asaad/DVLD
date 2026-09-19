using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsLicense
    {

        public enum enMode { AddNew,Update };
        public enMode Mode = enMode.AddNew;

        public enum enIssueReason { FirstTime, Renew, DamagedReplacement, LostReplacement};

        public int ID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public clsDriver DriverInfo;

        public int LicenseClass { set; get; }
        public clsLicenseClass LicenseClassInfo;
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public float PaidFees { set; get; }
        public bool IsActive { set; get; }
        public enIssueReason IssueReason { set; get; }
        public int CreatedByUserID { set; get; }



    }
}
