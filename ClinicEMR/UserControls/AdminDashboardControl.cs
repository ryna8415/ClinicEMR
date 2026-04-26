using ClinicEMR.Helpers;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class AdminDashboardControl : UserControl
    {
        private readonly Color Card1 = Color.FromArgb(92, 143, 204);
        private readonly Color Card2 = Color.FromArgb(91, 33, 182);
        private readonly Color Card3 = Color.FromArgb(74, 168, 122);
        private readonly Color baseColor = UITheme.BlueSlate;
        private readonly User _user;

        public AdminDashboardControl(User user)
        {

            InitializeComponent();
            _user = user;
            tblCards.Tag = ThemeService.SkipThemeTag;
            GridViewService.MakeReadOnly(dgvRecentLogins);
            ThemeService.ApplyRoundedCorners(card1, 10);
            ThemeService.ApplyRoundedCorners(card2, 10);
            ThemeService.ApplyRoundedCorners(card3, 10);
            ThemeService.ApplyRoundedCorners(tblLayout, 10);
            ThemeService.TryRoundGrid(dgvRecentLogins, 4);

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


        private void AdminDashboardControl_Load(object sender, EventArgs e)
        {
            ApplyHover(card1);
            ApplyHover(card2);
            ApplyHover(card3);
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                lblTotalPatientsCount.Text = $"{PatientService.GetAll().Count}";
                lblTotalUsersCount.Text = $"{UserService.GetAll().Count}";
                lblTodayVisitsCount.Text = $"{ReportService.GetDailyVisitCount(DateTime.Today)}";
                label1.Text = "Audit Logs";
                dgvRecentLogins.DataSource = AuditLogService.GetRecentLogs();
                GridViewService.ShowOnly(dgvRecentLogins, "User", "Action", "Timestamp");
                GridViewService.ClearSelection(dgvRecentLogins);
            }
            catch
            {
                lblTotalPatientsText.Text = "Stats unavailable";
                lblTotalUsersText.Text = "Stats unavailable";
                lblTodayVisitsText.Text = "Stats unavailable";
                lblTotalPatientsCount.Text = "0";
                lblTotalUsersCount.Text = "0";
                lblTodayVisitsCount.Text = "0";
                dgvRecentLogins.DataSource = null;
            }
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
                    if (card.Controls["lblTotalPatientsText"] is Label totalPatientsLabel)
                    {
                        yield return totalPatientsLabel;
                    }
                    break;
                case "card2":
                    if (card.Controls["lblTotalUsersText"] is Label totalUsersLabel)
                    {
                        yield return totalUsersLabel;
                    }
                    break;
                case "card3":
                    if (card.Controls["lblTodayVisitsText"] is Label todayVisitsLabel)
                    {
                        yield return todayVisitsLabel;
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

    }

}
