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
			tblLayout = new TableLayoutPanel();
			tblHeader = new TableLayoutPanel();
			lblTitle = new Label();
			txtSearch = new TextBox();
			btnSearch = new ReaLTaiizor.Controls.Button();
			btnAddNew = new ReaLTaiizor.Controls.Button();
			dgvPatients = new DataGridView();
			pnlFooter = new TableLayoutPanel();
			btnOpen = new ReaLTaiizor.Controls.Button();
			tblLayout.SuspendLayout();
			tblHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
			pnlFooter.SuspendLayout();
			SuspendLayout();
			// 
			// tblLayout
			// 
			tblLayout.BackColor = Color.FromArgb(226, 230, 237);
			tblLayout.ColumnCount = 1;
			tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tblLayout.Controls.Add(tblHeader, 0, 0);
			tblLayout.Controls.Add(dgvPatients, 0, 1);
			tblLayout.Controls.Add(pnlFooter, 0, 2);
			tblLayout.Dock = DockStyle.Fill;
			tblLayout.Location = new Point(0, 0);
			tblLayout.Name = "tblLayout";
			tblLayout.RowCount = 3;
			tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
			tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			tblLayout.Size = new Size(800, 550);
			tblLayout.TabIndex = 0;
			// 
			// tblHeader
			// 
			tblHeader.ColumnCount = 4;
			tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
			tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
			tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
			tblHeader.Controls.Add(lblTitle, 0, 0);
			tblHeader.Controls.Add(txtSearch, 1, 0);
			tblHeader.Controls.Add(btnSearch, 2, 0);
			tblHeader.Controls.Add(btnAddNew, 3, 0);
			tblHeader.Dock = DockStyle.Fill;
			tblHeader.Location = new Point(20, 10);
			tblHeader.Margin = new Padding(20, 10, 20, 0);
			tblHeader.Name = "tblHeader";
			tblHeader.RowCount = 1;
			tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tblHeader.Size = new Size(760, 75);
			tblHeader.TabIndex = 0;
			// 
			// lblTitle
			// 
			lblTitle.Anchor = AnchorStyles.Left;
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
			lblTitle.ForeColor = Color.FromArgb(26, 35, 48);
			lblTitle.Location = new Point(3, 21);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(126, 32);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Patients";
			// 
			// txtSearch
			// 
			txtSearch.Anchor = AnchorStyles.Right;
			txtSearch.BorderStyle = BorderStyle.FixedSingle;
			txtSearch.Font = new Font("Segoe UI", 11F);
			txtSearch.Location = new Point(247, 20);
			txtSearch.Name = "txtSearch";
			txtSearch.PlaceholderText = "Search Name/ID...";
			txtSearch.Size = new Size(240, 35);
			txtSearch.TabIndex = 1;
			// 
			// btnSearch
			// 
			btnSearch.Anchor = AnchorStyles.Right;
			btnSearch.BackColor = Color.Transparent;
			btnSearch.BorderColor = Color.FromArgb(108, 111, 127);
			btnSearch.Cursor = Cursors.Hand;
			btnSearch.EnteredBorderColor = Color.FromArgb(108, 111, 127);
			btnSearch.EnteredColor = Color.FromArgb(200, 205, 215);
			btnSearch.Font = new Font("Microsoft Sans Serif", 10F);
			btnSearch.ForeColor = Color.FromArgb(26, 35, 48); // Dark text for light button
			btnSearch.Image = null;
			btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
			btnSearch.InactiveColor = Color.FromArgb(226, 230, 237);
			btnSearch.Location = new Point(497, 11);
			btnSearch.Name = "btnSearch";
			btnSearch.PressedBorderColor = Color.FromArgb(108, 111, 127);
			btnSearch.PressedColor = Color.FromArgb(108, 111, 127);
			btnSearch.Size = new Size(100, 53);
			btnSearch.TabIndex = 2;
			btnSearch.Text = "Search";
			btnSearch.TextAlignment = StringAlignment.Center;
			btnSearch.Click += btnSearch_Click;
			// 
			// btnAddNew
			// 
			btnAddNew.Anchor = AnchorStyles.Right;
			btnAddNew.BackColor = Color.Transparent;
			btnAddNew.BorderColor = Color.FromArgb(26, 35, 48);
			btnAddNew.Cursor = Cursors.Hand;
			btnAddNew.EnteredBorderColor = Color.FromArgb(26, 35, 48);
			btnAddNew.EnteredColor = Color.FromArgb(46, 55, 68);
			btnAddNew.Font = new Font("Microsoft Sans Serif", 10F);
			btnAddNew.Image = null;
			btnAddNew.ImageAlign = ContentAlignment.MiddleLeft;
			btnAddNew.InactiveColor = Color.FromArgb(26, 35, 48);
			btnAddNew.Location = new Point(607, 11);
			btnAddNew.Name = "btnAddNew";
			btnAddNew.PressedBorderColor = Color.Black;
			btnAddNew.PressedColor = Color.Black;
			btnAddNew.Size = new Size(150, 53);
			btnAddNew.TabIndex = 3;
			btnAddNew.Text = "+ Add Patient";
			btnAddNew.TextAlignment = StringAlignment.Center;
			btnAddNew.Click += btnAddNew_Click;
			// 
			// dgvPatients
			// 
			dgvPatients.BackgroundColor = Color.FromArgb(108, 111, 127);
			dgvPatients.BorderStyle = BorderStyle.None;
			dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPatients.Dock = DockStyle.Fill;
			dgvPatients.EnableHeadersVisualStyles = false;
			dgvPatients.Location = new Point(25, 90);
			dgvPatients.Margin = new Padding(25, 5, 25, 5);
			dgvPatients.Name = "dgvPatients";
			dgvPatients.RowHeadersWidth = 57;
			dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvPatients.Size = new Size(750, 375);
			dgvPatients.TabIndex = 1;
			// 
			// pnlFooter
			// 
			pnlFooter.ColumnCount = 2;
			pnlFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			pnlFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
			pnlFooter.Controls.Add(btnOpen, 1, 0);
			pnlFooter.Dock = DockStyle.Fill;
			pnlFooter.Location = new Point(20, 470);
			pnlFooter.Margin = new Padding(20, 0, 20, 10);
			pnlFooter.Name = "pnlFooter";
			pnlFooter.RowCount = 1;
			pnlFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			pnlFooter.Size = new Size(760, 70);
			pnlFooter.TabIndex = 2;
			// 
			// btnOpen
			// 
			btnOpen.Anchor = AnchorStyles.Right;
			btnOpen.BackColor = Color.Transparent;
			btnOpen.BorderColor = Color.FromArgb(26, 35, 48);
			btnOpen.Cursor = Cursors.Hand;
			btnOpen.EnteredBorderColor = Color.FromArgb(26, 35, 48);
			btnOpen.EnteredColor = Color.FromArgb(46, 55, 68);
			btnOpen.Font = new Font("Microsoft Sans Serif", 10F);
			btnOpen.Image = null;
			btnOpen.ImageAlign = ContentAlignment.MiddleLeft;
			btnOpen.InactiveColor = Color.FromArgb(26, 35, 48);
			btnOpen.Location = new Point(607, 8);
			btnOpen.Name = "btnOpen";
			btnOpen.PressedBorderColor = Color.Black;
			btnOpen.PressedColor = Color.Black;
			btnOpen.Size = new Size(150, 53);
			btnOpen.TabIndex = 0;
			btnOpen.Text = "Open Profile";
			btnOpen.TextAlignment = StringAlignment.Center;
			btnOpen.Click += btnOpenRecord_Click;
			// 
			// PatientListControl
			// 
			Controls.Add(tblLayout);
			Name = "PatientListControl";
			Size = new Size(800, 550);
			Load += PatientListControl_Load;
			tblLayout.ResumeLayout(false);
			tblHeader.ResumeLayout(false);
			tblHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
			pnlFooter.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tblLayout;
		private TableLayoutPanel tblHeader;
		private TableLayoutPanel pnlFooter;
		private Label lblTitle;
		private TextBox txtSearch;
		private ReaLTaiizor.Controls.Button btnSearch;
		private ReaLTaiizor.Controls.Button btnAddNew;
		private ReaLTaiizor.Controls.Button btnOpen;
		private DataGridView dgvPatients;
	}
}