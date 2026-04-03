using Dapper;
using lightPayrollModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite; 
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace lightPayrollServices
{
    public class SQLiteDataAccess
    {
        /*  
        all these changes in the database is shown in
        lightPayroll\bin\Debug\net8.0-windows\lightPayrollDB.db
        not the one in
        lightPayroll\lightPayrollDB.db
         */

        public static List<Users> LoadUsers()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                // Step 1: Ensure the table exists
                string createTableSql = @"
                CREATE TABLE IF NOT EXISTS UsersTable (
                UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL,
                Role TEXT CHECK(Role IN ('Admin','Manager','Accountant','Employee')) NOT NULL,
                AccountStatus TEXT CHECK(AccountStatus IN ('Pending','Active','Rejected')) DEFAULT 'Pending',
                DateCreated TEXT DEFAULT CURRENT_TIMESTAMP
                );";

                conn.Execute(createTableSql);  // Dapper extension method for non-query commands

                // Step 2: Query the table
                var output = conn.Query<Users>("SELECT * FROM UsersTable", new DynamicParameters());

                var users = output.Select(u =>
                {
                    u.DateCreated = u.DateCreated.Value.ToLocalTime(); // converts to PH time
                    return u;
                }).ToList();


                return users;
            }
        }

        public static void InsertUser(Users user)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                INSERT INTO UsersTable 
                (Username, Password, Role, AccountStatus) 
                VALUES (@Username, @Password, @Role, @AccountStatus);";

                conn.Execute(sql, user);
            }
        }

        public static Users GetUserByUsername(string username)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "SELECT * FROM UsersTable WHERE Username = @Username";
                return conn.QueryFirstOrDefault<Users>(sql, new { Username = username });
            }
        }

        //UPDATE status (approve/reject accounts)
        public static void UpdateUserStatus(int userId, string status)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                UPDATE UsersTable 
                SET AccountStatus = @Status 
                WHERE UserID = @UserID";

                conn.Execute(sql, new { Status = status, UserID = userId });
            }
        }


        private static string LoadConnectionString(string id = "DefaultConnection")// goes to App.config to get the connection string with the name "Default"
        {
            var connStrings =  ConfigurationManager.ConnectionStrings[id].ConnectionString;

            if (connStrings == null)
            {
                throw new Exception($"Connection string '{id}' not found.");
            }

            return connStrings;
        }
    }

}
