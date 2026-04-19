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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementControl));
            tblLayout = new TableLayoutPanel();
            dgvUsers = new DataGridView();
            tblHeader = new TableLayoutPanel();
            btnAddUser = new ReaLTaiizor.Controls.Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tblFooter = new TableLayoutPanel();
            btnReEnable = new ReaLTaiizor.Controls.Button();
            btnDeactivate = new ReaLTaiizor.Controls.Button();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tblHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tblLayout.Size = new Size(730, 575);
            tblLayout.TabIndex = 1;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(20, 62);
            dgvUsers.Margin = new Padding(20, 3, 20, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(690, 370);
            dgvUsers.TabIndex = 6;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 2;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.3958025F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tblHeader.Controls.Add(btnAddUser, 1, 0);
            tblHeader.Controls.Add(tableLayoutPanel1, 0, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 20);
            tblHeader.Margin = new Padding(20, 20, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 1;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 38.5964928F));
            tblHeader.Size = new Size(690, 36);
            tblHeader.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Right;
            btnAddUser.BackColor = Color.FromArgb(226, 230, 237);
            btnAddUser.BorderColor = Color.FromArgb(108, 111, 127);
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnAddUser.EnteredColor = Color.FromArgb(69, 85, 97);
            btnAddUser.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnAddUser.Image = null;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.InactiveColor = Color.FromArgb(26, 35, 48);
            btnAddUser.Location = new Point(607, 3);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnAddUser.PressedColor = Color.FromArgb(108, 111, 127);
            btnAddUser.Size = new Size(80, 30);
            btnAddUser.TabIndex = 22;
            btnAddUser.Text = "New User";
            btnAddUser.TextAlignment = StringAlignment.Center;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.30164528F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.69836F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(547, 30);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 30);
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
            label1.Location = new Point(32, 3);
            label1.Name = "label1";
            label1.Size = new Size(131, 24);
            label1.TabIndex = 1;
            label1.Text = "Manage Users";
            // 
            // tblFooter
            // 
            tblFooter.ColumnCount = 2;
            tblFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.95652F));
            tblFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.043478F));
            tblFooter.Controls.Add(btnDeactivate, 1, 0);
            tblFooter.Controls.Add(btnReEnable, 0, 0);
            tblFooter.Dock = DockStyle.Fill;
            tblFooter.Location = new Point(20, 438);
            tblFooter.Margin = new Padding(20, 3, 20, 3);
            tblFooter.Name = "tblFooter";
            tblFooter.RowCount = 2;
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFooter.Size = new Size(690, 134);
            tblFooter.TabIndex = 7;
            // 
            // btnReEnable
            // 
            btnReEnable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReEnable.BackColor = Color.FromArgb(226, 230, 237);
            btnReEnable.BorderColor = Color.FromArgb(108, 111, 127);
            btnReEnable.Cursor = Cursors.Hand;
            btnReEnable.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnReEnable.EnteredColor = Color.FromArgb(69, 85, 97);
            btnReEnable.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnReEnable.Image = null;
            btnReEnable.ImageAlign = ContentAlignment.MiddleLeft;
            btnReEnable.InactiveColor = Color.FromArgb(92, 102, 114);
            btnReEnable.Location = new Point(517, 3);
            btnReEnable.Name = "btnReEnable";
            btnReEnable.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnReEnable.PressedColor = Color.FromArgb(108, 111, 127);
            btnReEnable.Size = new Size(80, 30);
            btnReEnable.TabIndex = 23;
            btnReEnable.Text = "Re-Enable";
            btnReEnable.TextAlignment = StringAlignment.Center;
            btnReEnable.Click += btnReEnable_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeactivate.BackColor = Color.FromArgb(226, 230, 237);
            btnDeactivate.BorderColor = Color.FromArgb(108, 111, 127);
            btnDeactivate.Cursor = Cursors.Hand;
            btnDeactivate.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnDeactivate.EnteredColor = Color.FromArgb(69, 85, 97);
            btnDeactivate.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnDeactivate.Image = null;
            btnDeactivate.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeactivate.InactiveColor = Color.FromArgb(92, 102, 114);
            btnDeactivate.Location = new Point(607, 3);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnDeactivate.PressedColor = Color.FromArgb(108, 111, 127);
            btnDeactivate.Size = new Size(80, 30);
            btnDeactivate.TabIndex = 24;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.TextAlignment = StringAlignment.Center;
            btnDeactivate.Click += btnDeactivate_Click;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tblFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private DataGridView dgvUsers;
        private TableLayoutPanel tblFooter;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private ReaLTaiizor.Controls.Button btnAddUser;
        private ReaLTaiizor.Controls.Button btnReEnable;
        private ReaLTaiizor.Controls.Button btnDeactivate;
    }
}
