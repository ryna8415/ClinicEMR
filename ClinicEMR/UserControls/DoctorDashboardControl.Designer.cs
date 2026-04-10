namespace ClinicEMR.UserControls
{
    partial class DoctorDashboardControl
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
            tblLayout = new TableLayoutPanel();
            tblHeader = new TableLayoutPanel();
            lblWelcome = new Label();
            tblCards = new TableLayoutPanel();
            lblMyPatients = new Label();
            dgvMyAppts = new DataGridView();
            tblLayout.SuspendLayout();
            tblHeader.SuspendLayout();
            tblCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyAppts).BeginInit();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvMyAppts, 0, 2);
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Controls.Add(tblCards, 0, 1);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 4;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayout.Size = new Size(792, 535);
            tblLayout.TabIndex = 2;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 1;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.1186F));
            tblHeader.Controls.Add(lblWelcome, 0, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 20);
            tblHeader.Margin = new Padding(20, 20, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 1;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.Size = new Size(752, 57);
            tblHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Left;
            lblWelcome.FlatStyle = FlatStyle.System;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlText;
            lblWelcome.Location = new Point(3, 8);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(331, 40);
            lblWelcome.TabIndex = 5;
            // 
            // tblCards
            // 
            tblCards.ColumnCount = 3;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblCards.ColumnStyles.Add(new ColumnStyle());
            tblCards.Controls.Add(lblMyPatients, 0, 0);
            tblCards.Dock = DockStyle.Fill;
            tblCards.Location = new Point(20, 83);
            tblCards.Margin = new Padding(20, 3, 20, 3);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 1;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCards.Size = new Size(752, 114);
            tblCards.TabIndex = 1;
            // 
            // lblMyPatients
            // 
            lblMyPatients.Anchor = AnchorStyles.Left;
            lblMyPatients.FlatStyle = FlatStyle.System;
            lblMyPatients.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyPatients.ForeColor = SystemColors.ControlText;
            lblMyPatients.Location = new Point(3, 12);
            lblMyPatients.Name = "lblMyPatients";
            lblMyPatients.Size = new Size(100, 90);
            lblMyPatients.TabIndex = 9;
            // 
            // dgvMyAppts
            // 
            dgvMyAppts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyAppts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyAppts.Dock = DockStyle.Fill;
            dgvMyAppts.Location = new Point(20, 203);
            dgvMyAppts.Margin = new Padding(20, 3, 20, 3);
            dgvMyAppts.Name = "dgvMyAppts";
            dgvMyAppts.ReadOnly = true;
            dgvMyAppts.Size = new Size(752, 309);
            dgvMyAppts.TabIndex = 10;
            // 
            // DoctorDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "DoctorDashboardControl";
            Size = new Size(792, 535);
            Load += DoctorDashboardControl_Load;
            tblLayout.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyAppts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private Label lblWelcome;
        private TableLayoutPanel tblCards;
        private Label lblMyPatients;
        private DataGridView dgvMyAppts;
    }
}
