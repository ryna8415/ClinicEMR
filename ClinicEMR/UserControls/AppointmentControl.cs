using ClinicEMR.Helpers;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Windows.Forms;

namespace ClinicEMR.Forms
{
    public partial class AppointmentControl : UserControl
    {
        private readonly Color Card1 = Color.FromArgb(92, 143, 204);
        private readonly Color Card2 = Color.FromArgb(74, 168, 122);
        private readonly Color Card3 = UITheme.OrangeWarning;
        private readonly Color Card4 = UITheme.AllergyRed;
        private readonly Color baseColor = UITheme.BlueSlate;


        private readonly User _user;
        private readonly MainShellForm _shell;

        public AppointmentControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            _shell = shell;
            GridViewService.MakeReadOnly(dgvAppointments);

            dtpDate.Value = DateTime.Today;

            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new string[]
            {
                "All",
                "Scheduled",
                "Completed",
                "Cancelled",
                "No-Show"
            });

            cboStatus.SelectedIndex = 0; 
            chkAllDates.Checked = false;
            ThemeService.ApplyRoundedCorners(tblLayout, 10);
            ThemeService.TryRoundGrid(dgvAppointments, 4);
            ThemeService.ApplyRoundedCorners(card1, 10);
            ThemeService.ApplyRoundedCorners(card2, 10);
            ThemeService.ApplyRoundedCorners(card3, 10);
            ThemeService.ApplyRoundedCorners(card4, 10);

        }

        private void AppointmentControl_Load(object s, EventArgs e)
        {
            LoadSchedule();
            ApplyHover(card1);
            ApplyHover(card2);
            ApplyHover(card3);
            ApplyHover(card4);
        }

        private void ApplyHover(Control parent)
        {
            parent.MouseEnter += Card_MouseEnter;
            parent.MouseLeave += Card_MouseLeave;


            parent.Cursor = Cursors.Hand;

            foreach (Control child in parent.Controls)
            {
                ApplyHover(child);
            }
        }

        public void LoadSchedule()
        {
            string status = cboStatus.Text;
            bool allDates = chkAllDates.Checked;

            List<Appointment> data;

            if (allDates && status == "All")
            {
                data = AppointmentService.GetAll();
            }
            else if (allDates)
            {
                data = AppointmentService.GetByStatus(status);
            }
            else if (status == "All")
            {
                data = AppointmentService.GetByDate(dtpDate.Value);
            }
            else
            {
                data = AppointmentService.GetByDateAndStatus(dtpDate.Value, status);
            }

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
            LoadTodaySummary();
        }

        private void LoadTodaySummary()
        {
            List<Appointment> todayAppointments = AppointmentService.GetByDate(DateTime.Today);

            int totalToday = todayAppointments.Count;
            int completedToday = 0;
            int remainingToday = 0;
            int cancelledToday = 0;

            foreach (Appointment appointment in todayAppointments)
            {
                string appointmentStatus = appointment.Status?.Trim() ?? string.Empty;

                if (appointmentStatus.Equals("Completed", StringComparison.OrdinalIgnoreCase))
                {
                    completedToday++;
                    continue;
                }

                if (appointmentStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) ||
                    appointmentStatus.Equals("No-Show", StringComparison.OrdinalIgnoreCase))
                {
                    cancelledToday++;
                    continue;
                }

                remainingToday++;
            }

            lblTodayTotalCount.Text = totalToday.ToString();
            lblDoneTodayCount.Text = completedToday.ToString();
            lblRemainingCount.Text = remainingToday.ToString();
            lblCancelledCount.Text = cancelledToday.ToString();
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

            int id = (int)dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value;
            var appointment = AppointmentService.GetById(id);
            if (appointment == null)
            {
                MessageBox.Show("Unable to load the selected appointment.");
                return;
            }

            using var dialog = new EditAppointmentForm(id, _user.UserId);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
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

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            Panel? p = GetCardPanel(sender);
            if (p == null) return;

            if (p.Tag as string != "hover")
            {
                string[] labelNames = { "lblTodayTotal", "lblCompleted", "lblRemaining", "lblCancelled" };

                foreach (string labelName in labelNames)
                {
                    if (p.Controls[labelName] is Label lbl)
                    {
                        switch (labelName)
                        {
                            case "lblTodayTotal":
                                lbl.ForeColor = Card1;
                                break;

                            case "lblCompleted":
                                lbl.ForeColor = Card2;
                                break;

                            case "lblRemaining":
                                lbl.ForeColor = Card3;
                                break;
                            case "lblCancelled":
                                lbl.ForeColor = Card4;
                                break;
                        }
                    }
                }
            }
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Panel? p = GetCardPanel(sender);
            if (p == null) return;

            string[] labelNames = { "lblTodayTotal", "lblCompleted", "lblRemaining", "lblCancelled" };

            foreach (string labelName in labelNames)
            {
                if (p.Controls[labelName] is Label lbl)
                {
                    lbl.ForeColor = baseColor;
                }
            }

            p.Tag = null;
        }
        private Panel? GetCardPanel(object sender)
        {
            Control? c = sender as Control;

            while (c != null && !(c is Panel))
                c = c.Parent;

            return c as Panel;
        }
    }
}
