using DVLD_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD.Helpers
{
    internal class clsValidation
    {

        public static bool IsNameValid(string Name, ref string ErrorMessage)
        {
            bool IsValid = !string.IsNullOrWhiteSpace(Name) &&
                           Name.Trim().Length >= 2 &&
                           Name.Trim().Length <= 20 &&
                           Name.Trim().All(c => char.IsLetter(c) || c == '-' || c == '\'' || c == ' ');

            if (!IsValid)
            {
                if (string.IsNullOrWhiteSpace(Name))
                    ErrorMessage = "Name cannot be empty or whitespace.";
                else if (Name.Trim().Length < 2)
                    ErrorMessage = "Name must be at least 2 characters long.";
                else if (Name.Trim().Length > 20)
                    ErrorMessage = "Name cannot exceed 20 characters.";
                else if (!Name.Trim().All(c => char.IsLetter(c) || c == '-' || c == '\'' || c == ' '))
                    ErrorMessage = "Name can only contain letters, hyphens, apostrophes, and spaces.";
                else
                    ErrorMessage = "Invalid name format.";
            }
            else ErrorMessage = string.Empty;


            return IsValid;
        }

        public static bool IsNationalNoValid(string NationalNO, ref string ErrorMessage, int PersonID = -1)
        {

            if (string.IsNullOrWhiteSpace(NationalNO))
            {
                ErrorMessage = "National number cannot be empty or whitespace.";
                return false;
            }

            string trimmedNationalNO = NationalNO.Trim();


            if (trimmedNationalNO.Length < 2)
            {
                ErrorMessage = "National number must be at least 2 character long.";
                return false;
            }

            if (trimmedNationalNO.Length > 20)
            {
                ErrorMessage = "National number cannot exceed 20 characters.";
                return false;
            }



            clsPerson existingPerson = clsPerson.Find(trimmedNationalNO);

            if (existingPerson != null)
            {
                // If PersonID is -1 (Add mode) OR if existing person ID is different from current person ID (Update mode)
                if (PersonID == -1 || existingPerson.ID != PersonID)
                {
                    ErrorMessage = "This national number already exists in the system.";
                    return false;
                }
            }


            //if (clsPerson.IsPersonExist(NationalNO))
            //{
            //    ErrorMessage = "This national number already exists in the system.";
            //    return false;
            //}

            ErrorMessage = string.Empty;
            return true;

        }

        public static bool IsDateValid(DateTime D, ref string ErrorMessage)
        {

            ErrorMessage = string.Empty;

            if (D > DateTime.Today.AddYears(-18))
            {

                ErrorMessage = "You must be at least 18 years old.";

                D = DateTime.Today.AddYears(-18);

                return false;
            }

            return true;

        }

        public static bool IsAddressValid(string Address, ref string ErrorMessage)
        {

            if (string.IsNullOrWhiteSpace(Address))
            {
                ErrorMessage = "Address is required.";
                return false;
            }

            string trimmedAddress = Address.Trim();


            if (trimmedAddress.Length < 5)
            {
                ErrorMessage = "Please enter a valid address (minimum 5 characters).";
                return false;
            }

            if (trimmedAddress.Length > 100)
            {
                ErrorMessage = "Address is too long (maximum 100 characters).";
                return false;
            }


            ErrorMessage = string.Empty;
            return true;

        }
        
        public static bool IsEmailValid(string Email, ref string ErrorMessage, int PersonID = -1)
        {
            // Allow empty email (optional field)
            if (string.IsNullOrWhiteSpace(Email))
            {
                ErrorMessage = string.Empty;
                return true;
            }

            string trimmedEmail = Email.Trim();

            // Check email length (max 254 characters)
            if (trimmedEmail.Length > 254)
            {
                ErrorMessage = "Email address is too long (maximum 254 characters).";
                return false;
            }

            // Check email format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(trimmedEmail, pattern);

            if (!isValid)
            {
                ErrorMessage = "Invalid email format. Email should be in format: username@domain.com";
                return false;
            }

            // Check if email already exists in the system
            if (PersonID == -1) // Add mode
            {
                if (clsPerson.IsEmailExist(trimmedEmail))
                {
                    ErrorMessage = "This email address is already registered to another person.";
                    return false;
                }
            }
            else // Update mode
            {
                // Get the existing person's email from the database
                string existingEmail = "";
                clsPerson existingPerson = clsPerson.Find(PersonID);
                if (existingPerson != null)
                {
                    existingEmail = existingPerson.Email;
                }

                // If email hasn't changed, skip uniqueness check
                if (trimmedEmail != existingEmail)
                {
                    if (clsPerson.IsEmailExist(trimmedEmail, PersonID))
                    {
                        ErrorMessage = "This email address is already registered to another person.";
                        return false;
                    }
                }
            }

            ErrorMessage = string.Empty;
            return true;
        }

        public static bool IsPhoneValid(string Phone, ref string ErrorMessage, int PersonID = -1)
        {
            // Check if phone is empty (required field)
            if (string.IsNullOrWhiteSpace(Phone))
            {
                ErrorMessage = "Phone number cannot be empty.";
                return false;
            }

            // Remove non-digit characters
            string digitsOnly = new string(Phone.Where(char.IsDigit).ToArray());

            // Check minimum length
            if (digitsOnly.Length < 8)
            {
                ErrorMessage = "Phone number must contain at least 8 digits.";
                return false;
            }

            // Check maximum length
            if (digitsOnly.Length > 15)
            {
                ErrorMessage = "Phone number cannot exceed 15 digits.";
                return false;
            }

            // Check if phone number already exists in the system
            if (PersonID == -1) // Add mode
            {
                if (clsPerson.IsPhoneExist(digitsOnly))
                {
                    ErrorMessage = "This phone number is already registered to another person.";
                    return false;
                }
            }
            else // Update mode
            {
                // Get the existing person's phone from the database
                string existingPhone = "";
                clsPerson existingPerson = clsPerson.Find(PersonID);
                if (existingPerson != null)
                {
                    existingPhone = new string(existingPerson.Phone.Where(char.IsDigit).ToArray());
                }

                // If phone hasn't changed, skip uniqueness check
                if (digitsOnly != existingPhone)
                {
                    if (clsPerson.IsPhoneExist(digitsOnly, PersonID))
                    {
                        ErrorMessage = "This phone number is already registered to another person.";
                        return false;
                    }
                }
            }

            ErrorMessage = string.Empty;
            return true;
        }

        //
        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
            => ValidateInteger(Number) || ValidateFloat(Number);


        // User Validation
        public static bool IsUsernameValid(string Username, ref string ErrorMessage, int UserID = -1)
        {

            if (string.IsNullOrWhiteSpace(Username))
            {
                ErrorMessage = "Username cannot be empty or whitespace.";
                return false;
            }

            string trimmedUsername = Username.Trim();


            if (trimmedUsername.Length < 3)
            {
                ErrorMessage = "Username must be at least 3 characters long.";
                return false;
            }


            if (trimmedUsername.Length > 30)
            {
                ErrorMessage = "Username cannot exceed 30 characters.";
                return false;
            }


            if (!trimmedUsername.All(c => char.IsLetterOrDigit(c) || c == '_' || c == '.'))
            {
                ErrorMessage = "Username can only contain letters, numbers, underscores (_), and dots (.).";
                return false;
            }


            if (trimmedUsername.StartsWith(".") || trimmedUsername.StartsWith("_") ||
                trimmedUsername.EndsWith(".") || trimmedUsername.EndsWith("_"))
            {
                ErrorMessage = "Username cannot start or end with underscore (_) or dot (.).";
                return false;
            }


            if (trimmedUsername.Contains("..") || trimmedUsername.Contains("__"))
            {
                ErrorMessage = "Username cannot contain consecutive dots (..) or underscores (__).";
                return false;
            }


            if (UserID == -1) // Add mode
            {
                if (clsUser.IsUserExistByUsername(trimmedUsername))
                {
                    ErrorMessage = "This username is already taken. Please choose another one.";
                    return false;
                }
            }
            else // Update mode
            {
                // Get the existing username from the database
                string existingUsername = "";
                clsUser existingUser = clsUser.GetUserByID(UserID);
                if (existingUser != null)
                {
                    existingUsername = existingUser.Username;
                }

                // If username hasn't changed, skip uniqueness check
                if (trimmedUsername != existingUsername)
                {
                    if (clsUser.IsUserExistByUsernameAndNotID(trimmedUsername, UserID))
                    {
                        ErrorMessage = "This username is already taken. Please choose another one.";
                        return false;
                    }
                }
            }

            ErrorMessage = string.Empty;
            return true;
        }

        public static bool IsPasswordValid(string Password, ref string ErrorMessage)
        {

            if (string.IsNullOrWhiteSpace(Password))
            {
                ErrorMessage = "Password cannot be empty or whitespace.";
                return false;
            }

            string trimmedPassword = Password.Trim();


            if (trimmedPassword.Length < 6)
            {
                ErrorMessage = "Password must be at least 6 characters long.";
                return false;
            }


            if (trimmedPassword.Length > 50)
            {
                ErrorMessage = "Password cannot exceed 50 characters.";
                return false;
            }


            if (!trimmedPassword.Any(char.IsUpper))
            {
                ErrorMessage = "Password must contain at least one uppercase letter.";
                return false;
            }


            if (!trimmedPassword.Any(char.IsLower))
            {
                ErrorMessage = "Password must contain at least one lowercase letter.";
                return false;
            }


            if (!trimmedPassword.Any(char.IsDigit))
            {
                ErrorMessage = "Password must contain at least one number.";
                return false;
            }


            //string specialCharacters = @"!@#$%^&*()_+-=[]{}|;:,.<>?";
            //if (!trimmedPassword.Any(c => specialCharacters.Contains(c)))
            //{
            //    ErrorMessage = "Password must contain at least one special character (!@#$%^&*()_+-=[]{}|;:,.<>?).";
            //    return false;
            //}


            if (trimmedPassword.Any(char.IsWhiteSpace))
            {
                ErrorMessage = "Password cannot contain spaces.";
                return false;
            }

            //// Check for common weak passwords (optional)
            //string[] weakPasswords = { "Password123!", "Admin123!", "Qwerty123!", "123456Aa!", "Password@123" };
            //if (weakPasswords.Contains(trimmedPassword))
            //{
            //    ErrorMessage = "Password is too weak. Please choose a stronger password.";
            //    return false;
            //}

            ErrorMessage = string.Empty;
            return true;
        }

        public static bool IsConfirmPasswordValid(string Password, string ConfirmPassword, ref string ErrorMessage)
        {

            if (string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                ErrorMessage = "Confirm password cannot be empty.";
                return false;
            }

            string trimmedPassword = Password?.Trim() ?? "";
            string trimmedConfirmPassword = ConfirmPassword.Trim();

            // Check if passwords match
            if (trimmedPassword != trimmedConfirmPassword)
            {
                ErrorMessage = "Password and confirm password do not match.";
                return false;
            }

            ErrorMessage = string.Empty;
            return true;
        }



    }
}
