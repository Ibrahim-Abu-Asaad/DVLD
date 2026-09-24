using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataInternationalLicense
    {

        public static bool GetInternationalLicenseInfoByID(int ID,
            ref int ApplicationID,
            ref int DriverID, ref int IssuedUsingLocalLicenseID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM InternationalLicenses WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];


                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];


                }
                else
                {
                    isFound = false;
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

        public static DataTable GetAllInternationalLicenses()
        {

            DataTable dtInternationalLicenses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
            SELECT ID, ApplicationID,DriverID,
		                IssuedUsingLocalLicenseID , IssueDate, 
                        ExpirationDate, IsActive
		    from InternationalLicenses 
                order by IsActive, ExpirationDate DESC";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dtInternationalLicenses.Load(reader);

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

            return dtInternationalLicenses;

        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {

            DataTable dtDriverInternationalLicenses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
            SELECT ID, ApplicationID,
		                IssuedUsingLocalLicenseID , IssueDate, 
                        ExpirationDate, IsActive
		    FROM InternationalLicenses WHERE DriverID=@DriverID
                ORDER BY ExpirationDate DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dtDriverInternationalLicenses.Load(reader);

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

            return dtDriverInternationalLicenses;

        }

        public static int AddNewInternationalLicense(int ApplicationID,
             int DriverID, int IssuedUsingLocalLicenseID,
             DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {

            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                               UPDATE InternationalLicenses 
                               set IsActive=0
                               WHERE DriverID=@DriverID;

                             INSERT INTO InternationalLicenses
                               (
                                ApplicationID,
                                DriverID,
                                IssuedUsingLocalLicenseID,
                                IssueDate,
                                ExpirationDate,
                                IsActive,
                                CreatedByUserID)
                         VALUES
                               (@ApplicationID,
                                @DriverID,
                                @IssuedUsingLocalLicenseID,
                                @IssueDate,
                                @ExpirationDate,
                                @IsActive,
                                @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ID = insertedID;

            }

            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }


            return ID;

        }

        public static bool UpdateInternationalLicense(
              int ID, int ApplicationID,
             int DriverID, int IssuedUsingLocalLicenseID,
             DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE InternationalLicenses
                           SET 
                              ApplicationID=@ApplicationID,
                              DriverID = @DriverID,
                              IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                              IssueDate = @IssueDate,
                              ExpirationDate = @ExpirationDate,
                              IsActive = @IsActive,
                              CreatedByUserID = @CreatedByUserID
                         WHERE ID=@ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            command.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"  
                            SELECT Top 1 ID
                            FROM InternationalLicenses 
                            where DriverID=@DriverID and GetDate() between IssueDate and ExpirationDate 
                            order by ExpirationDate DESC;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ID = insertedID;
            }

            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }


            return ID;
        }




    }
}
