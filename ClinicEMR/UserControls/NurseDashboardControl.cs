using ClinicEMR.Helpers;
using ClinicEMR.Models;
using ClinicEMR.Services;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class NurseDashboardControl : UserControl
    {
        private readonly Color Card1 = Color.FromArgb(92, 143, 204);
        private readonly Color Card2 = Color.FromArgb(91, 33, 182);
        private readonly Color Card3 = Color.FromArgb(74, 168, 122);
        private readonly Color baseColor = UITheme.BlueSlate;
        private readonly User _user;

        public NurseDashboardControl(User user)
        {
            InitializeComponent();
            _user = user;
            GridViewService.MakeReadOnly(dgvTodayAppts);
            ThemeService.ApplyRoundedCorners(card1, 10);
            ThemeService.ApplyRoundedCorners(card2, 10);
            ThemeService.ApplyRoundedCorners(card3, 10);
            ThemeService.ApplyRoundedCorners(tblLayout, 10);
            ThemeService.TryRoundGrid(dgvTodayAppts, 4);
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
        private void NurseDashboardControl_Load(object sender, EventArgs e)
        {
            ApplyHover(card1);
            ApplyHover(card2);
            ApplyHover(card3);
            LoadDashboardData();
        }
        private void Card_MouseEnter(object sender, EventArgs e)
        {
            Control card = GetCardContainer(sender);

            if (card == null || card.Tag as string == "hover")
            {
                return;
            }

            foreach (Label label in GetHoverLabels(card))
            {
                label.ForeColor = GetAccentColor(card);
            }

            card.Tag = "hover";
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Control card = GetCardContainer(sender);
            if (card == null)
            {
                return;
            }

            foreach (Label label in GetHoverLabels(card))
            {
                label.ForeColor = baseColor;
            }

            card.Tag = null;
        }

        private IEnumerable<Label> GetHoverLabels(Control card)
        {
            switch (card.Name)
            {
                case "card1":
                    if (card.Controls["lblTotalPatientsText"] is Label appointmentLabel)
                    {
                        yield return appointmentLabel;
                    }
                    break;
                case "card2":
                    if (card.Controls["lblTotalUsersText"] is Label patientLabel)
                    {
                        yield return patientLabel;
                    }
                    break;
                case "card3":
                    if (card.Controls["lblTodayVisitsText"] is Label completedLabel)
                    {
                        yield return completedLabel;
                    }
                    break;
            }
        }

        private Color GetAccentColor(Control card)
        {
            return card.Name switch
            {
                "card1" => Card1,
                "card2" => Card2,
                "card3" => Card3,
                _ => baseColor
            };
        }

        private Control GetCardContainer(object sender)
        {
            Control c = sender as Control;

            while (c != null && !(c.Name?.StartsWith("card", StringComparison.OrdinalIgnoreCase) ?? false))
                c = c.Parent;

            return c;
        }

        private void LoadDashboardData()
        {
            try
            {
                var appts = AppointmentService.GetByDate(DateTime.Today);
                var completedToday = appts.Count(a => IsCompletedStatus(a.Status));

                lblApptCount.Text = $"{appts.Count}";
                dgvTodayAppts.DataSource = appts;
                GridViewService.ShowOnly(dgvTodayAppts, "ApptTime", "PatientName", "DoctorName", "Purpose", "Status");
                GridViewService.SetHeaders(dgvTodayAppts, new Dictionary<string, string>
                {
                    ["ApptTime"] = "Time",
                    ["PatientName"] = "Patient",
                    ["DoctorName"] = "Doctor",
                    ["Purpose"] = "Purpose",
                    ["Status"] = "Status"
                });
                GridViewService.ClearSelection(dgvTodayAppts);

                lblPatientCount.Text = $"{PatientService.GetAll().Count}";
                lblDoneCount.Text = $"{completedToday}";
            }
            catch
            {
                lblApptCount.Text = "0";
                lblPatientCount.Text = "0";
                lblDoneCount.Text = "0";
                dgvTodayAppts.DataSource = null;
            }
        }

        private static bool IsCompletedStatus(string? status)
        {
            return string.Equals(status, "Completed", StringComparison.OrdinalIgnoreCase) ||
                   string.Equals(status, "Done", StringComparison.OrdinalIgnoreCase);
        }
    }
}
    
