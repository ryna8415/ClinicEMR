using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class ReportControl : UserControl
    {
        private readonly User _user;
        private readonly Label _reportPlaceholder;

        public ReportControl(User user)
        {
            InitializeComponent();
            _user = user;
            dtpDate.Value = DateTime.Today;
            GridViewService.MakeReadOnly(dgvReport);
            _reportPlaceholder = CreatePlaceholder();
            ShowPlaceholder("Choose a date and click Generate to display the report.");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime d = dtpDate.Value.Date;
            int count = ReportService.GetDailyVisitCount(d);
            lblCount.Text = $"Patients seen on {d:MMMM dd, yyyy}: {count}";
            DataTable reportData = ReportService.GetDailySummary(d);
            dgvReport.DataSource = reportData;
            GridViewService.ShowOnly(dgvReport, "Patient Code", "Patient Name", "Diagnosis", "Doctor", "Time");
            ShowPlaceholder(reportData.Rows.Count == 0 ? "Nothing to show for the selected date." : null);
        }

        private Label CreatePlaceholder()
        {
            var placeholder = new Label
            {
                BackColor = Color.FromArgb(248, 249, 250),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.FromArgb(108, 117, 125),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                Bounds = dgvReport.Bounds,
                Anchor = dgvReport.Anchor,
                Visible = false
            };

            Controls.Add(placeholder);
            placeholder.BringToFront();
            return placeholder;
        }

        private void ShowPlaceholder(string? message)
        {
            bool showPlaceholder = !string.IsNullOrWhiteSpace(message);
            _reportPlaceholder.Text = message ?? string.Empty;
            _reportPlaceholder.Visible = showPlaceholder;
            dgvReport.Visible = !showPlaceholder;
        }
    }
}
