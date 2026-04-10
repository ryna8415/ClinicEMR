namespace ClinicEMR.UserControls
{
    partial class UserManagementControl
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
            dgvUsers = new DataGridView();
            tblHeader = new TableLayoutPanel();
            btnAddUser = new Button();
            tblFooter = new TableLayoutPanel();
            btnDeactivate = new Button();
            btnReEnable = new Button();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tblHeader.SuspendLayout();
            tblFooter.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvUsers, 0, 1);
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Controls.Add(tblFooter, 0, 2);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.Size = new Size(730, 575);
            tblLayout.TabIndex = 1;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(20, 83);
            dgvUsers.Margin = new Padding(20, 3, 20, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(690, 409);
            dgvUsers.TabIndex = 6;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 2;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.3958025F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.6041946F));
            tblHeader.Controls.Add(btnAddUser, 1, 1);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 20);
            tblHeader.Margin = new Padding(20, 20, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 2;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 38.5964928F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 61.4035072F));
            tblHeader.Size = new Size(690, 57);
            tblHeader.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Right;
            btnAddUser.Location = new Point(585, 24);
            btnAddUser.Margin = new Padding(0);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(105, 30);
            btnAddUser.TabIndex = 5;
            btnAddUser.Text = "+ New User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // tblFooter
            // 
            tblFooter.ColumnCount = 2;
            tblFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.70166F));
            tblFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2983418F));
            tblFooter.Controls.Add(btnDeactivate, 1, 0);
            tblFooter.Controls.Add(btnReEnable, 0, 0);
            tblFooter.Dock = DockStyle.Fill;
            tblFooter.Location = new Point(20, 498);
            tblFooter.Margin = new Padding(20, 3, 20, 3);
            tblFooter.Name = "tblFooter";
            tblFooter.RowCount = 2;
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFooter.Size = new Size(690, 74);
            tblFooter.TabIndex = 7;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Anchor = AnchorStyles.Right;
            btnDeactivate.Location = new Point(582, 3);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(105, 30);
            btnDeactivate.TabIndex = 7;
            btnDeactivate.Text = "Deactivate User";
            btnDeactivate.UseVisualStyleBackColor = true;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnReEnable
            // 
            btnReEnable.Anchor = AnchorStyles.Right;
            btnReEnable.Location = new Point(469, 3);
            btnReEnable.Name = "btnReEnable";
            btnReEnable.Size = new Size(105, 30);
            btnReEnable.TabIndex = 8;
            btnReEnable.Text = "Re-Enable User";
            btnReEnable.UseVisualStyleBackColor = true;
            btnReEnable.Click += btnReEnable_Click;
            // 
            // UserManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "UserManagementControl";
            Size = new Size(730, 575);
            Load += UserManagementControl_Load;
            tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tblHeader.ResumeLayout(false);
            tblFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private Button btnAddUser;
        private DataGridView dgvUsers;
        private TableLayoutPanel tblFooter;
        private Button btnDeactivate;
        private Button btnReEnable;
    }
}
