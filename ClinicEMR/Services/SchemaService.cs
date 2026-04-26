using MySql.Data.MySqlClient;

namespace ClinicEMR.Services
{
    internal static class SchemaService
    {
        private static bool _isEnsured;

        public static void EnsureDatabaseObjects()
        {
            if (_isEnsured)
            {
                return;
            }

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null)
            {
                return;
            }

            EnsureAuditLogsTable(conn);
            EnsureColumn(conn, "users", "recovery_question", "VARCHAR(120) NULL");
            EnsureColumn(conn, "users", "recovery_answer_hash", "VARCHAR(255) NULL");
            EnsureColumn(conn, "users", "recovery_failed_attempts", "INT NOT NULL DEFAULT 0");
            EnsureColumn(conn, "users", "recovery_locked_until", "DATETIME NULL");
            EnsureColumn(conn, "consultations", "status", "VARCHAR(20) NOT NULL DEFAULT 'Active'");
            EnsureColumn(conn, "consultations", "updated_at", "DATETIME NULL");
            EnsureColumn(conn, "prescriptions", "status", "VARCHAR(20) NOT NULL DEFAULT 'Active'");
            EnsureColumn(conn, "prescriptions", "updated_at", "DATETIME NULL");

            _isEnsured = true;
        }

        private static void EnsureAuditLogsTable(MySqlConnection conn)
        {
            const string sql = @"
                CREATE TABLE IF NOT EXISTS audit_logs (
                    audit_log_id INT AUTO_INCREMENT PRIMARY KEY,
                    user_id INT NULL,
                    user_name VARCHAR(100) NOT NULL,
                    action VARCHAR(255) NOT NULL,
                    logged_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                    INDEX idx_audit_logs_logged_at (logged_at),
                    CONSTRAINT fk_audit_logs_user
                        FOREIGN KEY (user_id) REFERENCES users(user_id)
                        ON DELETE SET NULL
                );";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private static void EnsureColumn(MySqlConnection conn, string tableName, string columnName, string columnDefinition)
        {
            using var existsCmd = new MySqlCommand(@"
                SELECT COUNT(*)
                FROM information_schema.columns
                WHERE table_schema = DATABASE()
                  AND table_name = @tableName
                  AND column_name = @columnName;", conn);

            existsCmd.Parameters.AddWithValue("@tableName", tableName);
            existsCmd.Parameters.AddWithValue("@columnName", columnName);

            int count = System.Convert.ToInt32(existsCmd.ExecuteScalar());
            if (count > 0)
            {
                return;
            }

            using var alterCmd = new MySqlCommand(
                $"ALTER TABLE {tableName} ADD COLUMN {columnName} {columnDefinition};",
                conn);
            alterCmd.ExecuteNonQuery();
        }
    }
}
