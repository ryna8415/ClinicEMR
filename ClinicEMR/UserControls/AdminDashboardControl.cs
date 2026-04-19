using ClinicEMR.Helpers;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;

namespace ClinicEMR.UserControls
{
    public partial class AdminDashboardControl : UserControl
    {
        private readonly Color hoverColor = UITheme.CharcoalBlue;
        private readonly Color baseColor = UITheme.Card;
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
            try
            {
                lblTotalPatientsCount.Text = $"{PatientService.GetAll().Count}";
                lblTotalUsersCount.Text = $"{UserService.GetAll().Count}";
                lblTodayVisitsCount.Text = $"{ReportService.GetDailyVisitCount(DateTime.Today)}";

                dgvRecentLogins.DataSource = UserService.GetRecentLogins();
                GridViewService.ShowOnly(dgvRecentLogins, "Full Name", "Role", "Last Login");
                GridViewService.ClearSelection(dgvRecentLogins);
            }
            catch
            {
                lblTotalPatientsText.Text = "Stats unavailable";
                lblTotalUsersText.Text = "Stats unavailable";
                lblTodayVisitsText.Text = "Stats unavailable";
                dgvRecentLogins.DataSource = null;
            }
        }
        private void Card_MouseEnter(object sender, EventArgs e)
        {
            Panel p = GetCardPanel(sender);

            if (p.Tag as string != "hover")
            {
                p.BackColor = hoverColor;

                p.Top -= 2;
                p.Tag = "hover";
            }
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Panel p = GetCardPanel(sender);

            if (p.Tag as string == "hover")
            {
                p.BackColor = baseColor;

                p.Top += 2;
                p.Tag = null;
            }
        }
        private Panel GetCardPanel(object sender)
        {
            Control c = sender as Control;

            while (c != null && !(c is Panel))
                c = c.Parent;

            return c as Panel;
        }

    }

}
