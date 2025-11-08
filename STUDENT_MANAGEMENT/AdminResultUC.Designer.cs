namespace STUDENT_MS
{
    partial class AdminResultUC
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
            this.chooseStudentBT = new System.Windows.Forms.Button();
            this.studentIDTB = new System.Windows.Forms.TextBox();
            this.resultDGV = new System.Windows.Forms.DataGridView();
            this.printBT = new System.Windows.Forms.Button();
            this.showAllBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseStudentBT
            // 
            this.chooseStudentBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseStudentBT.Location = new System.Drawing.Point(176, 19);
            this.chooseStudentBT.Name = "chooseStudentBT";
            this.chooseStudentBT.Size = new System.Drawing.Size(124, 28);
            this.chooseStudentBT.TabIndex = 31;
            this.chooseStudentBT.Text = "CONFIRM";
            this.chooseStudentBT.UseVisualStyleBackColor = true;
            this.chooseStudentBT.Click += new System.EventHandler(this.chooseStudentBT_Click);
            // 
            // studentIDTB
            // 
            this.studentIDTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTB.ForeColor = System.Drawing.Color.Gray;
            this.studentIDTB.Location = new System.Drawing.Point(58, 22);
            this.studentIDTB.Name = "studentIDTB";
            this.studentIDTB.Size = new System.Drawing.Size(112, 22);
            this.studentIDTB.TabIndex = 30;
            this.studentIDTB.Text = "Student ID";
            this.studentIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentIDTB.Enter += new System.EventHandler(this.studentIDTB_Enter);
            this.studentIDTB.Leave += new System.EventHandler(this.studentIDTB_Leave);
            // 
            // resultDGV
            // 
            this.resultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDGV.Location = new System.Drawing.Point(25, 53);
            this.resultDGV.Name = "resultDGV";
            this.resultDGV.RowHeadersWidth = 51;
            this.resultDGV.RowTemplate.Height = 24;
            this.resultDGV.Size = new System.Drawing.Size(889, 340);
            this.resultDGV.TabIndex = 29;
            // 
            // printBT
            // 
            this.printBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBT.Location = new System.Drawing.Point(790, 416);
            this.printBT.Name = "printBT";
            this.printBT.Size = new System.Drawing.Size(124, 35);
            this.printBT.TabIndex = 32;
            this.printBT.Text = "PRINT";
            this.printBT.UseVisualStyleBackColor = true;
            this.printBT.Click += new System.EventHandler(this.printBT_Click);
            // 
            // showAllBT
            // 
            this.showAllBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBT.Location = new System.Drawing.Point(306, 19);
            this.showAllBT.Name = "showAllBT";
            this.showAllBT.Size = new System.Drawing.Size(124, 28);
            this.showAllBT.TabIndex = 33;
            this.showAllBT.Text = "SHOW ALL";
            this.showAllBT.UseVisualStyleBackColor = true;
            this.showAllBT.Click += new System.EventHandler(this.showAllBT_Click);
            // 
            // AdminResultUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showAllBT);
            this.Controls.Add(this.printBT);
            this.Controls.Add(this.chooseStudentBT);
            this.Controls.Add(this.studentIDTB);
            this.Controls.Add(this.resultDGV);
            this.Name = "AdminResultUC";
            this.Size = new System.Drawing.Size(941, 476);
            this.Load += new System.EventHandler(this.AdminResultUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button chooseStudentBT;
        public System.Windows.Forms.TextBox studentIDTB;
        public System.Windows.Forms.DataGridView resultDGV;
        public System.Windows.Forms.Button printBT;
        public System.Windows.Forms.Button showAllBT;
    }
}
