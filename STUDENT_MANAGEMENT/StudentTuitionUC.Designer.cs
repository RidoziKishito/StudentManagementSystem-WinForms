namespace STUDENT_MS
{
    partial class StudentTuitionUC
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
            this.tuitionLB = new System.Windows.Forms.Label();
            this.payBT = new System.Windows.Forms.Button();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.amountLB = new System.Windows.Forms.Label();
            this.statusLB = new System.Windows.Forms.Label();
            this.amountLeftLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tuitionLB
            // 
            this.tuitionLB.AutoSize = true;
            this.tuitionLB.Font = new System.Drawing.Font("Asap SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuitionLB.Location = new System.Drawing.Point(157, 46);
            this.tuitionLB.Name = "tuitionLB";
            this.tuitionLB.Size = new System.Drawing.Size(93, 26);
            this.tuitionLB.TabIndex = 0;
            this.tuitionLB.Text = "TUITION:";
            // 
            // payBT
            // 
            this.payBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBT.Location = new System.Drawing.Point(430, 105);
            this.payBT.Name = "payBT";
            this.payBT.Size = new System.Drawing.Size(124, 35);
            this.payBT.TabIndex = 23;
            this.payBT.Text = "PAY";
            this.payBT.UseVisualStyleBackColor = true;
            this.payBT.Click += new System.EventHandler(this.payBT_Click);
            // 
            // amountTB
            // 
            this.amountTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.ForeColor = System.Drawing.Color.Gray;
            this.amountTB.Location = new System.Drawing.Point(162, 111);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(238, 22);
            this.amountTB.TabIndex = 22;
            this.amountTB.Text = "Amount (USD)";
            this.amountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTB.Enter += new System.EventHandler(this.amountTB_Enter);
            this.amountTB.Leave += new System.EventHandler(this.amountTB_Leave);
            // 
            // amountLB
            // 
            this.amountLB.AutoSize = true;
            this.amountLB.Font = new System.Drawing.Font("Asap Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.amountLB.Location = new System.Drawing.Point(257, 46);
            this.amountLB.Name = "amountLB";
            this.amountLB.Size = new System.Drawing.Size(25, 30);
            this.amountLB.TabIndex = 24;
            this.amountLB.Text = "0";
            // 
            // statusLB
            // 
            this.statusLB.AutoSize = true;
            this.statusLB.Font = new System.Drawing.Font("Asap SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLB.Location = new System.Drawing.Point(157, 177);
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(82, 26);
            this.statusLB.TabIndex = 25;
            this.statusLB.Text = "STATUS:";
            // 
            // amountLeftLB
            // 
            this.amountLeftLB.AutoSize = true;
            this.amountLeftLB.Font = new System.Drawing.Font("Asap Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLeftLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.amountLeftLB.Location = new System.Drawing.Point(257, 174);
            this.amountLeftLB.Name = "amountLeftLB";
            this.amountLeftLB.Size = new System.Drawing.Size(25, 30);
            this.amountLeftLB.TabIndex = 26;
            this.amountLeftLB.Text = "0";
            // 
            // StudentTuitionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amountLeftLB);
            this.Controls.Add(this.statusLB);
            this.Controls.Add(this.amountLB);
            this.Controls.Add(this.payBT);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.tuitionLB);
            this.Name = "StudentTuitionUC";
            this.Size = new System.Drawing.Size(783, 409);
            this.Load += new System.EventHandler(this.StudentTuitionUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button payBT;
        public System.Windows.Forms.TextBox amountTB;
        public System.Windows.Forms.Label amountLB;
        public System.Windows.Forms.Label statusLB;
        public System.Windows.Forms.Label amountLeftLB;
        public System.Windows.Forms.Label tuitionLB;
    }
}
