using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            ThemeService.ApplyRoundedCorners(tblLayout, 10);
            ThemeService.TryRoundGrid(dgvReport, 4);

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime d = dtpDate.Value.Date;
                int count = ReportService.GetDailyVisitCount(d);
                lblCount.Text = $"Patients seen on {d:MMMM dd, yyyy}: {count}";
                DataTable reportData = ReportService.GetDailySummary(d);
                dgvReport.DataSource = reportData;
                GridViewService.ShowOnly(dgvReport, "Patient Code", "Patient Name", "Diagnosis", "Doctor", "Time");
                ShowPlaceholder(reportData.Rows.Count == 0 ? "Nothing to show for the selected date." : null);
            }
            catch (Exception ex)
            {
                dgvReport.DataSource = null;
                lblCount.Text = "Unable to load report.";
                ShowPlaceholder("Unable to load the report right now.");
                MessageBox.Show(ex.Message, "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dtpDate.Value.Date;
                DataTable reportData = ReportService.GetDailySummary(selectedDate);

                if (reportData.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Generate a report with at least one row before printing.",
                        "Nothing to Print",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                PrintService.ShowPrintPreview(
                    this,
                    $"Daily Report - {selectedDate:yyyy-MM-dd}",
                    BuildPrintableReport(selectedDate, reportData));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Label CreatePlaceholder()
        {
            Control parent = dgvReport.Parent ?? this;
            var placeholder = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(248, 249, 250),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.FromArgb(108, 117, 125),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                Margin = dgvReport.Margin,
                Visible = false
            };

            if (parent is TableLayoutPanel layout)
            {
                var position = layout.GetPositionFromControl(dgvReport);
                layout.Controls.Add(placeholder, position.Column, position.Row);
            }
            else
            {
                parent.Controls.Add(placeholder);
            }

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

        private string BuildPrintableReport(DateTime reportDate, DataTable reportData)
        {
            var builder = new StringBuilder();
            builder.AppendLine("CLINIC EMR DAILY REPORT");
            builder.AppendLine($"Date: {reportDate:MMMM dd, yyyy}");
            builder.AppendLine($"Prepared by: {_user.FullName}");
            builder.AppendLine($"Patients Seen: {reportData.Rows.Count}");
            builder.AppendLine();

            PrintService.AppendSection(
                builder,
                "Consultation Summary",
                reportData.Rows.Cast<DataRow>().Select((row, index) =>
                    $"{index + 1}. {row["Patient Code"]} | {row["Patient Name"]} | Diagnosis: {PrintService.DisplayValue(row["Diagnosis"]?.ToString())} | Doctor: {PrintService.DisplayValue(row["Doctor"]?.ToString())} | Time: {row["Time"]}"));

            return builder.ToString();
        }
    }
}
