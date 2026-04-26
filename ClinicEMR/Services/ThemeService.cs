using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ClinicEMR.Helpers;
using RealButton = ReaLTaiizor.Controls.Button;

namespace ClinicEMR.Services
{
    internal static class ThemeService
    {
        internal const string SidebarButtonTag = "sidebar-nav";
        internal const string ActiveSidebarButtonTag = "sidebar-nav-active";
        internal const string SkipThemeTag = "skip-theme";

        internal static class Palette
        {
            public static readonly Color AppBackground = UITheme.BgDeep;
            public static readonly Color Surface = UITheme.BgCard;
            public static readonly Color SurfaceAlt = UITheme.CharcoalBlue;

            public static readonly Color Primary = UITheme.CharcoalBlue;
            public static readonly Color PrimaryHover = UITheme.SidebarHover;
            public static readonly Color PrimaryActive = UITheme.SidebarActive;
            public static readonly Color Accent = UITheme.RoleAccent;

            public static readonly Color Text = UITheme.TextPrimary;
            public static readonly Color TextMuted = UITheme.TextMuted;
            public static readonly Color TextOnPrimary = UITheme.TextPrimary;

            public static readonly Color Border = UITheme.SidebarBorder;
            public static readonly Color Error = UITheme.StatusCancelled;
            public static readonly Color Success = UITheme.StatusDone;
        }

        internal static class Spacing
        {
            public const int XS = 4;
            public const int SM = 8;
            public const int MD = 12;
            public const int LG = 16;
            public const int XL = 24;
        }

        internal static class Sizes
        {
            public const int ButtonHeight = 36;
            public const int InputHeight = 34;
            public const int CornerRadius = 10;
            public const int SmallCornerRadius = 8;
        }

        public static void ApplyTheme(Control root)
        {
            if (root == null)
                return;

            if (root is Form form)
            {
                form.ForeColor = Palette.Text;
                form.Font = UITheme.FontBody;
            }

            ApplyThemeRecursive(root);
        }

        public static void StyleSidebarButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = UITheme.SidebarHover;
            button.FlatAppearance.MouseDownBackColor = UITheme.SidebarActive;
            button.BackColor = Color.Transparent;
            button.ForeColor = UITheme.SidebarText;
            button.Height = Sizes.ButtonHeight;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.UseVisualStyleBackColor = false;
            button.Tag = SidebarButtonTag;
        }


        public static void StyleInput(Control control)
        {
            if (control is TextBox textBox)
                textBox.BorderStyle = BorderStyle.FixedSingle;

            if (control is ComboBox comboBox)
                comboBox.FlatStyle = FlatStyle.Flat;
        }


        public static void StyleGrid(DataGridView grid)
        {
            UITheme.StyleGrid(grid);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = UITheme.GridHeaderBg;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = UITheme.GridHeaderText;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.Cursor = Cursors.Hand;
        }

        public static void TryRound(Control control, int radius)
        {
            void ApplyRoundedRegion()
            {
                if (control.Width <= 0 || control.Height <= 0)
                    return;

                using GraphicsPath path = BuildRoundedPath(control.ClientRectangle, radius);
                control.Region = new Region(path);
            }

            control.HandleCreated += (_, _) => ApplyRoundedRegion();
            control.SizeChanged += (_, _) => ApplyRoundedRegion();
        }

        private static void ApplyThemeRecursive(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (Equals(control.Tag, SkipThemeTag))
                    continue;

                switch (control)
                {
                    case TextBox:
                    case ComboBox:
                    case RichTextBox:
                    case DateTimePicker:
                        StyleInput(control);
                        break;
                    case DataGridView grid:
                        StyleGrid(grid);
                        break;
                }

                if (control.HasChildren)
                    ApplyThemeRecursive(control);
            }
        }

        private static void AttachButtonHover(Button button, Color normal, Color hover)
        {
            button.MouseEnter += (_, _) =>
            {
                if (Equals(button.Tag, ActiveSidebarButtonTag))
                    return;

                if (Equals(button.Tag, SidebarButtonTag))
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = UITheme.SidebarHover;
                    return;
                }

                button.BackColor = hover;
            };

            button.MouseLeave += (_, _) =>
            {
                if (Equals(button.Tag, ActiveSidebarButtonTag))
                    return;

                if (Equals(button.Tag, SidebarButtonTag))
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = Color.Transparent;
                    TryRound(button, Sizes.SmallCornerRadius);
                    return;
                }

                button.BackColor = normal;
            };
        }

        private static GraphicsPath BuildRoundedPath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new();

            if (bounds.Width <= 0 || bounds.Height <= 0)
                return path;

            Rectangle safeBounds = new(
                bounds.X,
                bounds.Y,
                Math.Max(1, bounds.Width - 1),
                Math.Max(1, bounds.Height - 1));

            int maxRadius = Math.Min(safeBounds.Width, safeBounds.Height) / 2;
            radius = Math.Max(0, Math.Min(radius, maxRadius));

            if (radius <= 1)
            {
                path.AddRectangle(safeBounds);
                path.CloseFigure();
                return path;
            }

            int diameter = radius * 2;
            Rectangle arc = new(safeBounds.Location, new Size(diameter, diameter));

            // Top-left
            path.AddArc(arc, 180, 90);

            // Top-right
            arc.X = safeBounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom-right
            arc.Y = safeBounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom-left
            arc.X = safeBounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public static void ApplyRoundedCorners(TableLayoutPanel panel, int radius)
        {
            void ApplyRounded()
            {
                if (panel.Width <= 0 || panel.Height <= 0)
                    return;

                using GraphicsPath path = BuildRoundedPath(panel.ClientRectangle, radius);
                panel.Region = new Region(path);
            }

            panel.HandleCreated += (_, _) => ApplyRounded();
            panel.SizeChanged += (_, _) => ApplyRounded();
            ApplyRounded();
        }

        public static void TryRoundGrid(DataGridView grid, int radius)
        {
            void ApplyRounded()
            {
                if (grid.Width <= 0 || grid.Height <= 0)
                    return;

                using GraphicsPath path = BuildRoundedPath(grid.ClientRectangle, radius);
                grid.Region = new Region(path);
            }

            grid.HandleCreated += (_, _) => ApplyRounded();
            grid.SizeChanged += (_, _) => ApplyRounded();
        }

    }
}
