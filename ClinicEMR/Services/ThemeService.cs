using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ClinicEMR.Services
{
    internal static class ThemeService
    {
        public static readonly Color Primary = Color.SteelBlue;
        public static readonly Color PrimaryHover = Color.FromArgb(56, 104, 144);
        public static readonly Color PrimaryPressed = Color.FromArgb(43, 85, 122);
        public static readonly Color PageBackground = Color.FromArgb(244, 248, 251);
        public static readonly Color Surface = Color.White;
        public static readonly Color SurfaceMuted = Color.FromArgb(234, 241, 246);
        public static readonly Color SurfaceSecondary = Color.FromArgb(225, 233, 240);
        public static readonly Color Border = Color.FromArgb(205, 217, 228);
        public static readonly Color InputBorder = Color.FromArgb(135, 167, 196);
        public static readonly Color InputBorderFocus = Color.FromArgb(79, 129, 168);
        public static readonly Color TextPrimary = Color.FromArgb(34, 52, 68);
        public static readonly Color TextSecondary = Color.FromArgb(94, 114, 132);
        public static readonly Color Success = Color.FromArgb(62, 135, 119);
        public static readonly Color Danger = Color.FromArgb(198, 94, 94);
        public static readonly Color DangerHover = Color.FromArgb(176, 80, 80);

        private static readonly Font HeaderFont = new("Bahnschrift SemiBold", 12.5F, FontStyle.Regular);
        private static readonly Font TitleFont = new("Bahnschrift SemiBold", 18F, FontStyle.Regular);
        private static readonly Font BodyFont = new("Segoe UI", 8.75F, FontStyle.Regular);
        private static readonly Font BodyBoldFont = new("Segoe UI Semibold", 8.75F, FontStyle.Bold);
        private static readonly Font SmallFont = new("Segoe UI", 8.25F, FontStyle.Regular);
        private const int CornerRadius = 8;

        public static void ApplyTheme(Control root)
        {
            StyleRoot(root);
            ApplyThemeRecursive(root);
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.GridColor = Border;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersDefaultCellStyle.BackColor = SurfaceMuted;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = TextPrimary;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = SurfaceMuted;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = TextPrimary;
            grid.ColumnHeadersDefaultCellStyle.Font = BodyBoldFont;
            grid.ColumnHeadersHeight = Math.Max(grid.ColumnHeadersHeight, 40);
            grid.DefaultCellStyle.BackColor = Surface;
            grid.DefaultCellStyle.ForeColor = TextPrimary;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 229, 240);
            grid.DefaultCellStyle.SelectionForeColor = TextPrimary;
            grid.DefaultCellStyle.Font = BodyFont;
            grid.DefaultCellStyle.Padding = new Padding(4, 3, 4, 3);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 253);
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.RowTemplate.Height = Math.Max(grid.RowTemplate.Height, 30);
        }

        private static void ApplyThemeRecursive(Control parent)
        {
            Control[] children = new Control[parent.Controls.Count];
            parent.Controls.CopyTo(children, 0);

            foreach (Control child in children)
            {
                switch (child)
                {
                    case UserControl userControl:
                        StyleRoot(userControl);
                        break;
                    case Button button:
                        StyleButton(button);
                        break;
                    case TextBox textBox:
                        StyleTextBox(textBox);
                        break;
                    case ComboBox comboBox:
                        StyleComboBox(comboBox);
                        break;
                    case DateTimePicker picker:
                        StyleDateTimePicker(picker);
                        break;
                    case DataGridView grid:
                        StyleGrid(grid);
                        break;
                    case Label label:
                        StyleLabel(label);
                        break;
                    case CheckBox checkBox:
                        StyleCheckBox(checkBox);
                        break;
                    case GroupBox groupBox:
                        StyleGroupBox(groupBox);
                        break;
                    case TabControl tabControl:
                        StyleTabControl(tabControl);
                        break;
                    case TabPage tabPage:
                        StyleTabPage(tabPage);
                        break;
                    case TableLayoutPanel table:
                        StyleLayout(table);
                        break;
                    case FlowLayoutPanel flow:
                        StyleLayout(flow);
                        break;
                    case Panel panel:
                        StylePanel(panel);
                        break;
                }

                if (child.HasChildren)
                {
                    ApplyThemeRecursive(child);
                }
            }
        }

        private static void StyleRoot(Control root)
        {
            root.Font = BodyFont;
            root.ForeColor = TextPrimary;

            if (root is Form form)
            {
                form.BackColor = PageBackground;
            }
            else if (root is UserControl control)
            {
                control.BackColor = PageBackground;
            }
        }

        private static void StyleButton(Button button)
        {
            button.Font = BodyBoldFont;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;

            if (IsDangerButton(button))
            {
                button.BackColor = Danger;
                button.ForeColor = Color.White;
                button.FlatAppearance.MouseOverBackColor = DangerHover;
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 66, 66);
            }
            else if (IsSecondaryButton(button))
            {
                button.BackColor = SurfaceSecondary;
                button.ForeColor = TextPrimary;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 223, 233);
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 213, 224);
            }
            else
            {
                button.BackColor = Primary;
                button.ForeColor = Color.White;
                button.FlatAppearance.MouseOverBackColor = PrimaryHover;
                button.FlatAppearance.MouseDownBackColor = PrimaryPressed;
            }

            ApplyRoundedCorners(button, CornerRadius);
        }

        private static void StyleTextBox(TextBox textBox)
        {
            if (textBox.Parent?.Name?.EndsWith("_ThemeBorder", StringComparison.OrdinalIgnoreCase) == true)
            {
                textBox.Font = BodyFont;
                textBox.BorderStyle = BorderStyle.None;
                textBox.BackColor = Surface;
                textBox.ForeColor = TextPrimary;
                return;
            }

            textBox.Font = BodyFont;
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Surface;
            textBox.ForeColor = TextPrimary;
            WrapInputControl(textBox, InputBorder);
        }

        private static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.Font = BodyFont;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = Surface;
            comboBox.ForeColor = TextPrimary;
            ApplyRoundedCorners(comboBox, 8);
        }

        private static void StyleDateTimePicker(DateTimePicker picker)
        {
            picker.Font = BodyFont;
            picker.CalendarMonthBackground = Surface;
            picker.CalendarForeColor = TextPrimary;
            ApplyRoundedCorners(picker, 8);
        }

        private static void StyleLabel(Label label)
        {
            if (IsErrorLabel(label))
            {
                label.ForeColor = Danger;
                label.Font = SmallFont;
                return;
            }

            if (IsMetricCard(label))
            {
                label.BackColor = SurfaceMuted;
                label.ForeColor = PrimaryPressed;
                label.Font = new Font(HeaderFont.FontFamily, 9.75F, FontStyle.Bold);
                label.Padding = new Padding(10);
                label.TextAlign = ContentAlignment.MiddleLeft;
                ApplyRoundedCorners(label, 12);
                return;
            }

            if (IsMainTitle(label))
            {
                label.Font = TitleFont;
                label.ForeColor = TextPrimary;
                return;
            }

            if (IsSectionHeading(label))
            {
                label.Font = HeaderFont;
                label.ForeColor = TextPrimary;
                return;
            }

            label.Font = label.Font.Bold ? BodyBoldFont : BodyFont;
            label.ForeColor = TextSecondary;
        }

        private static void StyleCheckBox(CheckBox checkBox)
        {
            checkBox.Font = BodyFont;
            checkBox.ForeColor = TextPrimary;
            checkBox.BackColor = Color.Transparent;
        }

        private static void StyleGroupBox(GroupBox groupBox)
        {
            groupBox.Font = BodyBoldFont;
            groupBox.ForeColor = TextPrimary;
            groupBox.BackColor = Surface;
        }

        private static void StyleTabControl(TabControl tabControl)
        {
            tabControl.Font = BodyBoldFont;
        }

        private static void StyleTabPage(TabPage tabPage)
        {
            tabPage.BackColor = PageBackground;
            tabPage.ForeColor = TextPrimary;
        }

        private static void StylePanel(Panel panel)
        {
            if (IsSidebarSurface(panel))
            {
                return;
            }

            if (panel.Name == "pnlContent")
            {
                panel.BackColor = PageBackground;
                return;
            }

            panel.BackColor = panel.Parent is Form || panel.Parent is UserControl
                ? PageBackground
                : Surface;
        }

        private static void StyleLayout(Control layout)
        {
            if (IsSidebarSurface(layout))
            {
                return;
            }

            if (layout.Name == "tblBackground")
            {
                layout.BackColor = PageBackground;
                return;
            }

            layout.BackColor = layout.Parent is Form || layout.Parent is UserControl
                ? PageBackground
                : Surface;
        }

        private static bool IsSidebarSurface(Control control)
            => control.Name is "pnlSidebar" or "tblFooter" or "pnlSide";

        private static bool IsErrorLabel(Label label)
            => label.Name.Contains("Error", StringComparison.OrdinalIgnoreCase) || label.ForeColor == Color.Red;

        private static bool IsMainTitle(Label label)
            => label.Name.Contains("Clinic", StringComparison.OrdinalIgnoreCase) || label.Font.Size >= 18F;

        private static bool IsSectionHeading(Label label)
            => label.Name.Contains("Welcome", StringComparison.OrdinalIgnoreCase)
            || label.Name.Contains("Recent", StringComparison.OrdinalIgnoreCase)
            || label.Font.Size >= 11F
            || label.Font.Bold;

        private static bool IsMetricCard(Label label)
            => !label.AutoSize && label.Height >= 70 && label.Width >= 90;

        private static bool IsDangerButton(Button button)
        {
            var identity = $"{button.Name} {button.Text}".ToLowerInvariant();
            return identity.Contains("logout")
                || identity.Contains("log out")
                || identity.Contains("delete")
                || identity.Contains("remove");
        }

        private static bool IsSecondaryButton(Button button)
        {
            var identity = $"{button.Name} {button.Text}".ToLowerInvariant();
            return identity.Contains("cancel")
                || identity.Contains("close")
                || identity.Contains("back");
        }

        private static void WrapInputControl(TextBox textBox, Color borderColor)
        {
            if (textBox.Parent == null)
            {
                return;
            }

            Control parent = textBox.Parent;
            int controlIndex = parent.Controls.GetChildIndex(textBox);
            var originalDock = textBox.Dock;
            var originalLocation = textBox.Location;
            var originalSize = textBox.Size;
            var originalAnchor = textBox.Anchor;
            var originalMargin = textBox.Margin;
            int tabIndex = textBox.TabIndex;

            TableLayoutPanelCellPosition? cellPosition = null;
            int rowSpan = 1;
            int columnSpan = 1;

            if (parent is TableLayoutPanel table)
            {
                cellPosition = table.GetPositionFromControl(textBox);
                rowSpan = table.GetRowSpan(textBox);
                columnSpan = table.GetColumnSpan(textBox);
            }

            parent.Controls.Remove(textBox);

            var borderPanel = new Panel
            {
                Name = $"{textBox.Name}_ThemeBorder",
                BackColor = borderColor,
                Margin = originalMargin,
                Padding = new Padding(1),
                TabStop = false
            };

            if (originalDock != DockStyle.None)
            {
                borderPanel.Dock = originalDock;
            }
            else
            {
                borderPanel.Location = originalLocation;
                borderPanel.Size = originalSize;
                borderPanel.Anchor = originalAnchor;
            }

            if (parent is TableLayoutPanel layout && cellPosition.HasValue)
            {
                layout.Controls.Add(borderPanel, cellPosition.Value.Column, cellPosition.Value.Row);
                layout.SetRowSpan(borderPanel, rowSpan);
                layout.SetColumnSpan(borderPanel, columnSpan);
            }
            else
            {
                parent.Controls.Add(borderPanel);
                parent.Controls.SetChildIndex(borderPanel, controlIndex);
            }

            borderPanel.TabIndex = tabIndex;
            if (originalDock == DockStyle.None)
            {
                borderPanel.Size = originalSize;
            }

            textBox.Parent = borderPanel;
            textBox.Dock = DockStyle.Fill;
            textBox.Margin = textBox.Multiline ? new Padding(8, 6, 8, 6) : new Padding(8, 5, 8, 5);

            borderPanel.Enter += (_, _) => borderPanel.BackColor = InputBorderFocus;
            borderPanel.Leave += (_, _) => borderPanel.BackColor = borderColor;
            textBox.Enter += (_, _) => borderPanel.BackColor = InputBorderFocus;
            textBox.Leave += (_, _) => borderPanel.BackColor = borderColor;

            ApplyRoundedCorners(borderPanel, 8);
        }

        private static void ApplyRoundedCorners(Control control, int radius)
        {
            void ApplyRegion()
            {
                if (control.Width <= 0 || control.Height <= 0)
                {
                    return;
                }

                using var path = CreateRoundedRectanglePath(new Rectangle(0, 0, control.Width, control.Height), radius);
                control.Region = new Region(path);
            }

            ApplyRegion();
            control.Resize -= Control_ResizeApplyRoundedCorners;
            control.Resize += Control_ResizeApplyRoundedCorners;

            void Control_ResizeApplyRoundedCorners(object? sender, EventArgs e) => ApplyRegion();
        }

        private static GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
