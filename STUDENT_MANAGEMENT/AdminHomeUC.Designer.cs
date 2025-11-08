namespace STUDENT_MS
{
    partial class AdminHomeUC
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
            this.accountDGV = new System.Windows.Forms.DataGridView();
            this.removeUsernameTB = new System.Windows.Forms.TextBox();
            this.addPasswordTB = new System.Windows.Forms.TextBox();
            this.addBT = new System.Windows.Forms.Button();
            this.addUsernameTB = new System.Windows.Forms.TextBox();
            this.removeBT = new System.Windows.Forms.Button();
            this.welcomeLB = new System.Windows.Forms.Label();
            this.updateBT = new System.Windows.Forms.Button();
            this.changeUsernameTB = new System.Windows.Forms.TextBox();
            this.newPasswordTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.accountDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDGV
            // 
            this.accountDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDGV.Location = new System.Drawing.Point(36, 71);
            this.accountDGV.Name = "accountDGV";
            this.accountDGV.RowHeadersWidth = 51;
            this.accountDGV.RowTemplate.Height = 24;
            this.accountDGV.Size = new System.Drawing.Size(882, 274);
            this.accountDGV.TabIndex = 0;
            // 
            // removeUsernameTB
            // 
            this.removeUsernameTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUsernameTB.ForeColor = System.Drawing.Color.Gray;
            this.removeUsernameTB.Location = new System.Drawing.Point(54, 455);
            this.removeUsernameTB.Name = "removeUsernameTB";
            this.removeUsernameTB.Size = new System.Drawing.Size(279, 22);
            this.removeUsernameTB.TabIndex = 34;
            this.removeUsernameTB.Text = "Username to remove";
            this.removeUsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removeUsernameTB.Enter += new System.EventHandler(this.removeUsernameTB_Enter);
            this.removeUsernameTB.Leave += new System.EventHandler(this.removeUsernameTB_Leave);
            // 
            // addPasswordTB
            // 
            this.addPasswordTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPasswordTB.ForeColor = System.Drawing.Color.Gray;
            this.addPasswordTB.Location = new System.Drawing.Point(352, 367);
            this.addPasswordTB.Name = "addPasswordTB";
            this.addPasswordTB.Size = new System.Drawing.Size(239, 22);
            this.addPasswordTB.TabIndex = 33;
            this.addPasswordTB.Text = "Password";
            this.addPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addPasswordTB.Enter += new System.EventHandler(this.addPasswordTB_Enter);
            this.addPasswordTB.Leave += new System.EventHandler(this.addPasswordTB_Leave);
            // 
            // addBT
            // 
            this.addBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBT.Location = new System.Drawing.Point(607, 364);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(188, 28);
            this.addBT.TabIndex = 32;
            this.addBT.Text = "ADD";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // addUsernameTB
            // 
            this.addUsernameTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsernameTB.ForeColor = System.Drawing.Color.Gray;
            this.addUsernameTB.Location = new System.Drawing.Point(54, 367);
            this.addUsernameTB.Name = "addUsernameTB";
            this.addUsernameTB.Size = new System.Drawing.Size(279, 22);
            this.addUsernameTB.TabIndex = 31;
            this.addUsernameTB.Text = "Username";
            this.addUsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addUsernameTB.Enter += new System.EventHandler(this.addUsernameTB_Enter);
            this.addUsernameTB.Leave += new System.EventHandler(this.addUsernameTB_Leave);
            // 
            // removeBT
            // 
            this.removeBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBT.Location = new System.Drawing.Point(352, 452);
            this.removeBT.Name = "removeBT";
            this.removeBT.Size = new System.Drawing.Size(124, 28);
            this.removeBT.TabIndex = 35;
            this.removeBT.Text = "REMOVE";
            this.removeBT.UseVisualStyleBackColor = true;
            this.removeBT.Click += new System.EventHandler(this.removeBT_Click);
            // 
            // welcomeLB
            // 
            this.welcomeLB.AutoSize = true;
            this.welcomeLB.Font = new System.Drawing.Font("Asap", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.welcomeLB.Location = new System.Drawing.Point(29, 16);
            this.welcomeLB.Name = "welcomeLB";
            this.welcomeLB.Size = new System.Drawing.Size(153, 37);
            this.welcomeLB.TabIndex = 36;
            this.welcomeLB.Text = "WELCOME!";
            // 
            // updateBT
            // 
            this.updateBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBT.Location = new System.Drawing.Point(607, 411);
            this.updateBT.Name = "updateBT";
            this.updateBT.Size = new System.Drawing.Size(188, 28);
            this.updateBT.TabIndex = 38;
            this.updateBT.Text = "UPDATE";
            this.updateBT.UseVisualStyleBackColor = true;
            this.updateBT.Click += new System.EventHandler(this.updateBT_Click);
            // 
            // changeUsernameTB
            // 
            this.changeUsernameTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUsernameTB.ForeColor = System.Drawing.Color.Gray;
            this.changeUsernameTB.Location = new System.Drawing.Point(54, 411);
            this.changeUsernameTB.Name = "changeUsernameTB";
            this.changeUsernameTB.Size = new System.Drawing.Size(279, 22);
            this.changeUsernameTB.TabIndex = 37;
            this.changeUsernameTB.Text = "Username to change";
            this.changeUsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.changeUsernameTB.Enter += new System.EventHandler(this.changeUsernameTB_Enter);
            this.changeUsernameTB.Leave += new System.EventHandler(this.changeUsernameTB_Leave);
            // 
            // newPasswordTB
            // 
            this.newPasswordTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTB.ForeColor = System.Drawing.Color.Gray;
            this.newPasswordTB.Location = new System.Drawing.Point(352, 411);
            this.newPasswordTB.Name = "newPasswordTB";
            this.newPasswordTB.Size = new System.Drawing.Size(239, 22);
            this.newPasswordTB.TabIndex = 39;
            this.newPasswordTB.Text = "New Password";
            this.newPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPasswordTB.Enter += new System.EventHandler(this.newPasswordTB_Enter);
            this.newPasswordTB.Leave += new System.EventHandler(this.newPasswordTB_Leave);
            // 
            // AdminHomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newPasswordTB);
            this.Controls.Add(this.updateBT);
            this.Controls.Add(this.changeUsernameTB);
            this.Controls.Add(this.welcomeLB);
            this.Controls.Add(this.removeBT);
            this.Controls.Add(this.removeUsernameTB);
            this.Controls.Add(this.addPasswordTB);
            this.Controls.Add(this.addBT);
            this.Controls.Add(this.addUsernameTB);
            this.Controls.Add(this.accountDGV);
            this.Name = "AdminHomeUC";
            this.Size = new System.Drawing.Size(1048, 509);
            this.Load += new System.EventHandler(this.AdminHomeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox removeUsernameTB;
        public System.Windows.Forms.TextBox addPasswordTB;
        public System.Windows.Forms.Button addBT;
        public System.Windows.Forms.TextBox addUsernameTB;
        public System.Windows.Forms.Button removeBT;
        public System.Windows.Forms.Label welcomeLB;
        public System.Windows.Forms.DataGridView accountDGV;
        public System.Windows.Forms.Button updateBT;
        public System.Windows.Forms.TextBox changeUsernameTB;
        public System.Windows.Forms.TextBox newPasswordTB;
    }
}
