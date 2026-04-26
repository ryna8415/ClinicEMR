using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;


namespace ClinicEMR.UserControls

{
    public partial class PatientListControl : UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientListControl));
            tblLayout = new TableLayoutPanel();
            dgvPatients = new DataGridView();
            tblHeader = new TableLayoutPanel();
            btnSearch = new ReaLTaiizor.Controls.Button();
            txtSearch = new ReaLTaiizor.Controls.HopeTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new ReaLTaiizor.Controls.Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnOpen = new ReaLTaiizor.Controls.Button();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            tblHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.BackColor = Color.FromArgb(226, 230, 237);
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvPatients, 0, 3);
            tblLayout.Controls.Add(tblHeader, 0, 2);
            tblLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            tblLayout.Controls.Add(tableLayoutPanel2, 0, 4);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(23, 27, 23, 27);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 4;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayout.Size = new Size(854, 697);
            tblLayout.TabIndex = 4;
            // 
            // dgvPatients
            // 
            dgvPatients.BackgroundColor = Color.FromArgb(108, 111, 127);
            dgvPatients.BorderStyle = BorderStyle.None;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.Location = new Point(23, 126);
            dgvPatients.Margin = new Padding(23, 4, 23, 4);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(808, 448);
            dgvPatients.TabIndex = 7;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 3;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tblHeader.Controls.Add(btnAdd, 2, 0);
            tblHeader.Controls.Add(btnSearch, 1, 0);
            tblHeader.Controls.Add(txtSearch, 0, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(23, 73);
            tblHeader.Margin = new Padding(23, 4, 23, 4);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 1;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tblHeader.Size = new Size(808, 45);
            tblHeader.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(226, 230, 237);
            btnSearch.BorderColor = Color.FromArgb(37, 45, 56);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.EnteredBorderColor = Color.FromArgb(37, 45, 56);
            btnSearch.EnteredColor = Color.FromArgb(37, 45, 56);
            btnSearch.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleCenter;
            btnSearch.InactiveColor = Color.FromArgb(37, 45, 56);
            btnSearch.Location = new Point(647, 3);
            btnSearch.Margin = new Padding(0, 3, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.PressedBorderColor = Color.FromArgb(37, 45, 56);
            btnSearch.PressedColor = Color.FromArgb(37, 45, 56);
            btnSearch.Size = new Size(52, 37);
            btnSearch.TabIndex = 20;
            btnSearch.TextAlignment = StringAlignment.Center;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.FromArgb(37, 45, 56);
            txtSearch.BaseColor = Color.FromArgb(226, 230, 237);
            txtSearch.BorderColorA = Color.FromArgb(37, 45, 56);
            txtSearch.BorderColorB = Color.FromArgb(37, 45, 56);
            txtSearch.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            txtSearch.ForeColor = Color.FromArgb(226, 230, 237);
            txtSearch.Hint = "Search: Name/Patient Code";
            txtSearch.Location = new Point(3, 3);
            txtSearch.Margin = new Padding(3, 3, 0, 3);
            txtSearch.MaxLength = 32767;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.Size = new Size(644, 37);
            txtSearch.TabIndex = 21;
            txtSearch.TabStop = false;
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.KeyDown += txtSearch_KeyDown;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(23, 24);
            tableLayoutPanel1.Margin = new Padding(23, 4, 23, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(808, 41);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(226, 230, 237);
            btnAdd.BorderColor = Color.FromArgb(108, 111, 127);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnAdd.EnteredColor = Color.FromArgb(69, 85, 97);
            btnAdd.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnAdd.Image = null;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.InactiveColor = Color.FromArgb(26, 35, 48);
            btnAdd.Location = new Point(708, 2);
            btnAdd.Margin = new Padding(3, 2, 0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnAdd.PressedColor = Color.FromArgb(108, 111, 127);
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add New";
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.Click += btnAddNew_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(26, 35, 48);
            label1.Location = new Point(43, 5);
            label1.Name = "label1";
            label1.Size = new Size(194, 31);
            label1.TabIndex = 1;
            label1.Text = "Patient Registry";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel2.Controls.Add(btnOpen, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 581);
            tableLayoutPanel2.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(814, 113);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpen.BackColor = Color.FromArgb(226, 230, 237);
            btnOpen.BorderColor = Color.FromArgb(108, 111, 127);
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnOpen.EnteredColor = Color.FromArgb(69, 85, 97);
            btnOpen.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnOpen.Image = null;
            btnOpen.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpen.InactiveColor = Color.FromArgb(92, 102, 114);
            btnOpen.Location = new Point(711, 0);
            btnOpen.Margin = new Padding(3, 0, 3, 0);
            btnOpen.Name = "btnOpen";
            btnOpen.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnOpen.PressedColor = Color.FromArgb(108, 111, 127);
            btnOpen.Size = new Size(100, 40);
            btnOpen.TabIndex = 22;
            btnOpen.Text = "Open Info";
            btnOpen.TextAlignment = StringAlignment.Center;
            btnOpen.Click += btnOpenRecord_Click;
            // 
            // PatientListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientListControl";
            Size = new Size(854, 697);
            Load += PatientListControl_Load;
            tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            tblHeader.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);

            #endregion
        }

        private TableLayoutPanel tblLayout;
        private DataGridView dgvPatients;
        private TableLayoutPanel tblHeader;
        private ReaLTaiizor.Controls.Button btnSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private ReaLTaiizor.Controls.HopeTextBox txtSearch;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.Button btnOpen;
        private ReaLTaiizor.Controls.Button btnAdd;
    }

}
