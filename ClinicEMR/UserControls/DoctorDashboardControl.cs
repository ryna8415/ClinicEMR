using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicEMR.Helpers;
using ClinicEMR.Models;
using ClinicEMR.Services;

namespace ClinicEMR.UserControls
{
    public partial class DoctorDashboardControl : UserControl
    {
        private readonly Color Card1 = Color.FromArgb(92, 143, 204);
        private readonly Color Card2 = Color.FromArgb(74, 168, 122);
        private readonly Color Card3 = Color.FromArgb(146, 64, 14);
        private readonly Color baseColor = UITheme.BlueSlate;
        private readonly User _user;

        public DoctorDashboardControl(User user)
        {
            InitializeComponent();
            _user = user;
            GridViewService.MakeReadOnly(dgvMyAppts);
            ThemeService.ApplyRoundedCorners(card1, 10);
            ThemeService.ApplyRoundedCorners(card2, 10);
            ThemeService.ApplyRoundedCorners(card3, 10);
            ThemeService.ApplyRoundedCorners(tblLayout, 10);
            ThemeService.TryRoundGrid(dgvMyAppts, 4);
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

        private void DoctorDashboardControl_Load(object sender, EventArgs e)
        {
            ApplyHover(card1);
            ApplyHover(card2);
            ApplyHover(card3);

            var appts = AppointmentService.GetByDateAndDoctor(DateTime.Today, _user.UserId);
            var completedToday = appts.Count(a =>
                string.Equals(a.Status, "Completed", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(a.Status, "Done", StringComparison.OrdinalIgnoreCase));
            var pendingToday = appts.Count(a => string.Equals(a.Status, "Scheduled", StringComparison.OrdinalIgnoreCase));

            lblMyPatients.Text = $"{appts.Count}\r\npatients scheduled\r\ntoday";
            lblDoneToday.Text = $"{completedToday}\r\ncompleted\r\nappointments";
            lblPendingToday.Text = $"{pendingToday}\r\npending\r\nappointments";

            dgvMyAppts.DataSource = appts;
            GridViewService.ShowOnly(dgvMyAppts, "ApptTime", "PatientName", "Purpose", "Status");
            GridViewService.SetHeaders(dgvMyAppts, new Dictionary<string, string>
            {
                ["ApptTime"] = "Time",
                ["PatientName"] = "Patient",
                ["Purpose"] = "Purpose",
                ["Status"] = "Status"
            });
            GridViewService.ClearSelection(dgvMyAppts);

            // Lock yesterday's consultations every time doctor logs in
            // Week 2: uncomment when ConsultService exists
            ConsultService.LockPastConsultations(_user.UserId);

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
                    if (card.Controls["lblMyPatientsText"] is Label myPatientsLabel)
                    {
                        yield return myPatientsLabel;
                    }
                    break;
                case "card2":
                    if (card.Controls["lblDonTodayText"] is Label doneTodayLabel)
                    {
                        yield return doneTodayLabel;
                    }
                    break;
                case "card3":
                    if (card.Controls["lblPendingTodayText"] is Label pendingTodayLabel)
                    {
                        yield return pendingTodayLabel;
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
            {
                c = c.Parent;
            }

            return c;
        }
    }
}
