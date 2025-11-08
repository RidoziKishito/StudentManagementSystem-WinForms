namespace STUDENT_MS
{
    partial class SalaryUC
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
            this.academicQalDB = new System.Windows.Forms.ComboBox();
            this.academicQalLB = new System.Windows.Forms.Label();
            this.informLB = new System.Windows.Forms.Label();
            this.salaryLB = new System.Windows.Forms.Label();
            this.currentSalaryLB = new System.Windows.Forms.Label();
            this.submitBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // academicQalDB
            // 
            this.academicQalDB.FormattingEnabled = true;
            this.academicQalDB.Items.AddRange(new object[] {
            "Master",
            "PhD",
            "A.Professor",
            "Professor"});
            this.academicQalDB.Location = new System.Drawing.Point(295, 111);
            this.academicQalDB.Name = "academicQalDB";
            this.academicQalDB.Size = new System.Drawing.Size(261, 24);
            this.academicQalDB.TabIndex = 0;
            // 
            // academicQalLB
            // 
            this.academicQalLB.AutoSize = true;
            this.academicQalLB.Font = new System.Drawing.Font("Asap SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicQalLB.Location = new System.Drawing.Point(70, 109);
            this.academicQalLB.Name = "academicQalLB";
            this.academicQalLB.Size = new System.Drawing.Size(219, 26);
            this.academicQalLB.TabIndex = 1;
            this.academicQalLB.Text = "Academic Qualification";
            // 
            // informLB
            // 
            this.informLB.AutoSize = true;
            this.informLB.Font = new System.Drawing.Font("Asap SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.informLB.Location = new System.Drawing.Point(69, 64);
            this.informLB.Name = "informLB";
            this.informLB.Size = new System.Drawing.Size(600, 26);
            this.informLB.TabIndex = 2;
            this.informLB.Text = "NOTE: Submit your new Academic Qualification for higher SALARY!\r\n";
            // 
            // salaryLB
            // 
            this.salaryLB.AutoSize = true;
            this.salaryLB.Font = new System.Drawing.Font("Asap SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLB.Location = new System.Drawing.Point(70, 161);
            this.salaryLB.Name = "salaryLB";
            this.salaryLB.Size = new System.Drawing.Size(76, 26);
            this.salaryLB.TabIndex = 4;
            this.salaryLB.Text = "Salary: ";
            // 
            // currentSalaryLB
            // 
            this.currentSalaryLB.AutoSize = true;
            this.currentSalaryLB.Font = new System.Drawing.Font("Asap SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSalaryLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.currentSalaryLB.Location = new System.Drawing.Point(152, 161);
            this.currentSalaryLB.Name = "currentSalaryLB";
            this.currentSalaryLB.Size = new System.Drawing.Size(45, 26);
            this.currentSalaryLB.TabIndex = 5;
            this.currentSalaryLB.Text = "000";
            // 
            // submitBT
            // 
            this.submitBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBT.Location = new System.Drawing.Point(562, 107);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(124, 28);
            this.submitBT.TabIndex = 12;
            this.submitBT.Text = "SUBMIT";
            this.submitBT.UseVisualStyleBackColor = true;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // SalaryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.currentSalaryLB);
            this.Controls.Add(this.salaryLB);
            this.Controls.Add(this.informLB);
            this.Controls.Add(this.academicQalLB);
            this.Controls.Add(this.academicQalDB);
            this.Name = "SalaryUC";
            this.Size = new System.Drawing.Size(813, 483);
            this.Load += new System.EventHandler(this.SalaryUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox academicQalDB;
        private System.Windows.Forms.Label academicQalLB;
        private System.Windows.Forms.Label informLB;
        private System.Windows.Forms.Label salaryLB;
        private System.Windows.Forms.Label currentSalaryLB;
        private System.Windows.Forms.Button submitBT;
    }
}
