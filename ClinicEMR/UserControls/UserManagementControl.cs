using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using ClinicEMR.Forms;
using ClinicEMR.Helpers;

namespace ClinicEMR.UserControls
{
    public partial class UserManagementControl : UserControl
    {
        private readonly User _user;
        public UserManagementControl(User user)
        {
            InitializeComponent();
            _user = user;
            GridViewService.MakeReadOnly(dgvUsers);
            ThemeService.TryRoundGrid(dgvUsers, 4);
        }

        private void UserManagementControl_Load(object sender, EventArgs e)
          => LoadUsers();

        private void LoadUsers()
        {
            try
            {
                dgvUsers.DataSource = UserService.GetAll();
                GridViewService.ShowOnly(dgvUsers, "FullName", "Username", "Role", "IsActive");
                GridViewService.SetHeaders(dgvUsers, new Dictionary<string, string>
                {
                    ["FullName"] = "Name",
                    ["Username"] = "Username",
                    ["Role"] = "Role",
                    ["IsActive"] = "User Access Enabled"
                });
                GridViewService.ClearSelection(dgvUsers);
            }
            catch (Exception ex)
            {
                dgvUsers.DataSource = null;
                MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var form = new AddUserForm(_user.UserId);
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }
            var row = dgvUsers.SelectedRows[0];
            string name = row.Cells["FullName"].Value.ToString();
            var confirm = MessageBox.Show(
              $"Deactivate {name}? They will no longer be able to log in.",
              "Confirm Deactivate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int id = (int)row.Cells["UserId"].Value;
                    UserService.Deactivate(id, _user.UserId);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Deactivate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnReEnable_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }
            var row = dgvUsers.SelectedRows[0];
            string name = row.Cells["FullName"].Value.ToString();
            var confirm = MessageBox.Show(
              $"Reactivate {name}? They will be able to access ClinicEMR again.",
              "Confirm Re-Enable", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int id = (int)row.Cells["UserId"].Value;
                    UserService.ReEnable(id, _user.UserId);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Re-Enable User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnResetPassword_Click(object? sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            var row = dgvUsers.SelectedRows[0];
            int userId = (int)row.Cells["UserId"].Value;
            string username = row.Cells["Username"].Value.ToString() ?? string.Empty;
            string fullName = row.Cells["FullName"].Value.ToString() ?? "the selected user";

            using var dialog = new ResetPasswordForm(fullName, username);

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                UserService.ResetPassword(userId, username, dialog.NewPassword, _user.UserId);
                MessageBox.Show("Password reset successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearRecovery_Click(object? sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            var row = dgvUsers.SelectedRows[0];
            int userId = (int)row.Cells["UserId"].Value;
            string fullName = row.Cells["FullName"].Value.ToString() ?? "the selected user";

            var confirm = MessageBox.Show(
                $"Clear recovery setup for {fullName}? They will need to set it up again on their next sign-in.",
                "Clear Recovery",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                UserService.ClearRecoverySetup(userId, _user.UserId);
                MessageBox.Show("Recovery setup cleared.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clear Recovery", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
