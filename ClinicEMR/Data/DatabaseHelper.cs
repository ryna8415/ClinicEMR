using System;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

public class DatabaseHelper
{
    private static string ConnStr
    {
        get
        {
            var config = AppConfig.Configuration;
            var conn = config?.GetConnectionString("ClinicEMR")
                       ?? Environment.GetEnvironmentVariable("ClinicEMR_ConnectionString");

            if (string.IsNullOrWhiteSpace(conn))
                throw new InvalidOperationException("Missing connection string 'ClinicEMR' in configuration.");

            return conn;
        }
    }

    public static MySqlConnection? GetConnection()
    {
        try
        {
            var conn = new MySqlConnection(ConnStr);
            conn.Open();
            return conn;
        }
        catch (MySqlException ex)
        {
            System.Windows.Forms.MessageBox.Show(
              "Cannot connect to the database.\n" +
              "Please check that MySQL is running and your configuration is set up.\n\n" +
              "Error: " + ex.Message,
              "Database Connection Error",
              System.Windows.Forms.MessageBoxButtons.OK,
              System.Windows.Forms.MessageBoxIcon.Error);
            return null;
        }
    }
}
