using System.Data;
using MySql.Data.MySqlClient;

namespace ClinicEMR.Services
{
    internal static class AuditLogService
    {
        public static void Log(int? userId, string action, string userName = "System")
        {
            if (string.IsNullOrWhiteSpace(action))
            {
                return;
            }

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null)
            {
                return;
            }

            using var cmd = new MySqlCommand(@"
                INSERT INTO audit_logs (user_id, user_name, action, logged_at)
                VALUES (
                    @userId,
                    COALESCE(
                        (SELECT full_name FROM users WHERE user_id = @userId LIMIT 1),
                        @userName
                    ),
                    @action,
                    NOW()
                );", conn);

            cmd.Parameters.AddWithValue("@userId", userId.HasValue && userId.Value > 0
                ? userId.Value
                : DBNull.Value);
            cmd.Parameters.AddWithValue("@userName", string.IsNullOrWhiteSpace(userName) ? "System" : userName.Trim());
            cmd.Parameters.AddWithValue("@action", action.Trim());
            cmd.ExecuteNonQuery();
        }

        public static DataTable GetRecentLogs(int limit = 20)
        {
            var table = new DataTable();

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null)
            {
                return table;
            }

            using var cmd = new MySqlCommand(@"
                SELECT
                    user_name AS 'User',
                    action AS 'Action',
                    logged_at AS 'Timestamp'
                FROM audit_logs
                ORDER BY logged_at DESC
                LIMIT @limit;", conn);

            cmd.Parameters.AddWithValue("@limit", limit);

            using var adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);

            return table;
        }
    }
}
