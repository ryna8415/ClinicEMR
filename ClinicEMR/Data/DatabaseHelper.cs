using System;
using MySql.Data.MySqlClient;

namespace ClinicEMR.Data
{
    public class DatabaseHelper
    {
        // Change this connection string to match your MySQL setup
        private const string ConnStr =
          "Server=localhost;Database=clinicemr_db;Uid=root;Pwd=1234;";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(ConnStr);
            conn.Open();
            return conn;
        }
    }
}   
