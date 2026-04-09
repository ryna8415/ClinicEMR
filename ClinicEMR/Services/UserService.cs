using System.Collections.Generic;
using System.Data;
using System.Linq;
using BCrypt.Net;
using ClinicEMR.Models;
using MySql.Data.MySqlClient;

namespace ClinicEMR.Services
{
    public class UserService
    {

        public static List<User> GetAll()
        {
            var list = new List<User>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;
                var cmd = new MySqlCommand(
                  "SELECT * FROM users ORDER BY full_name", conn);
                var r = cmd.ExecuteReader();
                while (r.Read()) list.Add(new User
                {
                    UserId = (int)r["user_id"],
                    Username = r["username"].ToString(),
                    FullName = r["full_name"].ToString(),
                    Role = r["role"].ToString(),
                    IsActive = Convert.ToBoolean(r["is_active"])
                });
            }
            return list;
        }

        public static DataTable GetRecentLogins(int limit = 10)
        {
            var dt = new DataTable();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return dt;

                var cmd = new MySqlCommand(@"
                    SELECT
                        full_name AS 'Full Name',
                        username AS 'Username',
                        role AS 'Role',
                        CASE WHEN is_active = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status',
                        last_login AS 'Last Login'
                    FROM users
                    WHERE last_login IS NOT NULL
                    ORDER BY last_login DESC
                    LIMIT @limit", conn);

                cmd.Parameters.AddWithValue("@limit", limit);

                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static List<User> GetByRole(string role)
        {
            var list = new List<User>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;
                var cmd = new MySqlCommand(
                  "SELECT * FROM users WHERE role=@r AND is_active=1", conn);
                cmd.Parameters.AddWithValue("@r", role);
                var r = cmd.ExecuteReader();
                while (r.Read()) list.Add(new User
                {
                    UserId = (int)r["user_id"],
                    FullName = r["full_name"].ToString(),
                    Role = r["role"].ToString()
                });
            }
            return list;
        }

        public static void Create(string username, string password,
                                  string fullName, string role)
        {
            username = username.Trim();
            fullName = fullName.Trim();
            role = role.Trim();

            var validationErrors = UserValidationService.ValidateNewUser(username, password, fullName, role);
            if (validationErrors.Any())
                throw new ArgumentException(string.Join("\n", validationErrors));

            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                if (UsernameExists(conn, username))
                    throw new InvalidOperationException("That username is already in use. Please choose a different username.");

                var cmd = new MySqlCommand(
                  "INSERT INTO users (username,password_hash,full_name,role) " +
                  "VALUES (@u,@h,@n,@r)", conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@h", hash);
                cmd.Parameters.AddWithValue("@n", fullName);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.ExecuteNonQuery();
            }
        }

        private static bool UsernameExists(MySqlConnection conn, string username)
        {
            using var cmd = new MySqlCommand(
                "SELECT 1 FROM users WHERE username=@u LIMIT 1", conn);
            cmd.Parameters.AddWithValue("@u", username);

            return cmd.ExecuteScalar() != null;
        }

        public static void Deactivate(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                // Step 1: Check current status
                var checkCmd = new MySqlCommand(
                    "SELECT is_active FROM users WHERE user_id=@id", conn);
                checkCmd.Parameters.AddWithValue("@id", userId);

                var result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                bool isActive = Convert.ToBoolean(result);

                if (!isActive)
                {
                    MessageBox.Show("This user is already deactivated.");
                    return;
                }

                var updateCmd = new MySqlCommand(
                    "UPDATE users SET is_active=0 WHERE user_id=@id", conn);
                updateCmd.Parameters.AddWithValue("@id", userId);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("User has been deactivated successfully.");
            }
        }

        public static void ReEnable(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                var cmd = new MySqlCommand(
                    "UPDATE users SET is_active=1 WHERE user_id=@id AND is_active=0", conn);

                cmd.Parameters.AddWithValue("@id", userId);

                int rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                {
                    MessageBox.Show("User is already active or does not exist.");
                }
                else
                {
                    MessageBox.Show("User has been re-enabled successfully.");
                }
            }
        }
    }
}
