namespace STUDENT_MS
{
    partial class EditLecturerUC
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
            this.removeGB = new System.Windows.Forms.GroupBox();
            this.removeIDTB = new System.Windows.Forms.TextBox();
            this.removeBT = new System.Windows.Forms.Button();
            this.addGB = new System.Windows.Forms.GroupBox();
            this.academicQualLB = new System.Windows.Forms.Label();
            this.academicQalDB = new System.Windows.Forms.ComboBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.hireDayLB = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.hireDayDTP = new System.Windows.Forms.DateTimePicker();
            this.addBT = new System.Windows.Forms.Button();
            this.dobDTP = new System.Windows.Forms.DateTimePicker();
            this.dobLB = new System.Windows.Forms.Label();
            this.fIDTB = new System.Windows.Forms.TextBox();
            this.genderLB = new System.Windows.Forms.Label();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.lecturerDGV = new System.Windows.Forms.DataGridView();
            this.nextUCLB = new System.Windows.Forms.Label();
            this.removeGB.SuspendLayout();
            this.addGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // removeGB
            // 
            this.removeGB.Controls.Add(this.removeIDTB);
            this.removeGB.Controls.Add(this.removeBT);
            this.removeGB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGB.Location = new System.Drawing.Point(219, 495);
            this.removeGB.Name = "removeGB";
            this.removeGB.Size = new System.Drawing.Size(674, 63);
            this.removeGB.TabIndex = 53;
            this.removeGB.TabStop = false;
            this.removeGB.Text = "Remove Lecturer";
            // 
            // removeIDTB
            // 
            this.removeIDTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIDTB.ForeColor = System.Drawing.Color.Gray;
            this.removeIDTB.Location = new System.Drawing.Point(10, 27);
            this.removeIDTB.Name = "removeIDTB";
            this.removeIDTB.Size = new System.Drawing.Size(555, 22);
            this.removeIDTB.TabIndex = 49;
            this.removeIDTB.Text = "Lecturer ID to Remove";
            this.removeIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removeIDTB.Enter += new System.EventHandler(this.removeIDTB_Enter);
            this.removeIDTB.Leave += new System.EventHandler(this.removeIDTB_Leave);
            // 
            // removeBT
            // 
            this.removeBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBT.Location = new System.Drawing.Point(571, 21);
            this.removeBT.Name = "removeBT";
            this.removeBT.Size = new System.Drawing.Size(97, 36);
            this.removeBT.TabIndex = 40;
            this.removeBT.Text = "REMOVE";
            this.removeBT.UseVisualStyleBackColor = true;
            this.removeBT.Click += new System.EventHandler(this.removeBT_Click);
            // 
            // addGB
            // 
            this.addGB.Controls.Add(this.academicQualLB);
            this.addGB.Controls.Add(this.academicQalDB);
            this.addGB.Controls.Add(this.idTB);
            this.addGB.Controls.Add(this.hireDayLB);
            this.addGB.Controls.Add(this.nameTB);
            this.addGB.Controls.Add(this.hireDayDTP);
            this.addGB.Controls.Add(this.addBT);
            this.addGB.Controls.Add(this.dobDTP);
            this.addGB.Controls.Add(this.dobLB);
            this.addGB.Controls.Add(this.fIDTB);
            this.addGB.Controls.Add(this.genderLB);
            this.addGB.Controls.Add(this.genderCB);
            this.addGB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGB.Location = new System.Drawing.Point(41, 304);
            this.addGB.Name = "addGB";
            this.addGB.Size = new System.Drawing.Size(852, 173);
            this.addGB.TabIndex = 52;
            this.addGB.TabStop = false;
            this.addGB.Text = "Add Lecturer";
            // 
            // academicQualLB
            // 
            this.academicQualLB.AutoSize = true;
            this.academicQualLB.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicQualLB.Location = new System.Drawing.Point(258, 90);
            this.academicQualLB.Name = "academicQualLB";
            this.academicQualLB.Size = new System.Drawing.Size(191, 22);
            this.academicQualLB.TabIndex = 49;
            this.academicQualLB.Text = "Academic Qualification :";
            // 
            // academicQalDB
            // 
            this.academicQalDB.Font = new System.Drawing.Font("Asap", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicQalDB.ForeColor = System.Drawing.Color.Black;
            this.academicQalDB.FormattingEnabled = true;
            this.academicQalDB.Items.AddRange(new object[] {
            "Master",
            "PhD",
            "A.Professor",
            "Professor"});
            this.academicQalDB.Location = new System.Drawing.Point(455, 89);
            this.academicQalDB.Name = "academicQalDB";
            this.academicQalDB.Size = new System.Drawing.Size(301, 28);
            this.academicQalDB.TabIndex = 48;
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.ForeColor = System.Drawing.Color.Gray;
            this.idTB.Location = new System.Drawing.Point(10, 42);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(263, 22);
            this.idTB.TabIndex = 38;
            this.idTB.Text = "Lecturer ID";
            this.idTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idTB.Enter += new System.EventHandler(this.idTB_Enter);
            this.idTB.Leave += new System.EventHandler(this.idTB_Leave);
            // 
            // hireDayLB
            // 
            this.hireDayLB.AutoSize = true;
            this.hireDayLB.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireDayLB.Location = new System.Drawing.Point(364, 131);
            this.hireDayLB.Name = "hireDayLB";
            this.hireDayLB.Size = new System.Drawing.Size(85, 22);
            this.hireDayLB.TabIndex = 47;
            this.hireDayLB.Text = "Hire Date:";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.ForeColor = System.Drawing.Color.Gray;
            this.nameTB.Location = new System.Drawing.Point(279, 42);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(352, 22);
            this.nameTB.TabIndex = 36;
            this.nameTB.Text = "Full name";
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            this.nameTB.Enter += new System.EventHandler(this.nameTB_Enter);
            this.nameTB.Leave += new System.EventHandler(this.nameTB_Leave);
            // 
            // hireDayDTP
            // 
            this.hireDayDTP.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireDayDTP.Location = new System.Drawing.Point(455, 131);
            this.hireDayDTP.Name = "hireDayDTP";
            this.hireDayDTP.Size = new System.Drawing.Size(266, 22);
            this.hireDayDTP.TabIndex = 46;
            // 
            // addBT
            // 
            this.addBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBT.Location = new System.Drawing.Point(762, 42);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(84, 111);
            this.addBT.TabIndex = 37;
            this.addBT.Text = "ADD";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // dobDTP
            // 
            this.dobDTP.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDTP.Location = new System.Drawing.Point(57, 131);
            this.dobDTP.Name = "dobDTP";
            this.dobDTP.Size = new System.Drawing.Size(256, 22);
            this.dobDTP.TabIndex = 45;
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
            // fIDTB
            // 
            this.fIDTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIDTB.ForeColor = System.Drawing.Color.Gray;
            this.fIDTB.Location = new System.Drawing.Point(637, 42);
            this.fIDTB.Name = "fIDTB";
            this.fIDTB.Size = new System.Drawing.Size(119, 22);
            this.fIDTB.TabIndex = 41;
            this.fIDTB.Text = "Faculty ID";
            this.fIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fIDTB.Enter += new System.EventHandler(this.fIDTB_Enter);
            this.fIDTB.Leave += new System.EventHandler(this.fIDTB_Leave);
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
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.genderCB.Location = new System.Drawing.Point(89, 85);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(152, 32);
            this.genderCB.TabIndex = 42;
            // 
            // lecturerDGV
            // 
            this.lecturerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lecturerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturerDGV.Location = new System.Drawing.Point(41, 18);
            this.lecturerDGV.Name = "lecturerDGV";
            this.lecturerDGV.RowHeadersWidth = 51;
            this.lecturerDGV.RowTemplate.Height = 24;
            this.lecturerDGV.Size = new System.Drawing.Size(852, 280);
            this.lecturerDGV.TabIndex = 51;
            // 
            // nextUCLB
            // 
            this.nextUCLB.AutoSize = true;
            this.nextUCLB.Font = new System.Drawing.Font("Asap Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextUCLB.ForeColor = System.Drawing.Color.Navy;
            this.nextUCLB.Location = new System.Drawing.Point(47, 514);
            this.nextUCLB.Name = "nextUCLB";
            this.nextUCLB.Size = new System.Drawing.Size(136, 22);
            this.nextUCLB.TabIndex = 54;
            this.nextUCLB.Text = "<< Go to Student";
            this.nextUCLB.Click += new System.EventHandler(this.nextUCLB_Click);
            // 
            // EditLecturerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nextUCLB);
            this.Controls.Add(this.removeGB);
            this.Controls.Add(this.addGB);
            this.Controls.Add(this.lecturerDGV);
            this.Name = "EditLecturerUC";
            this.Size = new System.Drawing.Size(928, 583);
            this.Load += new System.EventHandler(this.EditLecturerUC_Load);
            this.removeGB.ResumeLayout(false);
            this.removeGB.PerformLayout();
            this.addGB.ResumeLayout(false);
            this.addGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox removeGB;
        public System.Windows.Forms.TextBox removeIDTB;
        public System.Windows.Forms.Button removeBT;
        private System.Windows.Forms.GroupBox addGB;
        public System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label hireDayLB;
        public System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.DateTimePicker hireDayDTP;
        public System.Windows.Forms.Button addBT;
        private System.Windows.Forms.DateTimePicker dobDTP;
        private System.Windows.Forms.Label dobLB;
        public System.Windows.Forms.TextBox fIDTB;
        private System.Windows.Forms.Label genderLB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.DataGridView lecturerDGV;
        private System.Windows.Forms.ComboBox academicQalDB;
        private System.Windows.Forms.Label nextUCLB;
        private System.Windows.Forms.Label academicQualLB;
    }
}
