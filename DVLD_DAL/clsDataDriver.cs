using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataDriver
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static bool GetDriverByID(int ID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {

            bool IsFound = false;

            string query = @"SELECT * FROM Drivers WHERE ID = @ID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                }
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }

        public static bool GetDriverByPersonID(int PersonID, ref int ID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {

            bool IsFound = false;

            string query = @"SELECT * FROM Drivers WHERE PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
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

        public static DataTable GetAllDrivers()
        {

            DataTable dtDrivers = new DataTable();

            string query = @"SELECT 
                                Drivers.ID, 
                                Drivers.PersonID, 
                                People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS FullName, 
                                People.NationalNo, 
                                Drivers.CreatedDate, 
	                            (SELECT COUNT(Licenses.ID) AS NumberOfActiveLicenses FROM Licenses WHERE (IsActive = 1) AND (DriverID = dbo.Drivers.ID)) AS NumberOfActiveLicenses
                            FROM Drivers 
                            INNER JOIN People ON Drivers.PersonID = People.ID;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dtDrivers.Load(reader);
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return dtDrivers;

        }

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int NewDriverID = -1;

            string query = @"INSERT INTO Drivers(PersonID,CreatedByUserID,CreatedDate)
                             VALUES(@PersonID,@CreatedByUserID,@CreatedDate);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    NewDriverID = insertedID;

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return NewDriverID;

        }

        public static bool UpdateDriver(int ID ,int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int rowsAffected = 0;

            string query = @"UPDATE  Drivers  
                            SET PersonID = @PersonID,
                                CreatedByUserID = @CreatedByUserID,
                                CreatedDate = @CreatedDate
                                WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);

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



    }
}
