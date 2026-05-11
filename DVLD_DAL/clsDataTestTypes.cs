using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataTestTypes
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static DataTable GetTestTypes()
        {

            DataTable dtTestTypes = new DataTable();
            //string query = "SELECT Title, Description, Fees FROM TestTypes";
            string query = "SELECT ID, TestTypeTitle AS Title, TestTypeDescription AS Description, TestTypeFees AS Fees FROM TestTypes;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dtTestTypes.Load(reader);

            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }


            return dtTestTypes;

        }

        public static bool UpdateTestType(int ID, string Title, string Description, decimal Fees)
        {

            int rowsAffected = 0;

            string query = @"UPDATE TestTypes 
                             SET TestTypeTitle = @Title,
                                 TestTypeDescription = @Description,
                                 TestTypeFees = @Fees
                             WHERE ID = @ID;";
                              

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);

            try
            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }


            return rowsAffected > 0;

        }

        public static bool GetTestTypeByID(int ID, ref string Title, ref string Description, ref decimal Fees)
        {

            bool isFound = false;

            string query = "SELECT * FROM TestTypes WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Title = (string)reader["TestTypeTitle"];
                    Description = (string)reader["TestTypeDescription"];
                    Fees = (decimal)reader["TestTypeFees"];
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



    }
}
