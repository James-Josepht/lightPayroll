using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public bool ValidateCredentials(string username, string password)
        {
            // In a real application, you would query the database here.
            // But since I am using simulation, I will just check against hardcoded values for admin.
            return username == "admin" && password == "admin";

        }

    }
}
