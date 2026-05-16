using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DAL
{
    public class clsDataLocalDrivingLicenseApplication
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static bool GetLocalDrivingLicenseApplicationInfoByID(int ID, ref int ApplicationID, ref int LicenseClassID)
        {

            bool IsFound = false;
            string msg = "";

            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

                }

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }

        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(ref int ID, int ApplicationID, ref int LicenseClassID)
        {

            bool IsFound = false;
            string msg = "";

            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    ID = (int)reader["ID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

                }

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {


            DataTable dtLocalDrivingLicenseApplications = new DataTable();
            string msg = "";

            string query = "SELECT * FROM LocalDrivingLicenseApplications_View ORDER BY ApplicationDate DESC;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dtLocalDrivingLicenseApplications.Load(reader);

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return dtLocalDrivingLicenseApplications;

        }

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {

            int ID = -1;

            string msg = "";

            string query = @"INSERT INTO LocalDrivingLicenseApplications 
                             (ApplicationID,LicenseClassID)
                             VALUES (@ApplicationID,@LicenseClassID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ID = insertedID;

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return ID;


        }

        public static bool UpdateLocalDrivingLicenseApplication(
            int ID, int ApplicationID, int LicenseClassID)
        {
            string msg = "";

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  LocalDrivingLicenseApplications  
                            set ApplicationID = @ApplicationID,
                                LicenseClassID = @LicenseClassID
                            where ID=@ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteLocalDrivingLicenseApplication(int ID)
        {

            string msg = "";
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete LocalDrivingLicenseApplications 
                                where ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static bool DoesPassTestType(int ID, int TestTypeID)

        {

            string msg = "";
            bool Result = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.ID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.ID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.ID = @ID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                    Result = returnedResult;
            }

            catch (Exception ex)
            {
                msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }

            return Result;

        }

        public static bool DoesAttendTestType(int ID, int TestTypeID)

        {

            string msg = "";
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.ID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.ID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.ID = @ID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.ID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    IsFound = true;
            }

            catch (Exception ex)
            {
                msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }

            return IsFound;

        }

        public static byte TotalTrialsPerTest(int ID, int TestTypeID)

        {

            string msg = "";
            byte TotalTrialsPerTest = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.ID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.ID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.ID = @ID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                       ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Trials))
                    TotalTrialsPerTest = Trials;

            }

            catch (Exception ex)
            {
                msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }

            return TotalTrialsPerTest;

        }

        public static bool IsThereAnActiveScheduledTest(int ID, int TestTypeID)
        {

            string msg = "";
            bool Result = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.ID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.ID = @ID)
                            AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked=0
                            ORDER BY TestAppointments.ID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    Result = true;
                }

            }

            catch (Exception ex)
            {
                msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }

            return Result;

        }







    }
}
