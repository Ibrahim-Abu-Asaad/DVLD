using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Global_Classes
{
    internal class clsFormat
    {

        public static string DateToShort(DateTime Dt1)
        {

            return Dt1.ToString("dd/MMM/yyyy");
        }

        public static string FullNameOf2Names(string s1, string s2)
            => s1 + ' ' + s2;

        public static string FullNameOf3Names(string s1, string s2, string s3)
            => s1 + ' ' + s2 + ' ' + s3;

        public static string FullNameOf4Names(string s1, string s2, string s3, string s4)
            => s1 + ' ' + s2 + ' ' + s3 + ' ' + s4;




    }
}
