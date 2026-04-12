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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnOpen = new Button();
            tblHeader = new TableLayoutPanel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddNew = new Button();
            tblLayout = new TableLayoutPanel();
            dgvPatients = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            tblHeader.SuspendLayout();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.Controls.Add(btnOpen, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 446);
            tableLayoutPanel2.Margin = new Padding(20, 3, 20, 20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(707, 57);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Right;
            btnOpen.Location = new Point(611, 13);
            btnOpen.Margin = new Padding(0);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(96, 30);
            btnOpen.TabIndex = 13;
            btnOpen.Text = "Open Record";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpenRecord_Click;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 3;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.6383F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6099291F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.7517729F));
            tblHeader.Controls.Add(txtSearch, 0, 1);
            tblHeader.Controls.Add(btnSearch, 1, 1);
            tblHeader.Controls.Add(btnAddNew, 2, 1);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 10);
            tblHeader.Margin = new Padding(20, 10, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 2;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tblHeader.Size = new Size(707, 47);
            tblHeader.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(3, 19);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search: Name/Patient Code";
            txtSearch.Size = new Size(493, 25);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Right;
            btnSearch.Location = new Point(506, 16);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 30);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Right;
            btnAddNew.Location = new Point(611, 16);
            btnAddNew.Margin = new Padding(0);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(96, 30);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "+ Add Patient";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvPatients, 0, 1);
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Controls.Add(tableLayoutPanel2, 0, 2);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.Size = new Size(747, 523);
            tblLayout.TabIndex = 1;
            // 
            // dgvPatients
            // 
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.Location = new Point(20, 63);
            dgvPatients.Margin = new Padding(20, 3, 20, 3);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(707, 377);
            dgvPatients.TabIndex = 12;
            // 
            // PatientListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "PatientListControl";
            Size = new Size(747, 523);
            Load += PatientListControl_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);

            #endregion
        }
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tblHeader;
        private TableLayoutPanel tblLayout;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAddNew;
        private DataGridView dgvPatients;
        private Button btnOpen;
    }

}
