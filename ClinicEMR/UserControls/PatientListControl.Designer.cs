using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;

namespace ClinicEMR.UserControls
{
	public partial class PatientListControl : UserControl
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientListControl));
            tblLayout = new TableLayoutPanel();
            dgvPatients = new DataGridView();
            pnlFooter = new TableLayoutPanel();
            btnOpen = new ReaLTaiizor.Controls.Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tblHeader = new TableLayoutPanel();
            txtSearch = new ReaLTaiizor.Controls.HopeTextBox();
            lblDate = new Label();
            btnSearch = new ReaLTaiizor.Controls.Button();
            btnAddNew = new ReaLTaiizor.Controls.Button();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            pnlFooter.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tblHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.BackColor = Color.FromArgb(226, 230, 237);
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvPatients, 0, 3);
            tblLayout.Controls.Add(pnlFooter, 0, 4);
            tblLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            tblLayout.Controls.Add(tblHeader, 0, 2);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(23, 27, 23, 27);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 5;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tblLayout.Size = new Size(800, 550);
            tblLayout.TabIndex = 0;
            // 
            // dgvPatients
            // 
            dgvPatients.BackgroundColor = Color.FromArgb(108, 111, 127);
            dgvPatients.BorderStyle = BorderStyle.None;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.Location = new Point(23, 123);
            dgvPatients.Margin = new Padding(23, 4, 23, 4);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 57;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(754, 329);
            dgvPatients.TabIndex = 1;
            // 
            // pnlFooter
            // 
            pnlFooter.ColumnCount = 2;
            pnlFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            pnlFooter.Controls.Add(btnOpen, 1, 0);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.Location = new Point(23, 460);
            pnlFooter.Margin = new Padding(23, 4, 23, 4);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.RowCount = 2;
            pnlFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 56.9767456F));
            pnlFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 43.0232544F));
            pnlFooter.Size = new Size(754, 86);
            pnlFooter.TabIndex = 2;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpen.BackColor = Color.FromArgb(226, 230, 237);
            btnOpen.BorderColor = Color.FromArgb(92, 102, 114);
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.EnteredBorderColor = Color.FromArgb(92, 102, 114);
            btnOpen.EnteredColor = Color.FromArgb(69, 85, 97);
            btnOpen.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnOpen.Image = null;
            btnOpen.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpen.InactiveColor = Color.FromArgb(92, 102, 114);
            btnOpen.Location = new Point(654, 3);
            btnOpen.Margin = new Padding(3, 3, 0, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.PressedBorderColor = Color.FromArgb(153, 27, 27);
            btnOpen.PressedColor = Color.FromArgb(153, 27, 27);
            btnOpen.Size = new Size(100, 40);
            btnOpen.TabIndex = 22;
            btnOpen.Text = "Open Info";
            btnOpen.TextAlignment = StringAlignment.Center;
            btnOpen.Click += btnOpenRecord_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(23, 24);
            tableLayoutPanel1.Margin = new Padding(23, 4, 23, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(754, 39);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 39);
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
            label1.Location = new Point(43, 4);
            label1.Name = "label1";
            label1.Size = new Size(233, 31);
            label1.TabIndex = 1;
            label1.Text = "Manage Patient List";
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 4;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tblHeader.Controls.Add(txtSearch, 1, 0);
            tblHeader.Controls.Add(lblDate, 0, 0);
            tblHeader.Controls.Add(btnSearch, 2, 0);
            tblHeader.Controls.Add(btnAddNew, 3, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(23, 67);
            tblHeader.Margin = new Padding(23, 0, 23, 4);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 1;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblHeader.Size = new Size(754, 48);
            tblHeader.TabIndex = 21;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.FromArgb(37, 45, 56);
            txtSearch.BaseColor = Color.FromArgb(226, 230, 237);
            txtSearch.BorderColorA = Color.FromArgb(37, 45, 56);
            txtSearch.BorderColorB = Color.FromArgb(37, 45, 56);
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("TT Interphases Pro Trl", 10F);
            txtSearch.ForeColor = Color.FromArgb(92, 102, 114);
            txtSearch.Hint = "Search by Name/PT code";
            txtSearch.Location = new Point(79, 5);
            txtSearch.Margin = new Padding(3, 3, 0, 3);
            txtSearch.MaxLength = 100;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.Size = new Size(525, 37);
            txtSearch.TabIndex = 20;
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.KeyDown += txtSearch_KeyDown;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(92, 102, 114);
            lblDate.Location = new Point(3, 13);
            lblDate.Margin = new Padding(3, 0, 0, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(72, 21);
            lblDate.TabIndex = 7;
            lblDate.Text = "Patients:";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(226, 230, 237);
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BorderColor = Color.FromArgb(37, 45, 56);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.EnteredBorderColor = Color.FromArgb(37, 45, 56);
            btnSearch.EnteredColor = Color.FromArgb(37, 45, 56);
            btnSearch.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleCenter;
            btnSearch.InactiveColor = Color.FromArgb(37, 45, 56);
            btnSearch.Location = new Point(604, 5);
            btnSearch.Margin = new Padding(0, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.PressedBorderColor = Color.FromArgb(37, 45, 56);
            btnSearch.PressedColor = Color.FromArgb(37, 45, 56);
            btnSearch.Size = new Size(43, 37);
            btnSearch.TabIndex = 2;
            btnSearch.TextAlignment = StringAlignment.Center;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Right;
            btnAddNew.BackColor = Color.FromArgb(226, 230, 237);
            btnAddNew.BorderColor = Color.FromArgb(108, 111, 127);
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnAddNew.EnteredColor = Color.FromArgb(69, 85, 97);
            btnAddNew.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnAddNew.Image = null;
            btnAddNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNew.InactiveColor = Color.FromArgb(26, 35, 48);
            btnAddNew.Location = new Point(654, 4);
            btnAddNew.Margin = new Padding(3, 4, 0, 4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnAddNew.PressedColor = Color.FromArgb(108, 111, 127);
            btnAddNew.Size = new Size(100, 40);
            btnAddNew.TabIndex = 3;
            btnAddNew.Text = "Add Patient";
            btnAddNew.TextAlignment = StringAlignment.Center;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // PatientListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "PatientListControl";
            Size = new Size(800, 550);
            Load += PatientListControl_Load;
            tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            pnlFooter.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
		private TableLayoutPanel pnlFooter;
		private DataGridView dgvPatients;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private TableLayoutPanel tblHeader;
        private ReaLTaiizor.Controls.HopeTextBox txtSearch;
        private Label lblDate;
        private ReaLTaiizor.Controls.Button btnSearch;
        private ReaLTaiizor.Controls.Button btnAddNew;
        private ReaLTaiizor.Controls.Button btnOpen;
    }
}
