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
        public static List<Model> LoadPeople()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                // Step 1: Ensure the table exists
                string createTableSql = @"
        CREATE TABLE IF NOT EXISTS UsersTable (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Username TEXT,
            Password TEXT
        );";

                conn.Execute(createTableSql);  // Dapper extension method for non-query commands

                // Step 2: Query the table
                var output = conn.Query<Model>("SELECT * FROM UsersTable", new DynamicParameters());

                return output.ToList();
            }
        }

        public static void SavePeople(Model people)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute("INSERT INTO UsersTable (Username, Password) VALUES (@Username, @Password)", people);
            }
        }


        private static string LoadConnectionString(string id = "DefaultConnection")// goes to App.config to get the connection string with the name "Default"
        {
            var settings =  ConfigurationManager.ConnectionStrings[id].ConnectionString;

            if (settings == null)
            {
                throw new Exception($"Connection string '{id}' not found.");
            }

            return settings;
        }
    }

    public class MessageDesign
    {
        



    }



}
