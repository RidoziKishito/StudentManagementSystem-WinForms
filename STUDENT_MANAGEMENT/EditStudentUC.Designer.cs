namespace STUDENT_MS
{
    partial class EditStudentUC
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
            this.studentDGV = new System.Windows.Forms.DataGridView();
            this.removeBT = new System.Windows.Forms.Button();
            this.majorTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.addBT = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.fIDTB = new System.Windows.Forms.TextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.genderLB = new System.Windows.Forms.Label();
            this.dobLB = new System.Windows.Forms.Label();
            this.dobDTP = new System.Windows.Forms.DateTimePicker();
            this.studyDayDTP = new System.Windows.Forms.DateTimePicker();
            this.studyDayLB = new System.Windows.Forms.Label();
            this.addStudentGB = new System.Windows.Forms.GroupBox();
            this.removeIDTB = new System.Windows.Forms.TextBox();
            this.removeStudentGB = new System.Windows.Forms.GroupBox();
            this.studenT_MSDataSet1 = new STUDENT_MS.STUDENT_MSDataSet();
            this.nextUCLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).BeginInit();
            this.addStudentGB.SuspendLayout();
            this.removeStudentGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studenT_MSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDGV
            // 
            this.studentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDGV.Location = new System.Drawing.Point(35, 17);
            this.studentDGV.Name = "studentDGV";
            this.studentDGV.RowHeadersWidth = 51;
            this.studentDGV.RowTemplate.Height = 24;
            this.studentDGV.Size = new System.Drawing.Size(880, 286);
            this.studentDGV.TabIndex = 0;
            // 
            // removeBT
            // 
            this.removeBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBT.Location = new System.Drawing.Point(627, 20);
            this.removeBT.Name = "removeBT";
            this.removeBT.Size = new System.Drawing.Size(97, 36);
            this.removeBT.TabIndex = 40;
            this.removeBT.Text = "REMOVE";
            this.removeBT.UseVisualStyleBackColor = true;
            this.removeBT.Click += new System.EventHandler(this.removeBT_Click);
            // 
            // majorTB
            // 
            this.majorTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorTB.ForeColor = System.Drawing.Color.Gray;
            this.majorTB.Location = new System.Drawing.Point(399, 88);
            this.majorTB.Name = "majorTB";
            this.majorTB.Size = new System.Drawing.Size(325, 22);
            this.majorTB.TabIndex = 39;
            this.majorTB.Text = "Major";
            this.majorTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.majorTB.Enter += new System.EventHandler(this.majorTB_Enter);
            this.majorTB.Leave += new System.EventHandler(this.majorTB_Leave);
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.ForeColor = System.Drawing.Color.Gray;
            this.idTB.Location = new System.Drawing.Point(32, 42);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(225, 22);
            this.idTB.TabIndex = 38;
            this.idTB.Text = "Student ID";
            this.idTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idTB.Enter += new System.EventHandler(this.idTB_Enter);
            this.idTB.Leave += new System.EventHandler(this.idTB_Leave);
            // 
            // addBT
            // 
            this.addBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBT.Location = new System.Drawing.Point(760, 42);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(97, 111);
            this.addBT.TabIndex = 37;
            this.addBT.Text = "ADD";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.ForeColor = System.Drawing.Color.Gray;
            this.nameTB.Location = new System.Drawing.Point(269, 42);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(455, 22);
            this.nameTB.TabIndex = 36;
            this.nameTB.Text = "Full name";
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTB.Enter += new System.EventHandler(this.nameTB_Enter);
            this.nameTB.Leave += new System.EventHandler(this.nameTB_Leave);
            // 
            // fIDTB
            // 
            this.fIDTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIDTB.ForeColor = System.Drawing.Color.Gray;
            this.fIDTB.Location = new System.Drawing.Point(206, 88);
            this.fIDTB.Name = "fIDTB";
            this.fIDTB.Size = new System.Drawing.Size(187, 22);
            this.fIDTB.TabIndex = 41;
            this.fIDTB.Text = "Faculty ID";
            this.fIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fIDTB.Enter += new System.EventHandler(this.fIDTB_Enter);
            this.fIDTB.Leave += new System.EventHandler(this.fIDTB_Leave);
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.genderCB.Location = new System.Drawing.Point(79, 86);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(121, 32);
            this.genderCB.TabIndex = 42;
            // 
            // genderLB
            // 
            this.genderLB.AutoSize = true;
            this.genderLB.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLB.Location = new System.Drawing.Point(6, 87);
            this.genderLB.Name = "genderLB";
            this.genderLB.Size = new System.Drawing.Size(67, 22);
            this.genderLB.TabIndex = 43;
            this.genderLB.Text = "Gender:";
            // 
            // dobLB
            // 
            this.dobLB.AutoSize = true;
            this.dobLB.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLB.Location = new System.Drawing.Point(6, 131);
            this.dobLB.Name = "dobLB";
            this.dobLB.Size = new System.Drawing.Size(45, 22);
            this.dobLB.TabIndex = 44;
            this.dobLB.Text = "DoB:";
            // 
            // dobDTP
            // 
            this.dobDTP.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDTP.Location = new System.Drawing.Point(79, 131);
            this.dobDTP.Name = "dobDTP";
            this.dobDTP.Size = new System.Drawing.Size(257, 22);
            this.dobDTP.TabIndex = 45;
            // 
            // studyDayDTP
            // 
            this.studyDayDTP.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyDayDTP.Location = new System.Drawing.Point(452, 130);
            this.studyDayDTP.Name = "studyDayDTP";
            this.studyDayDTP.Size = new System.Drawing.Size(272, 22);
            this.studyDayDTP.TabIndex = 46;
            // 
            // studyDayLB
            // 
            this.studyDayLB.AutoSize = true;
            this.studyDayLB.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyDayLB.Location = new System.Drawing.Point(352, 132);
            this.studyDayLB.Name = "studyDayLB";
            this.studyDayLB.Size = new System.Drawing.Size(94, 22);
            this.studyDayLB.TabIndex = 47;
            this.studyDayLB.Text = "Study Date:";
            // 
            // addStudentGB
            // 
            this.addStudentGB.Controls.Add(this.idTB);
            this.addStudentGB.Controls.Add(this.studyDayLB);
            this.addStudentGB.Controls.Add(this.nameTB);
            this.addStudentGB.Controls.Add(this.studyDayDTP);
            this.addStudentGB.Controls.Add(this.addBT);
            this.addStudentGB.Controls.Add(this.dobDTP);
            this.addStudentGB.Controls.Add(this.majorTB);
            this.addStudentGB.Controls.Add(this.dobLB);
            this.addStudentGB.Controls.Add(this.fIDTB);
            this.addStudentGB.Controls.Add(this.genderLB);
            this.addStudentGB.Controls.Add(this.genderCB);
            this.addStudentGB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentGB.Location = new System.Drawing.Point(35, 309);
            this.addStudentGB.Name = "addStudentGB";
            this.addStudentGB.Size = new System.Drawing.Size(880, 173);
            this.addStudentGB.TabIndex = 48;
            this.addStudentGB.TabStop = false;
            this.addStudentGB.Text = "Add Student";
            this.addStudentGB.Enter += new System.EventHandler(this.addStudentGB_Enter);
            // 
            // removeIDTB
            // 
            this.removeIDTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIDTB.ForeColor = System.Drawing.Color.Gray;
            this.removeIDTB.Location = new System.Drawing.Point(10, 27);
            this.removeIDTB.Name = "removeIDTB";
            this.removeIDTB.Size = new System.Drawing.Size(602, 22);
            this.removeIDTB.TabIndex = 49;
            this.removeIDTB.Text = "Student ID to Remove";
            this.removeIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removeIDTB.Enter += new System.EventHandler(this.removeIDTB_Enter);
            this.removeIDTB.Leave += new System.EventHandler(this.removeIDTB_Leave);
            // 
            // removeStudentGB
            // 
            this.removeStudentGB.Controls.Add(this.removeIDTB);
            this.removeStudentGB.Controls.Add(this.removeBT);
            this.removeStudentGB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStudentGB.Location = new System.Drawing.Point(35, 488);
            this.removeStudentGB.Name = "removeStudentGB";
            this.removeStudentGB.Size = new System.Drawing.Size(734, 63);
            this.removeStudentGB.TabIndex = 50;
            this.removeStudentGB.TabStop = false;
            this.removeStudentGB.Text = "Remove Student";
            // 
            // studenT_MSDataSet1
            // 
            this.studenT_MSDataSet1.DataSetName = "STUDENT_MSDataSet";
            this.studenT_MSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nextUCLB
            // 
            this.nextUCLB.AutoSize = true;
            this.nextUCLB.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextUCLB.ForeColor = System.Drawing.Color.Navy;
            this.nextUCLB.Location = new System.Drawing.Point(775, 514);
            this.nextUCLB.Name = "nextUCLB";
            this.nextUCLB.Size = new System.Drawing.Size(140, 22);
            this.nextUCLB.TabIndex = 51;
            this.nextUCLB.Text = "Go to Lecturer >>";
            this.nextUCLB.Click += new System.EventHandler(this.nextUCLB_Click);
            // 
            // EditStudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nextUCLB);
            this.Controls.Add(this.removeStudentGB);
            this.Controls.Add(this.addStudentGB);
            this.Controls.Add(this.studentDGV);
            this.Name = "EditStudentUC";
            this.Size = new System.Drawing.Size(950, 567);
            this.Load += new System.EventHandler(this.EditStudentUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).EndInit();
            this.addStudentGB.ResumeLayout(false);
            this.addStudentGB.PerformLayout();
            this.removeStudentGB.ResumeLayout(false);
            this.removeStudentGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studenT_MSDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentDGV;
        public System.Windows.Forms.Button removeBT;
        public System.Windows.Forms.TextBox majorTB;
        public System.Windows.Forms.TextBox idTB;
        public System.Windows.Forms.Button addBT;
        public System.Windows.Forms.TextBox nameTB;
        public System.Windows.Forms.TextBox fIDTB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.Label genderLB;
        private System.Windows.Forms.Label dobLB;
        private System.Windows.Forms.DateTimePicker dobDTP;
        private System.Windows.Forms.DateTimePicker studyDayDTP;
        private System.Windows.Forms.Label studyDayLB;
        private System.Windows.Forms.GroupBox addStudentGB;
        public System.Windows.Forms.TextBox removeIDTB;
        private System.Windows.Forms.GroupBox removeStudentGB;
        private STUDENT_MSDataSet studenT_MSDataSet1;
        private System.Windows.Forms.Label nextUCLB;
    }
}
