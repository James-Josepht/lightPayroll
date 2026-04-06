using lightPayrollModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            // I am using simulation, I will just check against hardcoded values for admin.


                var user = SQLiteDataAccess.GetUserByIdOrUsername(username);
                if (user != null && user.Password == password && user.AccountStatus == "Active")
                {
                    return "Active";
                }
                else if (user != null && user.Password == password && user.AccountStatus == "Pending")
                {
                    return "Pending";
                }
                else if (username == "admin" && password == "admin")
                {
                    return "Active";
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


            //Create user object
            EmployeeUser newUser = new EmployeeUser
            {
                Username = username,
                Password = password, // next step: HASH THIS
                Role = role,
                AccountStatus = "Pending"
            };

            //Save to DB
            SQLiteDataAccess.InsertUser(newUser);

            return true;
        }

    }
}
