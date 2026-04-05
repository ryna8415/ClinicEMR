namespace ClinicEMR
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblClinicEMR = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblClinicEMR
            // 
            lblClinicEMR.AutoSize = true;
            lblClinicEMR.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicEMR.ImageAlign = ContentAlignment.TopCenter;
            lblClinicEMR.Location = new Point(79, 49);
            lblClinicEMR.Name = "lblClinicEMR";
            lblClinicEMR.Size = new Size(145, 37);
            lblClinicEMR.TabIndex = 1;
            lblClinicEMR.Text = "ClinicEMR";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(45, 140);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(66, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username: ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(117, 132);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(123, 23);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(45, 176);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(117, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(123, 23);
            txtPassword.TabIndex = 5;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(165, 209);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(75, 23);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(64, 254);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 7;
            lblError.Visible = false;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogIn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 323);
            Controls.Add(lblError);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblClinicEMR);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblClinicEMR;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogIn;
        private Label lblError;
    }
}
