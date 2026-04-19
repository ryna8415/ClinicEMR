using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var form = new AddUserForm();
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
                int id = (int)row.Cells["UserId"].Value;
                UserService.Deactivate(id);
                LoadUsers();
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
                int id = (int)row.Cells["UserId"].Value;
                UserService.ReEnable(id);
                LoadUsers();
            }
        }
    }

}
