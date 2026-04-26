using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ClinicEMR
{
    public class RoundedTextBox : Panel
    {
        private RichTextBox _textBox;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Text
        {
            get => _isPassword ? _realPassword : _textBox.Text;
            set
            {
                if (_isPassword)
                {
                    _realPassword = value;
                    _textBox.Text = new string('●', value.Length);
                }
                else
                {
                    _textBox.Text = value;
                }
            }
        }

        private bool _isPassword = false;
        private string _realPassword = "";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool UseSystemPasswordChar
        {
            get => _isPassword;
            set
            {
                _isPassword = value;
                if (value)
                {
                    _textBox.KeyDown += txtPassword_KeyDown;
                    _textBox.KeyPress += txtPassword_KeyPress;
                }
            }
        }

        private void txtPassword_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!_isPassword) return;

            e.Handled = true;

            if (e.KeyChar == (char)Keys.Back) return;

            int pos = _textBox.SelectionStart;
            _realPassword = _realPassword.Insert(pos, e.KeyChar.ToString());

            _textBox.TextChanged -= _textBox_TextChanged;
            _textBox.Text = new string('●', _realPassword.Length);
            _textBox.SelectionStart = pos + 1;
            _textBox.TextChanged += _textBox_TextChanged;
        }

        private void txtPassword_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!_isPassword) return;

            if (e.KeyCode == Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (_realPassword.Length == 0) return;

                // Just always remove the last character
                _realPassword = _realPassword[..^1];

                _textBox.TextChanged -= _textBox_TextChanged;
                _textBox.Text = new string('●', _realPassword.Length);
                _textBox.SelectionStart = _textBox.Text.Length;
                _textBox.TextChanged += _textBox_TextChanged;
            }
        }

        private void _textBox_TextChanged(object? sender, EventArgs e)
        {
            OnTextChanged(e);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius { get; set; } = 8;

        public RoundedTextBox()
        {
            this.Height = 34;
            this.Padding = new Padding(8, 0, 8, 0);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.None;

            _textBox = new RichTextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Color.White,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 10),
                Multiline = false,
                ScrollBars = RichTextBoxScrollBars.None,  // kills the artifacts
                WordWrap = false,
                Dock = DockStyle.None,
            };

            this.Controls.Add(_textBox);
            _textBox.TextChanged += _textBox_TextChanged;
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            if (_textBox == null) return;
            _textBox.Width = this.Width - 16;
            _textBox.Height = this.Height - 8;
            _textBox.Location = new Point(8, (this.Height - _textBox.Height) / 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.Parent?.BackColor ?? Color.FromArgb(226, 230, 237));

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using var path = GetRoundedPath(rect, CornerRadius);
            using var fill = new SolidBrush(Color.White);
            using var border = new Pen(Color.FromArgb(180, 180, 180), 1.5f);

            e.Graphics.FillPath(fill, path);
            e.Graphics.DrawPath(border, path);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Intentionally empty — OnPaint handles everything including background
        }

        private GraphicsPath GetRoundedPath(Rectangle b, int r)
        {
            var path = new GraphicsPath();
            int d = r * 2;
            path.AddArc(b.X, b.Y, d, d, 180, 90);
            path.AddArc(b.Right - d, b.Y, d, d, 270, 90);
            path.AddArc(b.Right - d, b.Bottom - d, d, d, 0, 90);
            path.AddArc(b.X, b.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}