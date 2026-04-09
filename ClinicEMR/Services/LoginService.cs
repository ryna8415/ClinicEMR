using BCrypt.Net;
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
                    int userId = (int)reader["user_id"];
                    string usernameValue = reader["username"].ToString();
                    string fullNameValue = reader["full_name"].ToString();
                    string roleValue = reader["role"].ToString();
                    string hash = reader["password_hash"].ToString();

                    if (BCrypt.Net.BCrypt.Verify(password, hash))
                    {
                        reader.Close();

                        var updateCmd = new MySqlCommand(
                          "UPDATE users SET last_login=NOW() WHERE user_id=@id", conn);
                        updateCmd.Parameters.AddWithValue("@id", userId);
                        updateCmd.ExecuteNonQuery();

                        return new User
                        {
                            UserId = userId,
                            Username = usernameValue,
                            FullName = fullNameValue,
                            Role = roleValue
                        };
                    }
                }
                return null; // login failed
            }
        }
    }
}
