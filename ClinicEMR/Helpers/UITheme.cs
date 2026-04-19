using System.Drawing;
using System.Windows.Forms;

namespace ClinicEMR.Helpers
{
    public static class UITheme
    {
        public static Font FontTitle = new("Segoe UI", 14f, FontStyle.Bold);
        public static Font FontHeading = new("Segoe UI Semibold", 11f);
        public static Font FontBody = new("Segoe UI", 9.5f);
        public static Font FontSmall = new("Segoe UI", 8.5f);
        public static Font FontGridHdr = new("Segoe UI", 9f, FontStyle.Bold);
        public static Font FontGrid = new("Segoe UI", 9f);
        public static Font FontCode = new("Consolas", 9f);

        public static Color CharcoalBlue = Color.FromArgb(49, 62, 80);
        public static Color TwilightIndigo = Color.FromArgb(58, 67, 94);
        public static Color CharcoalBlue2 = Color.FromArgb(69, 85, 97);
        public static Color BlueSlate = Color.FromArgb(92, 102, 114);
        public static Color SlateGrey = Color.FromArgb(108, 111, 127);

        public static Color BgDeep = Color.FromArgb(26, 35, 48);
        public static Color BgCard = Color.FromArgb(37, 45, 56);
        public static Color Card = Color.FromArgb(37, 45, 56);
        public static Color SidebarBorder = Color.FromArgb(49, 62, 80);
        public static Color SidebarActive = Color.FromArgb(58, 67, 94);
        public static Color SidebarHover = Color.FromArgb(69, 85, 97);
        public static Color SidebarText = Color.FromArgb(108, 111, 127);
        public static Color NavIndicator = Color.FromArgb(92, 143, 204);

        public static Color TextPrimary = Color.FromArgb(226, 230, 237);
        public static Color TextBody = Color.FromArgb(197, 202, 212);
        public static Color TextMuted = Color.FromArgb(108, 111, 127);
        public static Color TextCode = Color.FromArgb(92, 143, 204);

        public static Color RoleAccent = Color.FromArgb(92, 143, 204);
        public static Color AccentNurse = Color.FromArgb(92, 143, 204);
        public static Color AccentDoctor = Color.FromArgb(74, 168, 122);
        public static Color AccentAdmin = Color.FromArgb(155, 127, 232);

        public static Color StatusScheduled = Color.FromArgb(92, 143, 204);
        public static Color StatusDone = Color.FromArgb(74, 168, 122);
        public static Color StatusCancelled = Color.FromArgb(239, 68, 68);
        public static Color StatusNoShow = Color.FromArgb(251, 191, 36);
        public static Color AllergyRed = Color.FromArgb(239, 68, 68);
        public static Color AllergyRedBg = Color.FromArgb(60, 20, 20);

        public static Color GridHeaderBg = Color.FromArgb(49, 62, 80);
        public static Color GridHeaderText = Color.FromArgb(156, 163, 175);
        public static Color GridRowOdd = Color.FromArgb(37, 45, 56);
        public static Color GridRowEven = Color.FromArgb(30, 38, 50);
        public static Color GridRowHover = Color.FromArgb(49, 62, 80);
        public static Color GridRowSelect = Color.FromArgb(58, 67, 94);
        public static Color GridBorder = Color.FromArgb(49, 62, 80);

        public static void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = BgCard;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = GridBorder;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Font = FontGrid;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = GridHeaderBg;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = GridHeaderText;
            dgv.ColumnHeadersDefaultCellStyle.Font = FontGridHdr;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgv.DefaultCellStyle.BackColor = GridRowOdd;
            dgv.DefaultCellStyle.ForeColor = TextBody;
            dgv.DefaultCellStyle.SelectionBackColor = GridRowSelect;
            dgv.DefaultCellStyle.SelectionForeColor = TextPrimary;
            dgv.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            dgv.RowTemplate.Height = 36;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = GridRowEven;
        }
    }
}
