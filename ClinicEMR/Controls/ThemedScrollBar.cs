using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicEMR.Controls
{
    internal sealed class ThemedScrollBar : Control
    {
        private const int MinimumThumbSize = 24;
        private int _minimum;
        private int _maximum;
        private int _value;
        private int _largeChange = 1;
        private bool _dragging;
        private int _dragOffset;
        private bool _thumbHovered;
        private Orientation orientation = Orientation.Vertical;

        public ThemedScrollBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            BackColor = Color.FromArgb(37, 45, 56);
            Width = 12;
            Height = 12;
        }

        public event EventHandler? ValueChanged;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Orientation Orientation { get => orientation; set => orientation = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Minimum
        {
            get => _minimum;
            set
            {
                _minimum = value;
                Maximum = Math.Max(_maximum, _minimum);
                Value = Math.Max(_value, _minimum);
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Maximum
        {
            get => _maximum;
            set
            {
                _maximum = Math.Max(_minimum, value);
                Value = Math.Min(_value, _maximum);
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int LargeChange
        {
            get => _largeChange;
            set
            {
                _largeChange = Math.Max(1, value);
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Value
        {
            get => _value;
            set
            {
                int clamped = Math.Max(_minimum, Math.Min(value, _maximum));
                if (_value == clamped)
                {
                    return;
                }

                _value = clamped;
                Invalidate();
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TrackColor { get; set; } = Color.FromArgb(37, 45, 56);

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ThumbColor { get; set; } = Color.FromArgb(58, 67, 94);

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ThumbHoverColor { get; set; } = Color.FromArgb(69, 85, 97);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(TrackColor);

            Rectangle thumb = GetThumbBounds();
            if (thumb.Width <= 0 || thumb.Height <= 0)
            {
                return;
            }

            using SolidBrush brush = new(_thumbHovered || _dragging ? ThumbHoverColor : ThumbColor);
            e.Graphics.FillRectangle(brush, thumb);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            Rectangle thumb = GetThumbBounds();
            if (thumb.Contains(e.Location))
            {
                _dragging = true;
                _dragOffset = Orientation == Orientation.Vertical
                    ? e.Y - thumb.Top
                    : e.X - thumb.Left;
                Capture = true;
                return;
            }

            if (Orientation == Orientation.Vertical)
            {
                Value += e.Y < thumb.Top ? -LargeChange : LargeChange;
            }
            else
            {
                Value += e.X < thumb.Left ? -LargeChange : LargeChange;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            Rectangle thumb = GetThumbBounds();
            _thumbHovered = thumb.Contains(e.Location);

            if (_dragging)
            {
                UpdateValueFromPointer(e.Location);
            }

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _dragging = false;
            Capture = false;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (_dragging)
            {
                return;
            }

            _thumbHovered = false;
            Invalidate();
        }

        private void UpdateValueFromPointer(Point location)
        {
            Rectangle thumb = GetThumbBounds();
            int trackLength = Orientation == Orientation.Vertical ? Height : Width;
            int thumbLength = Orientation == Orientation.Vertical ? thumb.Height : thumb.Width;
            int travel = Math.Max(1, trackLength - thumbLength);
            int position = Orientation == Orientation.Vertical
                ? location.Y - _dragOffset
                : location.X - _dragOffset;

            position = Math.Max(0, Math.Min(position, travel));

            if (_maximum == _minimum)
            {
                Value = _minimum;
                return;
            }

            double ratio = (double)position / travel;
            Value = _minimum + (int)Math.Round(ratio * (_maximum - _minimum));
        }

        private Rectangle GetThumbBounds()
        {
            int trackLength = Orientation == Orientation.Vertical ? Height : Width;
            int thickness = Orientation == Orientation.Vertical ? Width : Height;
            if (trackLength <= 0 || thickness <= 0)
            {
                return Rectangle.Empty;
            }

            if (_maximum <= _minimum)
            {
                return Orientation == Orientation.Vertical
                    ? new Rectangle(0, 0, Width, Height)
                    : new Rectangle(0, 0, Width, Height);
            }

            int thumbLength = Math.Max(MinimumThumbSize, (int)Math.Round((double)trackLength * _largeChange / (_maximum - _minimum + _largeChange)));
            thumbLength = Math.Min(trackLength, thumbLength);

            int travel = Math.Max(0, trackLength - thumbLength);
            int offset = _maximum == _minimum
                ? 0
                : (int)Math.Round((double)(_value - _minimum) / (_maximum - _minimum) * travel);

            return Orientation == Orientation.Vertical
                ? new Rectangle(0, offset, thickness, thumbLength)
                : new Rectangle(offset, 0, thumbLength, thickness);
        }
    }
}
