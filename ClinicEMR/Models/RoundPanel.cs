using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ClinicEMR
{
    public class RoundedPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius { get; set; } = 8;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var path = GetRoundedRect(this.ClientRectangle, CornerRadius);
            using var brush = new SolidBrush(this.BackColor);
            e.Graphics.FillPath(brush, path);
        }

        protected override void OnPaintBackground(PaintEventArgs e) { }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            using var path = GetRoundedRect(this.ClientRectangle, CornerRadius);
            this.Region = new Region(path);
        }

        private GraphicsPath GetRoundedRect(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 4;
            path.AddArc(bounds.X, bounds.Y, d, d, 175, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 260, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}