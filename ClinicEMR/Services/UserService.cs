using System;
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
        private const int RecoveryMaxAttempts = 5;
        private static readonly TimeSpan RecoveryLockoutDuration = TimeSpan.FromMinutes(15);

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

        public static void Create(
            string username,
            string password,
            string fullName,
            string role,
            string? recoveryQuestion = null,
            string? recoveryAnswer = null,
            int? actorUserId = null)
        {
            username = username.Trim();
            fullName = fullName.Trim();
            role = role.Trim();
            recoveryQuestion = recoveryQuestion?.Trim();
            recoveryAnswer = recoveryAnswer?.Trim();

            var validationErrors = UserValidationService.ValidateNewUser(username, password, fullName, role);
            if (validationErrors.Any())
                throw new ArgumentException(string.Join("\n", validationErrors));

            bool hasRecoverySetup =
                !string.IsNullOrWhiteSpace(recoveryQuestion) ||
                !string.IsNullOrWhiteSpace(recoveryAnswer);

            if (hasRecoverySetup)
            {
                var recoveryErrors = UserValidationService.ValidateRecoverySetup(
                    recoveryQuestion ?? string.Empty,
                    recoveryAnswer ?? string.Empty,
                    username);

                if (recoveryErrors.Any())
                {
                    throw new ArgumentException(string.Join(Environment.NewLine, recoveryErrors));
                }
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            string? recoveryHash = hasRecoverySetup
                ? BCrypt.Net.BCrypt.HashPassword(NormalizeRecoveryAnswer(recoveryAnswer ?? string.Empty))
                : null;
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                if (UsernameExists(conn, username))
                    throw new InvalidOperationException("That username is already in use. Please choose a different username.");

                var cmd = new MySqlCommand(
                  "INSERT INTO users (username,password_hash,full_name,role,recovery_question,recovery_answer_hash) " +
                  "VALUES (@u,@h,@n,@r,@question,@answerHash)", conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@h", hash);
                cmd.Parameters.AddWithValue("@n", fullName);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.Parameters.AddWithValue("@question", hasRecoverySetup ? recoveryQuestion : DBNull.Value);
                cmd.Parameters.AddWithValue("@answerHash", hasRecoverySetup ? recoveryHash : DBNull.Value);
                cmd.ExecuteNonQuery();

                AuditLogService.Log(actorUserId, $"Created user account for {fullName} ({role}).");
            }
        }

        private static bool UsernameExists(MySqlConnection conn, string username)
        {
            using var cmd = new MySqlCommand(
                "SELECT 1 FROM users WHERE username=@u LIMIT 1", conn);
            cmd.Parameters.AddWithValue("@u", username);

            return cmd.ExecuteScalar() != null;
        }

        public static void Deactivate(int userId, int? actorUserId = null)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                // Step 1: Check current status
                var checkCmd = new MySqlCommand(
                    "SELECT full_name, is_active FROM users WHERE user_id=@id", conn);
                checkCmd.Parameters.AddWithValue("@id", userId);

                using var reader = checkCmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                string fullName = reader["full_name"].ToString() ?? "User";
                bool isActive = Convert.ToBoolean(reader["is_active"]);
                reader.Close();

                if (!isActive)
                {
                    MessageBox.Show("This user is already deactivated.");
                    return;
                }

                var updateCmd = new MySqlCommand(
                    "UPDATE users SET is_active=0 WHERE user_id=@id", conn);
                updateCmd.Parameters.AddWithValue("@id", userId);

                updateCmd.ExecuteNonQuery();

                AuditLogService.Log(actorUserId, $"Deactivated user account for {fullName}.");
                MessageBox.Show("User has been deactivated successfully.");
            }
        }

        public static void ReEnable(int userId, int? actorUserId = null)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                string fullName = GetFullName(conn, userId);
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
                    AuditLogService.Log(actorUserId, $"Re-enabled user account for {fullName}.");
                    MessageBox.Show("User has been re-enabled successfully.");
                }
            }
        }

        public static void ResetPassword(int userId, string username, string newPassword, int? actorUserId = null)
        {
            var passwordErrors = UserValidationService.ValidatePassword(newPassword, username);
            if (passwordErrors.Any())
            {
                throw new ArgumentException(string.Join(Environment.NewLine, passwordErrors));
            }

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null)
            {
                return;
            }

            string fullName = GetFullName(conn, userId);
            string hash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            using var cmd = new MySqlCommand(
                "UPDATE users SET password_hash=@hash WHERE user_id=@id", conn);
            cmd.Parameters.AddWithValue("@hash", hash);
            cmd.Parameters.AddWithValue("@id", userId);

            if (cmd.ExecuteNonQuery() == 0)
            {
                throw new InvalidOperationException("The selected user could not be updated.");
            }

            AuditLogService.Log(actorUserId, $"Reset password for {fullName}.");
        }

        public static bool HasRecoveryConfigured(int userId)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null)
            {
                return false;
            }

            using var cmd = new MySqlCommand(@"
                SELECT recovery_question, recovery_answer_hash
                FROM users
                WHERE user_id=@id
                LIMIT 1;", conn);
            cmd.Parameters.AddWithValue("@id", userId);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                return false;
            }

            return !string.IsNullOrWhiteSpace(reader["recovery_question"]?.ToString()) &&
                   !string.IsNullOrWhiteSpace(reader["recovery_answer_hash"]?.ToString());
        }

        public static void ConfigureRecovery(int userId, string question, string answer, int? actorUserId = null)
        {
            var errors = UserValidationService.ValidateRecoverySetup(question, answer);
            if (errors.Any())
            {
                throw new ArgumentException(string.Join(Environment.NewLine, errors));
            }

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null)
            {
                return;
            }

            using var selectCmd = new MySqlCommand(@"
                SELECT full_name, role
                FROM users
                WHERE user_id=@id
                LIMIT 1;", conn);
            selectCmd.Parameters.AddWithValue("@id", userId);

            using var reader = selectCmd.ExecuteReader();
            if (!reader.Read())
            {
                throw new InvalidOperationException("The selected user could not be loaded.");
            }

            string fullName = reader["full_name"]?.ToString() ?? "User";
            reader.Close();

            string hash = BCrypt.Net.BCrypt.HashPassword(NormalizeRecoveryAnswer(answer));

            using var updateCmd = new MySqlCommand(@"
                UPDATE users
                SET recovery_question=@question,
                    recovery_answer_hash=@hash,
                    recovery_failed_attempts=0,
                    recovery_locked_until=NULL
                WHERE user_id=@id;", conn);
            updateCmd.Parameters.AddWithValue("@question", question.Trim());
            updateCmd.Parameters.AddWithValue("@hash", hash);
            updateCmd.Parameters.AddWithValue("@id", userId);
            updateCmd.ExecuteNonQuery();

            AuditLogService.Log(actorUserId, $"Updated recovery details for {fullName}.");
        }

        public static string GetRecoveryQuestion(string username)
        {
            username = username?.Trim() ?? string.Empty;

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null)
            {
                return string.Empty;
            }

            using var cmd = new MySqlCommand(@"
                SELECT recovery_question
                FROM users
                WHERE username=@username
                  AND is_active=1
                LIMIT 1;", conn);
            cmd.Parameters.AddWithValue("@username", username);

            return cmd.ExecuteScalar()?.ToString() ?? string.Empty;
        }

        public static void ResetPasswordWithRecovery(string username, string recoveryAnswer, string newPassword)
        {
            username = username?.Trim() ?? string.Empty;
            recoveryAnswer = recoveryAnswer?.Trim() ?? string.Empty;

            var passwordErrors = UserValidationService.ValidatePassword(newPassword, username);
            if (passwordErrors.Any())
            {
                throw new ArgumentException(string.Join(Environment.NewLine, passwordErrors));
            }

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null)
            {
                return;
            }

            using var cmd = new MySqlCommand(@"
                SELECT user_id, full_name, role, recovery_answer_hash, recovery_failed_attempts, recovery_locked_until
                FROM users
                WHERE username=@username
                  AND is_active=1
                LIMIT 1;", conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                throw new InvalidOperationException("No active account matched that username.");
            }

            int userId = Convert.ToInt32(reader["user_id"]);
            string fullName = reader["full_name"]?.ToString() ?? "User";
            string role = reader["role"]?.ToString() ?? "user";
            string recoveryHash = reader["recovery_answer_hash"]?.ToString() ?? string.Empty;
            int failedAttempts = Convert.ToInt32(reader["recovery_failed_attempts"]);
            DateTime? lockedUntil = reader["recovery_locked_until"] == DBNull.Value
                ? null
                : Convert.ToDateTime(reader["recovery_locked_until"]);
            reader.Close();

            if (string.IsNullOrWhiteSpace(recoveryHash))
            {
                throw new InvalidOperationException("Recovery is not configured for this account.");
            }

            if (lockedUntil.HasValue && lockedUntil.Value > DateTime.Now)
            {
                throw new InvalidOperationException(
                    $"Recovery is temporarily locked until {lockedUntil.Value:MMMM dd, yyyy hh:mm tt}.");
            }

            if (!BCrypt.Net.BCrypt.Verify(NormalizeRecoveryAnswer(recoveryAnswer), recoveryHash))
            {
                RegisterRecoveryFailure(conn, userId, failedAttempts + 1);
                throw new InvalidOperationException("The recovery answer did not match.");
            }

            string newPasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            using var updateCmd = new MySqlCommand(@"
                UPDATE users
                SET password_hash=@hash,
                    recovery_failed_attempts=0,
                    recovery_locked_until=NULL
                WHERE user_id=@id", conn);
            updateCmd.Parameters.AddWithValue("@hash", newPasswordHash);
            updateCmd.Parameters.AddWithValue("@id", userId);

            if (updateCmd.ExecuteNonQuery() == 0)
            {
                throw new InvalidOperationException("The password could not be updated.");
            }

            AuditLogService.Log(userId, $"Recovered password for {fullName} ({role}) using local recovery.");
        }

        public static void ClearRecoverySetup(int userId, int? actorUserId = null)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null)
            {
                return;
            }

            string fullName = GetFullName(conn, userId);

            using var cmd = new MySqlCommand(@"
                UPDATE users
                SET recovery_question=NULL,
                    recovery_answer_hash=NULL,
                    recovery_failed_attempts=0,
                    recovery_locked_until=NULL
                WHERE user_id=@id;", conn);
            cmd.Parameters.AddWithValue("@id", userId);

            if (cmd.ExecuteNonQuery() == 0)
            {
                throw new InvalidOperationException("The selected user could not be updated.");
            }

            AuditLogService.Log(actorUserId, $"Cleared recovery setup for {fullName}.");
        }

        private static string GetFullName(MySqlConnection conn, int userId)
        {
            using var cmd = new MySqlCommand(
                "SELECT full_name FROM users WHERE user_id=@id LIMIT 1", conn);
            cmd.Parameters.AddWithValue("@id", userId);

            return cmd.ExecuteScalar()?.ToString() ?? "User";
        }

        private static string NormalizeRecoveryAnswer(string answer)
        {
            return (answer ?? string.Empty).Trim().ToUpperInvariant();
        }

        private static void RegisterRecoveryFailure(MySqlConnection conn, int userId, int failedAttempts)
        {
            bool shouldLock = failedAttempts >= RecoveryMaxAttempts;
            DateTime? lockedUntil = shouldLock ? DateTime.Now.Add(RecoveryLockoutDuration) : null;

            using var cmd = new MySqlCommand(@"
                UPDATE users
                SET recovery_failed_attempts=@failedAttempts,
                    recovery_locked_until=@lockedUntil
                WHERE user_id=@id;", conn);
            cmd.Parameters.AddWithValue("@failedAttempts", shouldLock ? 0 : failedAttempts);
            cmd.Parameters.AddWithValue("@lockedUntil", lockedUntil.HasValue ? lockedUntil.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@id", userId);
            cmd.ExecuteNonQuery();
        }
    }
}
