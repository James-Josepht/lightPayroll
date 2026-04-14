using lightPayrollModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BCrypt.Net;

namespace lightPayrollServices
{
    public class AuthService
    {

        private List<string> reservedUsernames = new List<string>
        {
            "admin", "root"
        };

        public bool IsReserved(string username)
        {
            return reservedUsernames.Contains(username.ToLower());
        }


        //used to send in the log in UI, whether thier acc ready to login or not
        public string ValidateCredentials(string username, string password)
        {
            var user = SQLiteDataAccess.GetUserByIdOrUsername(username);

            if (username == "admin" && password == "admin")
            {
                return "Active";
            }

            // Check user exists
            if (user != null)
            {
                // Use BCrypt VERIFY (THIS IS THE KEY FIX)
                bool isValid = PasswordHash.VerifyPassword(password, user.Password);

                if (isValid && user.AccountStatus == "Active")
                {
                    return "Active";
                }
                else if (isValid && user.AccountStatus == "Pending")
                {
                    return "Pending";
                }
            }

            return "Rejected";
        }


        public bool IsValidLightEmail(string email)
        {
            string pattern = @"^[a-zA-Z]+\.[a-zA-Z]+@light\.com$";
            return Regex.IsMatch(email, pattern);
        }

        public bool RegisterAccount(string username, string password, string role = "Employee")
        {
            
            //check if username already exists

            var existingUser = SQLiteDataAccess.GetUserByIdOrUsername(username);

            if (existingUser != null)
                return false;

            string hashedPassword = PasswordHash.HashPassword(password);//hash password before saving

            //Create user object
            EmployeeUser newUser = new EmployeeUser
            {
                Username = username,
                Password = hashedPassword, 
                Role = role,
                AccountStatus = "Pending"
            };

            //Save to DB
            SQLiteDataAccess.InsertUser(newUser);

            return true;
        }

    }

    public static class PasswordHash
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string inputPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);
        }
    }
}
