using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataCountry
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static DataTable GetAllCountries()
        {

            DataTable dtPeople = new DataTable();

            string query = "SELECT * FROM Countries ORDER BY CountryName ASC;";
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

        public static bool GetCountryByID(int ID, ref string CountryName)
        {

            bool isFound = false;

            string query = "SELECT CountryName FROM Countries WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryName = (string)reader["CountryName"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool GetCountryByName(string CountryName, ref int ID)
        {

            bool isFound = false;

            string query = "SELECT ID FROM Countries WHERE CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["ID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }




    }
}
