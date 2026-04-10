namespace ClinicEMR.Forms
{
    partial class AppointmentControl
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
            tblContent = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnBook = new Button();
            chkAllDates = new CheckBox();
            dtpDate = new DateTimePicker();
            cboStatus = new ComboBox();
            lblFilterbyDate = new Label();
            lblFilterbyStatus = new Label();
            dgvAppointments = new DataGridView();
            btnUpdateStatus = new Button();
            tblLayout.SuspendLayout();
            tblHeader.SuspendLayout();
            tblContent.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Controls.Add(tblContent, 0, 1);
            tblLayout.Controls.Add(tableLayoutPanel2, 0, 2);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.Size = new Size(729, 555);
            tblLayout.TabIndex = 1;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 4;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.012949F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.4935265F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7467613F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7467613F));
            tblHeader.Controls.Add(btnBook, 0, 1);
            tblHeader.Controls.Add(chkAllDates, 1, 1);
            tblHeader.Controls.Add(dtpDate, 2, 1);
            tblHeader.Controls.Add(cboStatus, 3, 1);
            tblHeader.Controls.Add(lblFilterbyDate, 2, 0);
            tblHeader.Controls.Add(lblFilterbyStatus, 3, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 10);
            tblHeader.Margin = new Padding(20, 10, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 2;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblHeader.Size = new Size(689, 67);
            tblHeader.TabIndex = 0;
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContent.Controls.Add(dgvAppointments, 0, 0);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(20, 83);
            tblContent.Margin = new Padding(20, 3, 20, 3);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 1;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 58.246376F));
            tblContent.Size = new Size(689, 389);
            tblContent.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.Controls.Add(btnUpdateStatus, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 478);
            tableLayoutPanel2.Margin = new Padding(20, 3, 20, 20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(689, 57);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnBook
            // 
            btnBook.Anchor = AnchorStyles.Left;
            btnBook.Location = new Point(0, 35);
            btnBook.Margin = new Padding(0);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(105, 30);
            btnBook.TabIndex = 11;
            btnBook.Text = "+ Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // chkAllDates
            // 
            chkAllDates.Anchor = AnchorStyles.Left;
            chkAllDates.AutoSize = true;
            chkAllDates.Location = new Point(120, 40);
            chkAllDates.Name = "chkAllDates";
            chkAllDates.Size = new Size(156, 19);
            chkAllDates.TabIndex = 15;
            chkAllDates.Text = "Display All Appoinments";
            chkAllDates.UseVisualStyleBackColor = true;
            chkAllDates.CheckedChanged += chkAllDates_CheckedChanged;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(405, 36);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(136, 23);
            dtpDate.TabIndex = 16;
            dtpDate.ValueChanged += btnLoad_Click;
            // 
            // cboStatus
            // 
            cboStatus.Dock = DockStyle.Fill;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Cancelled", "No-Show" });
            cboStatus.Location = new Point(547, 36);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(139, 23);
            cboStatus.TabIndex = 17;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // lblFilterbyDate
            // 
            lblFilterbyDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFilterbyDate.AutoSize = true;
            lblFilterbyDate.Location = new Point(405, 18);
            lblFilterbyDate.Name = "lblFilterbyDate";
            lblFilterbyDate.Size = new Size(79, 15);
            lblFilterbyDate.TabIndex = 18;
            lblFilterbyDate.Text = "Filter by Date:";
            // 
            // lblFilterbyStatus
            // 
            lblFilterbyStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFilterbyStatus.AutoSize = true;
            lblFilterbyStatus.Location = new Point(547, 18);
            lblFilterbyStatus.Name = "lblFilterbyStatus";
            lblFilterbyStatus.Size = new Size(87, 15);
            lblFilterbyStatus.TabIndex = 19;
            lblFilterbyStatus.Text = "Filter by Status:";
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(3, 3);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(683, 383);
            dgvAppointments.TabIndex = 13;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateStatus.Location = new Point(584, 0);
            btnUpdateStatus.Margin = new Padding(0);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(105, 30);
            btnUpdateStatus.TabIndex = 14;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // AppointmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "AppointmentControl";
            Size = new Size(729, 555);
            Load += AppointmentControl_Load;
            tblLayout.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tblContent.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private TableLayoutPanel tblContent;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnBook;
        private CheckBox chkAllDates;
        private DateTimePicker dtpDate;
        private ComboBox cboStatus;
        private Label lblFilterbyDate;
        private Label lblFilterbyStatus;
        private DataGridView dgvAppointments;
        private Button btnUpdateStatus;
    }
}
