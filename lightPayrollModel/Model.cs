using System;


namespace lightPayrollModel
{
    public class Model
    {
        private int userID;
        private string? username;
        private string? password;
        private string? firstName;
        private string? middleName;
        private string? lastName;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public int UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FullName
        {
            get { return $"{this.firstName} {this.middleName} {this.lastName}"; }
        }







    }
}
