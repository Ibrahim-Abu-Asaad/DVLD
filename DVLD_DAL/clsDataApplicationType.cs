using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataApplicationType
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static DataTable GetApplicationTypes()
        {

            DataTable dtPeople = new DataTable();

            //string query = "SELECT ApplicationTypeTitle, ApplicationFees FROM ApplicationTypes;";
            string query = "SELECT * FROM ApplicationTypes;";
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

        public static bool GetApplicationTypeByID(int ID, ref string Title, ref decimal Fees)
        {
            bool isFound = false;

            string query = "SELECT * FROM ApplicationTypes WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Title = (string)reader["ApplicationTypeTitle"];
                    Fees = (decimal)reader["ApplicationFees"];
                }
                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool UpdateApplicationType(int ID, string title, decimal fees)
        {
            int rowsAffected = 0;

            string query = @"UPDATE ApplicationTypes 
                            SET ApplicationTypeTitle = @Title, 
                                ApplicationFees = @Fees 
                            WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Fees", fees);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }





    }
}
