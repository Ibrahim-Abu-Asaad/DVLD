using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public class clsDataPerson
    {

        readonly static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static SqlConnection connection = new SqlConnection(ConnectionString);

        public static DataTable GetPeople()
        {

            DataTable dtPeople = new DataTable();

            //SqlConnection connection = new SqlConnection(ConnectionString);

            string query = "SELECT * FROM People";
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
                //Console.WriteLine("Error: " + msg);
            }
            finally
            {
                connection.Close();
            }

            return dtPeople;


        }

        public static DataTable GetPeopleAndHideSomeColumns()
        {

            DataTable dtPeople = new DataTable();

            //SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"SELECT People.NationalNo AS 'National NO', People.FirstName AS 'First Name', People.LastName AS 'Last Name',
                             CASE 
                                WHEN People.Gender = 0 THEN 'Male' 
                                WHEN Gender = 1 THEN 'Female' 
                             ELSE 'Unknown' 
                             END AS Gender, 
                             People.Email, Countries.CountryName AS 'Nationality'
                             FROM People INNER JOIN
                             Countries ON People.NationalityCountryID = Countries.ID
                             ORDER BY People.FirstName ASC;";
            
            
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

        public static bool GetPersonInfoByID(int ID, ref string NationalNO, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {

            bool IsFound = false;

            string query = "SELECT * FROM People WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);


            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    IsFound = true;

                    NationalNO = reader["NationalNO"].ToString();
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();

                    ThirdName = reader["ThirdName"] == DBNull.Value ? "" : reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();

                    if (reader["DateOfBirth"] != DBNull.Value)
                        DateOfBirth = (DateTime)reader["DateOfBirth"];

                    Gender = Convert.ToInt32(reader["Gender"]);

                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();

                    Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString();

                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = reader["ImagePath"] == DBNull.Value ? "" : reader["ImagePath"].ToString();

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

        public static bool GetPersonInfoByNationalNO(ref int ID, string NationalNO, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {

            bool IsFound = false;

            string query = "SELECT * FROM People WHERE NationalNO = @NationalNO";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);


            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    IsFound = true;

                    ID = (int)reader["ID"];
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();

                    ThirdName = reader["ThirdName"] == DBNull.Value ? "" : reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();

                    if (reader["DateOfBirth"] != DBNull.Value)
                        DateOfBirth = (DateTime)reader["DateOfBirth"];

                    Gender = Convert.ToInt32(reader["Gender"]);

                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();

                    Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString();

                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = reader["ImagePath"] == DBNull.Value ? "" : reader["ImagePath"].ToString();

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

        public static int AddNewPerson(string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int ID = -1;

            string query = @"INSERT INTO [dbo].[People]([NationalNo],[FirstName],[SecondName],[ThirdName],[LastName],[DateOfBirth],[Gender],[Address],[Phone],[Email],[NationalityCountryID],[ImagePath])
                             VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gender,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNO);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (string.IsNullOrEmpty(ThirdName))
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ThirdName", ThirdName);

            if (string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);

            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);


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

        public static bool UpdatePerson(int ID, string NationalNO, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int rowsAffected = 0;

            string query = @"UPDATE [dbo].[People]
                     SET [NationalNo] = @NationalNo,
                         [FirstName] = @FirstName,
                         [SecondName] = @SecondName,
                         [ThirdName] = @ThirdName,
                         [LastName] = @LastName,
                         [DateOfBirth] = @DateOfBirth,
                         [Gender] = @Gender,
                         [Address] = @Address,
                         [Phone] = @Phone,
                         [Email] = @Email,
                         [NationalityCountryID] = @NationalityCountryID,
                         [ImagePath] = @ImagePath
                     WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@NationalNo", NationalNO);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (string.IsNullOrEmpty(ThirdName))
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ThirdName", ThirdName);

            if (string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);

            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

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

            return (rowsAffected > 0);

        }

        public static bool DeletePerson(int ID)
        {

            int rowsAffected = 0;

            string query = @"DELETE FROM People WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

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

            return (rowsAffected > 0);

        }

        public static bool IsPersonExist(int ID)
        {

            bool isFound = false;

            string query = "SELECT Found=1 FROM People WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;

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

        public static bool IsPersonExist(string NationalNO)
        {

            bool isFound = false;

            string query = "SELECT Found=1 FROM People WHERE NationalNO = @NationalNO";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;

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

        public static bool IsPhoneExist(string Phone)
        {
            bool isFound = false;

            string query = "SELECT Found=1 FROM People WHERE Phone = @Phone";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Phone", Phone);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
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

        public static bool IsPhoneExist(string Phone, int ExcludePersonID)
        {
            bool isFound = false;

            string query = "SELECT Found=1 FROM People WHERE Phone = @Phone AND ID != @ExcludePersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@ExcludePersonID", ExcludePersonID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
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

        public static bool IsEmailExist(string Email)
        {
            bool isFound = false;

            string query = "SELECT Found=1 FROM People WHERE Email = @Email";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", Email);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
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

        public static bool IsEmailExist(string Email, int ExcludePersonID)
        {
            bool isFound = false;

            string query = "SELECT Found=1 FROM People WHERE Email = @Email AND ID != @ExcludePersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@ExcludePersonID", ExcludePersonID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
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
