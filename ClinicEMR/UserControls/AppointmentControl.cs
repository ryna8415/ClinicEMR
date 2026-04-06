using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicEMR.Models;

namespace ClinicEMR.Forms
{
    public partial class AppointmentControl : UserControl
    {
        private readonly User _user;
        private readonly MainShellForm _shell;

        public AppointmentControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user; _shell = shell;
            dtpDate.Value = DateTime.Today;
        }

        private void AppointmentControl_Load(object s, EventArgs e) => LoadSchedule();

        public void LoadSchedule()
        {
            dgvAppointments.DataSource = AppointmentService.GetByDate(dtpDate.Value);
            HideCol("AppointmentId"); HideCol("PatientId");
            HideCol("DoctorId"); HideCol("CreatedBy");
            SetHeader("PatientName", "Patient"); SetHeader("DoctorName", "Doctor");
            SetHeader("ApptTime", "Time"); SetHeader("ApptDate", "Date");
        }

        private void btnLoad_Click(object s, EventArgs e) => LoadSchedule();

        private void btnBook_Click(object s, EventArgs e)
        {
            var form = new BookAppointmentForm(_user.UserId);
            if (form.ShowDialog() == DialogResult.OK) LoadSchedule();
        }

        private void btnUpdateStatus_Click(object s, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an appointment first.");
                return;
            }

            // Create dropdown
            Form dialog = new Form()
            {
                Width = 300,
                Height = 150,
                Text = "Update Status",
                StartPosition = FormStartPosition.CenterParent
            };

            ComboBox cbo = new ComboBox()
            {
                Left = 20,
                Top = 20,
                Width = 240,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cbo.Items.AddRange(new string[]
            {
            "Scheduled",
            "Completed",
            "Cancelled",
            "No-Show"
            });

            cbo.SelectedIndex = 1; // default = Completed

            Button btnOk = new Button()
            {
                Text = "OK",
                Left = 100,
                Width = 80,
                Top = 60,
                DialogResult = DialogResult.OK
            };

            dialog.Controls.Add(cbo);
            dialog.Controls.Add(btnOk);
            dialog.AcceptButton = btnOk;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string newStatus = cbo.SelectedItem.ToString();

                int id = (int)dgvAppointments
                    .SelectedRows[0]
                    .Cells["AppointmentId"].Value;

                AppointmentService.UpdateStatus(id, newStatus);
                LoadSchedule();
            }
        }

        private void HideCol(string n)
        {
            if (dgvAppointments.Columns[n] != null)
                dgvAppointments.Columns[n].Visible = false;
        }
        private void SetHeader(string n, string h)
        {
            if (dgvAppointments.Columns[n] != null)
                dgvAppointments.Columns[n].HeaderText = h;
        }
    }

}
