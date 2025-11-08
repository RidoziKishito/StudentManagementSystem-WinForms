namespace STUDENT_MS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.decor1PN = new System.Windows.Forms.Panel();
            this.openEyePIC = new System.Windows.Forms.PictureBox();
            this.hideEyePIC = new System.Windows.Forms.PictureBox();
            this.forgetLB1 = new System.Windows.Forms.Label();
            this.forgetPasswordBT = new System.Windows.Forms.Label();
            this.loginBT = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordLB = new System.Windows.Forms.Label();
            this.usernameLB = new System.Windows.Forms.Label();
            this.topPN = new System.Windows.Forms.Panel();
            this.titleLB = new System.Windows.Forms.Label();
            this.minimizePIC = new System.Windows.Forms.PictureBox();
            this.closePIC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.openEyePIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideEyePIC)).BeginInit();
            this.topPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePIC)).BeginInit();
            this.SuspendLayout();
            // 
            // decor1PN
            // 
            this.decor1PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.decor1PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.decor1PN.Location = new System.Drawing.Point(0, 37);
            this.decor1PN.Name = "decor1PN";
            this.decor1PN.Size = new System.Drawing.Size(415, 10);
            this.decor1PN.TabIndex = 35;
            // 
            // openEyePIC
            // 
            this.openEyePIC.Image = ((System.Drawing.Image)(resources.GetObject("openEyePIC.Image")));
            this.openEyePIC.Location = new System.Drawing.Point(213, 199);
            this.openEyePIC.Name = "openEyePIC";
            this.openEyePIC.Size = new System.Drawing.Size(33, 29);
            this.openEyePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openEyePIC.TabIndex = 34;
            this.openEyePIC.TabStop = false;
            this.openEyePIC.Click += new System.EventHandler(this.openEyePIC_Click);
            // 
            // hideEyePIC
            // 
            this.hideEyePIC.Image = ((System.Drawing.Image)(resources.GetObject("hideEyePIC.Image")));
            this.hideEyePIC.Location = new System.Drawing.Point(213, 199);
            this.hideEyePIC.Name = "hideEyePIC";
            this.hideEyePIC.Size = new System.Drawing.Size(33, 29);
            this.hideEyePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideEyePIC.TabIndex = 33;
            this.hideEyePIC.TabStop = false;
            this.hideEyePIC.Click += new System.EventHandler(this.hideEyePIC_Click);
            // 
            // forgetLB1
            // 
            this.forgetLB1.AutoSize = true;
            this.forgetLB1.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetLB1.Location = new System.Drawing.Point(80, 277);
            this.forgetLB1.Name = "forgetLB1";
            this.forgetLB1.Size = new System.Drawing.Size(58, 22);
            this.forgetLB1.TabIndex = 32;
            this.forgetLB1.Text = "Forgot";
            // 
            // forgetPasswordBT
            // 
            this.forgetPasswordBT.AutoSize = true;
            this.forgetPasswordBT.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPasswordBT.ForeColor = System.Drawing.Color.Green;
            this.forgetPasswordBT.Location = new System.Drawing.Point(135, 277);
            this.forgetPasswordBT.Name = "forgetPasswordBT";
            this.forgetPasswordBT.Size = new System.Drawing.Size(177, 22);
            this.forgetPasswordBT.TabIndex = 29;
            this.forgetPasswordBT.Text = "Username | Password?";
            this.forgetPasswordBT.Click += new System.EventHandler(this.forgetPasswordBT_Click);
            // 
            // loginBT
            // 
            this.loginBT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginBT.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBT.Location = new System.Drawing.Point(252, 199);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(139, 29);
            this.loginBT.TabIndex = 28;
            this.loginBT.Text = "LOGIN";
            this.loginBT.UseVisualStyleBackColor = false;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(139, 142);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(252, 22);
            this.passwordTB.TabIndex = 27;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(139, 92);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(252, 22);
            this.usernameTB.TabIndex = 26;
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLB.Location = new System.Drawing.Point(11, 136);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(112, 27);
            this.passwordLB.TabIndex = 25;
            this.passwordLB.Text = "Password";
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLB.Location = new System.Drawing.Point(11, 87);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(117, 27);
            this.usernameLB.TabIndex = 24;
            this.usernameLB.Text = "Username";
            // 
            // topPN
            // 
            this.topPN.BackColor = System.Drawing.Color.White;
            this.topPN.Controls.Add(this.titleLB);
            this.topPN.Controls.Add(this.minimizePIC);
            this.topPN.Controls.Add(this.closePIC);
            this.topPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPN.Location = new System.Drawing.Point(0, 0);
            this.topPN.Name = "topPN";
            this.topPN.Size = new System.Drawing.Size(415, 37);
            this.topPN.TabIndex = 23;
            this.topPN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseDown);
            this.topPN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseMove);
            this.topPN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseUp);
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Asap SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.Location = new System.Drawing.Point(12, 9);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(58, 22);
            this.titleLB.TabIndex = 2;
            this.titleLB.Text = "LOGIN";
            // 
            // minimizePIC
            // 
            this.minimizePIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizePIC.Image = ((System.Drawing.Image)(resources.GetObject("minimizePIC.Image")));
            this.minimizePIC.Location = new System.Drawing.Point(326, 1);
            this.minimizePIC.Name = "minimizePIC";
            this.minimizePIC.Size = new System.Drawing.Size(45, 33);
            this.minimizePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizePIC.TabIndex = 1;
            this.minimizePIC.TabStop = false;
            this.minimizePIC.Click += new System.EventHandler(this.minimizePIC_Click);
            // 
            // closePIC
            // 
            this.closePIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePIC.Image = ((System.Drawing.Image)(resources.GetObject("closePIC.Image")));
            this.closePIC.Location = new System.Drawing.Point(367, 3);
            this.closePIC.Name = "closePIC";
            this.closePIC.Size = new System.Drawing.Size(35, 30);
            this.closePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePIC.TabIndex = 1;
            this.closePIC.TabStop = false;
            this.closePIC.Click += new System.EventHandler(this.closePIC_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 307);
            this.Controls.Add(this.decor1PN);
            this.Controls.Add(this.openEyePIC);
            this.Controls.Add(this.hideEyePIC);
            this.Controls.Add(this.forgetLB1);
            this.Controls.Add(this.forgetPasswordBT);
            this.Controls.Add(this.loginBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passwordLB);
            this.Controls.Add(this.usernameLB);
            this.Controls.Add(this.topPN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openEyePIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideEyePIC)).EndInit();
            this.topPN.ResumeLayout(false);
            this.topPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel decor1PN;
        private System.Windows.Forms.PictureBox openEyePIC;
        private System.Windows.Forms.PictureBox hideEyePIC;
        private System.Windows.Forms.Label forgetLB1;
        private System.Windows.Forms.Label forgetPasswordBT;
        private System.Windows.Forms.Button loginBT;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.Panel topPN;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.PictureBox minimizePIC;
        private System.Windows.Forms.PictureBox closePIC;
    }
}