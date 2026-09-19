using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataLicense
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        SqlConnection connection = new SqlConnection(ConnectionString);






    }
}
