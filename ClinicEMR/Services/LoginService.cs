using BCrypt.Net;
using ClinicEMR.Data;
using ClinicEMR.Models;
using MySql.Data.MySqlClient;

namespace ClinicEMR.Services
{
    public class LoginService
    {

        // Returns User object if login is valid, null if not
        public static User Authenticate(string username, string password)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new MySqlCommand(
                  "SELECT * FROM users WHERE username=@u AND is_active=1", conn);
                cmd.Parameters.AddWithValue("@u", username);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string hash = reader["password_hash"].ToString();
                    if (BCrypt.Net.BCrypt.Verify(password, hash))
                    {
                        return new User
                        {   
                            UserId = (int)reader["user_id"],
                            Username = reader["username"].ToString(),
                            FullName = reader["full_name"].ToString(),
                            Role = reader["role"].ToString()
                        };
                    }
                }
                return null; // login failed
            }
        }
    }
}
