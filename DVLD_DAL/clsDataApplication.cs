using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataApplication
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static DataTable GetAllApplications()
        {

            DataTable dtPeople = new DataTable();

            string query = "select * from ApplicationsList_View order by ApplicationDate desc";
            //string query = "SELECT * FROM Applications;";
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

        public static bool GetApplicationInfoByID(int ID, ref int ApplicantPersonID, ref DateTime ApplicationDate,
        ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate,
        ref float PaidFees, ref int CreatedByUserID)
        {

            bool isFound = false;

            string query = "SELECT * FROM Applications WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    PaidFees = (float)reader["PaidFees"];
                    

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

        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
             byte ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID)
        {

            string msg = "";
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications ( 
                            ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                            ApplicationStatus,LastStatusDate,
                            PaidFees,CreatedByUserID)
                             VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,
                                      @ApplicationStatus,@LastStatusDate,
                                      @PaidFees,   @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("ApplicantPersonID", @ApplicantPersonID);
            command.Parameters.AddWithValue("ApplicationDate", @ApplicationDate);
            command.Parameters.AddWithValue("ApplicationTypeID", @ApplicationTypeID);
            command.Parameters.AddWithValue("ApplicationStatus", @ApplicationStatus);
            command.Parameters.AddWithValue("LastStatusDate", @LastStatusDate);
            command.Parameters.AddWithValue("PaidFees", @PaidFees);
            command.Parameters.AddWithValue("CreatedByUserID", @CreatedByUserID);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                msg = ex.Message;
            }

            finally
            {
                connection.Close();
            }


            return ID;
        }

        public static bool UpdateApplication(int ID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
             byte ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID)
        {

            string msg = "";
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Applications  
                            set ApplicantPersonID = @ApplicantPersonID,
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus, 
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID=@CreatedByUserID
                            where ID=@ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("ApplicantPersonID", @ApplicantPersonID);
            command.Parameters.AddWithValue("ApplicationDate", @ApplicationDate);
            command.Parameters.AddWithValue("ApplicationTypeID", @ApplicationTypeID);
            command.Parameters.AddWithValue("ApplicationStatus", @ApplicationStatus);
            command.Parameters.AddWithValue("LastStatusDate", @LastStatusDate);
            command.Parameters.AddWithValue("PaidFees", @PaidFees);
            command.Parameters.AddWithValue("CreatedByUserID", @CreatedByUserID);


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

        public static bool DeleteApplication(int ID)
        {

            string msg = "";
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Applications 
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

        public static bool IsApplicationExist(int ID)
        {

            string msg = "";
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Applications WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int GetActiveApplicationID(int PersonID, int ApplicationTypeID)
        {
            string msg = "";
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT ActiveApplicationID=ApplicationID FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID and ApplicationTypeID=@ApplicationTypeID and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
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

            return ActiveApplicationID;
        }

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
            => GetActiveApplicationID(PersonID, ApplicationTypeID) != -1;

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {

            string msg = "";
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT ActiveApplicationID=Applications.ID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
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

            return ActiveApplicationID;
        }

        public static bool UpdateStatus(int ID, short NewStatus)
        {

            string msg = "";
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus, 
                                LastStatusDate = @LastStatusDate
                            where ID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ID);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);
            command.Parameters.AddWithValue("LastStatusDate", DateTime.Now);


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


    }
}
