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
            btnAddUser = new Button();
            dgvUsers = new DataGridView();
            btnDeactivate = new Button();
            btnReEnable = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(586, 30);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(105, 29);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "+ New User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(35, 74);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(656, 428);
            dgvUsers.TabIndex = 1;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Location = new Point(586, 518);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(105, 29);
            btnDeactivate.TabIndex = 2;
            btnDeactivate.Text = "Deactivate User";
            btnDeactivate.UseVisualStyleBackColor = true;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnReEnable
            // 
            btnReEnable.Location = new Point(475, 518);
            btnReEnable.Name = "btnReEnable";
            btnReEnable.Size = new Size(105, 29);
            btnReEnable.TabIndex = 3;
            btnReEnable.Text = "Re-Enable User";
            btnReEnable.UseVisualStyleBackColor = true;
            btnReEnable.Click += btnReEnable_Click;
            // 
            // UserManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReEnable);
            Controls.Add(btnDeactivate);
            Controls.Add(dgvUsers);
            Controls.Add(btnAddUser);
            Name = "UserManagementControl";
            Size = new Size(730, 575);
            Load += UserManagementControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private DataGridView dgvUsers;
        private Button btnDeactivate;
        private Button btnReEnable;
    }
}
