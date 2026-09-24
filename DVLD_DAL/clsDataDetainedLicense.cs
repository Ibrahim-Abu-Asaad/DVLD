using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataDetainedLicense
    {

        static readonly string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection();

        public static bool GetDetainedLicenseInfoByID(int ID, ref int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {

            bool IsFound = false;

            string query = @"SELECT * FROM DetainedLicenses WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IsFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (float)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] == DBNull.Value)
                        ReleaseDate = DateTime.MaxValue;
                    else ReleaseDate = (DateTime)reader["ReleaseDate"];

                    if (reader["ReleasedByUserID"] == DBNull.Value)
                        ReleasedByUserID = -1;
                    else ReleasedByUserID = (int)reader["ReleasedByUserID"];

                    if (reader["ReleaseApplicationID"] == DBNull.Value)
                        ReleaseApplicationID = -1;
                    else ReleaseApplicationID = (int)reader["ReleaseApplicationID"];


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

        public static bool GetDetainedLicenseInfoByLicenseID(ref int ID, int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {

            bool IsFound = false;

            string query = @"SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IsFound = true;

                    ID = (int)reader["ID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (float)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] == DBNull.Value)
                        ReleaseDate = DateTime.MaxValue;
                    else ReleaseDate = (DateTime)reader["ReleaseDate"];

                    if (reader["ReleasedByUserID"] == DBNull.Value)
                        ReleasedByUserID = -1;
                    else ReleasedByUserID = (int)reader["ReleasedByUserID"];

                    if (reader["ReleaseApplicationID"] == DBNull.Value)
                        ReleaseApplicationID = -1;
                    else ReleaseApplicationID = (int)reader["ReleaseApplicationID"];


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

        public static DataTable GetAllDetainedLicenses()
        {

            DataTable dtDetainedLicenses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT dbo.DetainedLicenses.ID, dbo.DetainedLicenses.LicenseID, dbo.DetainedLicenses.DetainDate, dbo.DetainedLicenses.IsReleased, dbo.DetainedLicenses.FineFees, dbo.DetainedLicenses.ReleaseDate, dbo.People.NationalNo, 
                             dbo.People.FirstName + ' ' + dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, ' ') + ' ' + dbo.People.LastName AS FullName, dbo.DetainedLicenses.ReleaseApplicationID
                             FROM dbo.People INNER JOIN
                             dbo.Drivers ON dbo.People.ID = dbo.Drivers.PersonID INNER JOIN
                             dbo.Licenses ON dbo.Drivers.ID = dbo.Licenses.DriverID RIGHT OUTER JOIN
                             dbo.DetainedLicenses ON dbo.Licenses.ID = dbo.DetainedLicenses.LicenseID ORDER BY IsReleased ,ID;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dtDetainedLicenses.Load(reader);

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

            return dtDetainedLicenses;

        }

        public static int AddNewDetainedLicense(
            int LicenseID, DateTime DetainDate,
            float FineFees, int CreatedByUserID)
        {
            int DetainID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO dbo.DetainedLicenses
                               (LicenseID,
                               DetainDate,
                               FineFees,
                               CreatedByUserID,
                               IsReleased
                               )
                            VALUES
                               (@LicenseID,
                               @DetainDate, 
                               @FineFees, 
                               @CreatedByUserID,
                               0
                             );
                            
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    DetainID = insertedID;
            }

            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }


            return DetainID;

        }

        public static bool UpdateDetainedLicense(int ID,
            int LicenseID, DateTime DetainDate,
            float FineFees, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE dbo.DetainedLicenses
                              SET LicenseID = @LicenseID, 
                              DetainDate = @DetainDate, 
                              FineFees = @FineFees,
                              CreatedByUserID = @CreatedByUserID,   
                              WHERE ID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


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

        public static bool ReleaseDetainedLicense(int ID,
                 int ReleasedByUserID, int ReleaseApplicationID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE dbo.DetainedLicenses
                              SET IsReleased = 1, 
                              ReleaseDate = @ReleaseDate, 
                              ReleaseApplicationID = @ReleaseApplicationID   
                              WHERE ID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select IsDetained=1 
                            from detainedLicenses 
                            where 
                            LicenseID=@LicenseID 
                            and IsReleased=0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    IsDetained = Convert.ToBoolean(result);
            }

            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }


            return IsDetained;

        }



    }
}
