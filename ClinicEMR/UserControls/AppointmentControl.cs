using ClinicEMR.Services;
using System;
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
            _user = user;
            _shell = shell;
            GridViewService.MakeReadOnly(dgvAppointments);

            dtpDate.Value = DateTime.Today;

            // ✅ Default filter values
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new string[]
            {
                "All",
                "Scheduled",
                "Completed",
                "Cancelled",
                "No-Show"
            });

            cboStatus.SelectedIndex = 0; // Default = All
            chkAllDates.Checked = false;
        }

        private void AppointmentControl_Load(object s, EventArgs e)
        {
            LoadSchedule();
        }

        public void LoadSchedule()
        {
            string status = cboStatus.Text;
            bool allDates = chkAllDates.Checked;

            List<Appointment> data;

            // ✅ CASE 1: SHOW EVERYTHING
            if (allDates && status == "All")
            {
                data = AppointmentService.GetAll();
            }
            // ✅ CASE 2: FILTER BY STATUS ONLY
            else if (allDates)
            {
                data = AppointmentService.GetByStatus(status);
            }
            // ✅ CASE 3: FILTER BY DATE ONLY
            else if (status == "All")
            {
                data = AppointmentService.GetByDate(dtpDate.Value);
            }
            // ✅ CASE 4: FILTER BY DATE + STATUS
            else
            {
                data = AppointmentService.GetByDateAndStatus(dtpDate.Value, status);
            }

            // 🔄 Refresh grid properly
            dgvAppointments.DataSource = null;
            dgvAppointments.DataSource = data;

            GridViewService.ShowOnly(
                dgvAppointments,
                "AppointmentId",
                "ApptDate",
                "ApptTime",
                "PatientName",
                "DoctorName",
                "Purpose",
                "Status");

            GridViewService.SetHeaders(dgvAppointments, new Dictionary<string, string>
            {
                ["ApptDate"] = "Date",
                ["ApptTime"] = "Time",
                ["PatientName"] = "Patient",
                ["DoctorName"] = "Doctor",
                ["Purpose"] = "Purpose",
                ["Status"] = "Status"
            });

            HideCol("AppointmentId");
        }

        private void btnLoad_Click(object s, EventArgs e)
        {
            LoadSchedule();
        }

        private void btnBook_Click(object s, EventArgs e)
        {
            var form = new BookAppointmentForm(_user.UserId);
            if (form.ShowDialog() == DialogResult.OK)
                LoadSchedule();
        }

        private void btnUpdateStatus_Click(object s, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an appointment first.");
                return;
            }

            // 🔽 Status dialog
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

            cbo.SelectedIndex = 1;

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

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSchedule();
        }

        private void chkAllDates_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled = !chkAllDates.Checked;
            LoadSchedule();
        }
    }
}
