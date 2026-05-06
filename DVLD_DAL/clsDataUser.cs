using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataUser
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static bool GetUserInfoByID(int ID, ref int PersonID, ref string Username, ref string Password, ref bool IsActive)
        {

            bool IsFound = false;
            string msg = "";


            string query = @"SELECT * FROM Users WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    Username = reader["Username"].ToString();
                    Password = reader["Password"].ToString();
                    IsActive = (bool)reader["IsActive"];
                    PersonID = (int)reader["PersonID"];

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

        public static bool GetUserInfoByPersonID(ref int ID, int PersonID, ref string Username, ref string Password, ref bool IsActive)
        {

            bool IsFound = false;
            string msg = "";


            string query = @"SELECT * FROM Users WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    ID = (int)reader["ID"];
                    Username = reader["Username"].ToString();
                    Password = reader["Password"].ToString();
                    IsActive = (bool)reader["IsActive"];

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

        public static bool GetUserInfoByUsername(ref int ID, ref int PersonID, string Username, ref string Password, ref bool IsActive)
        {

            bool IsFound = false;
            string msg = "";


            string query = @"SELECT * FROM Users WHERE Username = @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    ID = (int)reader["ID"];
                    Password = reader["Password"].ToString();
                    IsActive = (bool)reader["IsActive"];
                    PersonID = (int)reader["PersonID"];

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

        public static bool IsUserExistByID(int ID)
        {

            bool IsUserExist = false;
            string msg = "";


            string query = @"SELECT Found=1 FROM Users WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    IsUserExist = true;




            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return IsUserExist;

        }

        public static bool IsUserExistByPersonID(int PersonID)
        {

            bool IsUserExist = false;
            string msg = "";


            string query = @"SELECT Found=1 FROM Users WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    IsUserExist = true;




            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return IsUserExist;

        }

        public static bool IsUserExistByUsername(string Username)
        {

            bool IsUserExist = false;
            string msg = "";


            string query = @"SELECT Found=1 FROM Users WHERE Username = @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    IsUserExist = true;




            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return IsUserExist;

        }

        
        //kkk////////////////////////////////
        public static bool IsUserExistByUsernameAndNotID(string Username, int UserID)
        {
            bool IsUserExist = false;
            string msg = "";

            string query = @"SELECT Found=1 FROM Users WHERE Username = @Username AND ID != @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    IsUserExist = true;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return IsUserExist;
        }


        public static int AddNewUser(int PersonID, string Username, string Password, bool IsActive)
        {

            int NewUserID = -1;
            string msg = "";

            string query = @"INSERT INTO Users VALUES(@PersonID, @Username, @Password, @IsActive);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {

                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int NewID))
                    NewUserID = NewID;

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return NewUserID;


        }

        public static bool UpdateUser(int ID, int PersonID, string Username, string Password, bool IsActive)
        {

            bool IsUpdated = false;
            string msg = "";

            string query = @"UPDATE Users SET 
                                          PersonID = @PersonID,
                                          Username = @Username,
                                          Password = @Password,
                                          IsActive = @IsActive";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    IsUpdated = true;

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return IsUpdated;


        }

        public static DataTable GetAllUsers()
        {

            DataTable dtUsers = new DataTable();
            string msg = "";

            string query = @"SELECT * FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dtUsers.Load(reader);

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return dtUsers;

        }

        public static int NumberOfTotalUsersAndAdmins()
        {

            int TotalUsers = -1;
            string msg = "";

            string query = @"SELECT COUNT(ID) FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int NumberOfTotalUsers))
                    TotalUsers = NumberOfTotalUsers;


            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                connection.Close();
            }

            return TotalUsers;

        }

        //public static int NumberOfTotalUsersOnly()
        //{

        //    int TotalUsers = -1;
        //    string msg = "";

        //    string query = @"SELECT COUNT(ID) FROM Users WHERE RoleID = 1";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    try
        //    {

        //        connection.Open();

        //        object result = command.ExecuteScalar();
        //        if (result != null && int.TryParse(result.ToString(), out int NumberOfTotalUsers))
        //            TotalUsers = NumberOfTotalUsers;


        //    }
        //    catch (Exception ex)
        //    {
        //        msg = ex.Message;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return TotalUsers;

        //}










    }



}
