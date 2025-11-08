namespace STUDENT_MS
{
    partial class LecturerHomeUC
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
            this.informationLB = new System.Windows.Forms.Label();
            this.welcomeLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // informationLB
            // 
            this.informationLB.AutoSize = true;
            this.informationLB.Font = new System.Drawing.Font("Asap SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLB.Location = new System.Drawing.Point(21, 65);
            this.informationLB.Name = "informationLB";
            this.informationLB.Size = new System.Drawing.Size(131, 24);
            this.informationLB.TabIndex = 6;
            this.informationLB.Text = "INFORMATION:";
            // 
            // welcomeLB
            // 
            this.welcomeLB.AutoSize = true;
            this.welcomeLB.Font = new System.Drawing.Font("Asap", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.welcomeLB.Location = new System.Drawing.Point(18, 16);
            this.welcomeLB.Name = "welcomeLB";
            this.welcomeLB.Size = new System.Drawing.Size(153, 37);
            this.welcomeLB.TabIndex = 5;
            this.welcomeLB.Text = "WELCOME!";
            // 
            // LecturerHomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.informationLB);
            this.Controls.Add(this.welcomeLB);
            this.Name = "LecturerHomeUC";
            this.Size = new System.Drawing.Size(870, 440);
            this.Load += new System.EventHandler(this.LecturerHomeUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label informationLB;
        public System.Windows.Forms.Label welcomeLB;
    }
}
