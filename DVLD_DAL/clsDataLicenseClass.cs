using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataLicenseClass
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static DataTable GetAllLisenceClasses()
        {

            DataTable dtPeople = new DataTable();

            string query = "SELECT * FROM LicenseClasses;";
            SqlCommand command = new SqlCommand(query, connection);


            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dtPeople.Load(reader);

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return dtPeople;


        }

        public static bool FindByLicenseCLassID(int LC_ID, ref string ClassName, ref string ClassDescription, ref int MinimumAllowedAge, ref int DefaultValidityLength, ref decimal ClassFees)
        {

            bool IsFound = false;

            string query = "SELECT * FROM LicenseClasses WHERE ID = @LC_ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LC_ID", LC_ID);


            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IsFound = !IsFound;
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (int)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (int)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }










    }
}
