namespace MAD___PF_Hotel
{
    partial class Log_in
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 49);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(19, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(91, 19);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassword.Location = new System.Drawing.Point(80, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogIn.Location = new System.Drawing.Point(66, 178);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(103, 32);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(66, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginPanel.Controls.Add(this.btnExit);
            this.LoginPanel.Controls.Add(this.btnLogIn);
            this.LoginPanel.Controls.Add(this.lblPassword);
            this.LoginPanel.Controls.Add(this.lblEmail);
            this.LoginPanel.Controls.Add(this.txtPassword);
            this.LoginPanel.Controls.Add(this.txtEmail);
            this.LoginPanel.Location = new System.Drawing.Point(42, 26);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(241, 285);
            this.LoginPanel.TabIndex = 6;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 341);
            this.Controls.Add(this.LoginPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quetzal travels - Login";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel LoginPanel;
    }
}

