namespace STUDENT_MS
{
    partial class LecturerResultUC
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
            this.resultDGV = new System.Windows.Forms.DataGridView();
            this.studentIDTB = new System.Windows.Forms.TextBox();
            this.printBT = new System.Windows.Forms.Button();
            this.chooseStudentBT = new System.Windows.Forms.Button();
            this.studentListDGV = new System.Windows.Forms.DataGridView();
            this.removeIDTB = new System.Windows.Forms.TextBox();
            this.assignBT = new System.Windows.Forms.Button();
            this.gradeTB = new System.Windows.Forms.TextBox();
            this.finalGradeTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // resultDGV
            // 
            this.resultDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDGV.Location = new System.Drawing.Point(51, 69);
            this.resultDGV.Name = "resultDGV";
            this.resultDGV.RowHeadersWidth = 51;
            this.resultDGV.RowTemplate.Height = 24;
            this.resultDGV.Size = new System.Drawing.Size(618, 340);
            this.resultDGV.TabIndex = 2;
            this.resultDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDGV_CellContentClick);
            // 
            // studentIDTB
            // 
            this.studentIDTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTB.ForeColor = System.Drawing.Color.Gray;
            this.studentIDTB.Location = new System.Drawing.Point(51, 30);
            this.studentIDTB.Name = "studentIDTB";
            this.studentIDTB.Size = new System.Drawing.Size(112, 22);
            this.studentIDTB.TabIndex = 26;
            this.studentIDTB.Text = "Student ID";
            this.studentIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentIDTB.TextChanged += new System.EventHandler(this.studentIDTB_TextChanged);
            this.studentIDTB.Enter += new System.EventHandler(this.studentIDTB_Enter);
            this.studentIDTB.Leave += new System.EventHandler(this.studentIDTB_Leave);
            // 
            // printBT
            // 
            this.printBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBT.Location = new System.Drawing.Point(797, 427);
            this.printBT.Name = "printBT";
            this.printBT.Size = new System.Drawing.Size(124, 28);
            this.printBT.TabIndex = 27;
            this.printBT.Text = "PRINT";
            this.printBT.UseVisualStyleBackColor = true;
            this.printBT.Click += new System.EventHandler(this.printBT_Click);
            // 
            // chooseStudentBT
            // 
            this.chooseStudentBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseStudentBT.Location = new System.Drawing.Point(181, 24);
            this.chooseStudentBT.Name = "chooseStudentBT";
            this.chooseStudentBT.Size = new System.Drawing.Size(124, 28);
            this.chooseStudentBT.TabIndex = 28;
            this.chooseStudentBT.Text = "CONFIRM";
            this.chooseStudentBT.UseVisualStyleBackColor = true;
            this.chooseStudentBT.Click += new System.EventHandler(this.chooseStudentBT_Click);
            // 
            // studentListDGV
            // 
            this.studentListDGV.ColumnHeadersHeight = 29;
            this.studentListDGV.Location = new System.Drawing.Point(694, 69);
            this.studentListDGV.Name = "studentListDGV";
            this.studentListDGV.RowHeadersWidth = 51;
            this.studentListDGV.Size = new System.Drawing.Size(227, 340);
            this.studentListDGV.TabIndex = 0;
            // 
            // removeIDTB
            // 
            this.removeIDTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIDTB.ForeColor = System.Drawing.Color.Gray;
            this.removeIDTB.Location = new System.Drawing.Point(181, 433);
            this.removeIDTB.Name = "removeIDTB";
            this.removeIDTB.Size = new System.Drawing.Size(112, 22);
            this.removeIDTB.TabIndex = 24;
            this.removeIDTB.Text = "Course ID";
            this.removeIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removeIDTB.TextChanged += new System.EventHandler(this.removeIDTB_TextChanged);
            this.removeIDTB.Enter += new System.EventHandler(this.removeIDTB_Enter);
            this.removeIDTB.Leave += new System.EventHandler(this.removeIDTB_Leave);
            // 
            // assignBT
            // 
            this.assignBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignBT.Location = new System.Drawing.Point(51, 430);
            this.assignBT.Name = "assignBT";
            this.assignBT.Size = new System.Drawing.Size(124, 28);
            this.assignBT.TabIndex = 25;
            this.assignBT.Text = "ASSIGN";
            this.assignBT.UseVisualStyleBackColor = true;
            this.assignBT.Click += new System.EventHandler(this.assignBT_Click);
            // 
            // gradeTB
            // 
            this.gradeTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTB.ForeColor = System.Drawing.Color.Gray;
            this.gradeTB.Location = new System.Drawing.Point(299, 433);
            this.gradeTB.Name = "gradeTB";
            this.gradeTB.Size = new System.Drawing.Size(96, 22);
            this.gradeTB.TabIndex = 29;
            this.gradeTB.Text = "Midterm";
            this.gradeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gradeTB.Enter += new System.EventHandler(this.gradeTB_Enter);
            this.gradeTB.Leave += new System.EventHandler(this.gradeTB_Leave);
            // 
            // finalGradeTB
            // 
            this.finalGradeTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalGradeTB.ForeColor = System.Drawing.Color.Gray;
            this.finalGradeTB.Location = new System.Drawing.Point(401, 433);
            this.finalGradeTB.Name = "finalGradeTB";
            this.finalGradeTB.Size = new System.Drawing.Size(96, 22);
            this.finalGradeTB.TabIndex = 30;
            this.finalGradeTB.Text = "Final";
            this.finalGradeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalGradeTB.Enter += new System.EventHandler(this.finalGradeTB_Enter);
            this.finalGradeTB.Leave += new System.EventHandler(this.finalGradeTB_Leave);
            // 
            // LecturerResultUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studentListDGV);
            this.Controls.Add(this.finalGradeTB);
            this.Controls.Add(this.gradeTB);
            this.Controls.Add(this.chooseStudentBT);
            this.Controls.Add(this.printBT);
            this.Controls.Add(this.studentIDTB);
            this.Controls.Add(this.assignBT);
            this.Controls.Add(this.removeIDTB);
            this.Controls.Add(this.resultDGV);
            this.Name = "LecturerResultUC";
            this.Size = new System.Drawing.Size(994, 493);
            this.Load += new System.EventHandler(this.LecturerResultUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView resultDGV;
        public System.Windows.Forms.TextBox studentIDTB;
        public System.Windows.Forms.Button printBT;
        public System.Windows.Forms.Button chooseStudentBT;
        public System.Windows.Forms.DataGridView studentListDGV;
        public System.Windows.Forms.TextBox removeIDTB;
        public System.Windows.Forms.Button assignBT;
        public System.Windows.Forms.TextBox gradeTB;
        public System.Windows.Forms.TextBox finalGradeTB;
    }
}
