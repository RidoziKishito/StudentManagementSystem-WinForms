namespace STUDENT_MS
{
    partial class EditCourseUC
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
            this.studentCourseDGV = new System.Windows.Forms.DataGridView();
            this.courseIDTB = new System.Windows.Forms.TextBox();
            this.courseCreditTB = new System.Windows.Forms.TextBox();
            this.courseNameTB = new System.Windows.Forms.TextBox();
            this.startDayDTP = new System.Windows.Forms.DateTimePicker();
            this.endDayDTP = new System.Windows.Forms.DateTimePicker();
            this.couseIDLB = new System.Windows.Forms.Label();
            this.nameLB = new System.Windows.Forms.Label();
            this.creditLB = new System.Windows.Forms.Label();
            this.startDayLB = new System.Windows.Forms.Label();
            this.endDayLB = new System.Windows.Forms.Label();
            this.addCourseBT = new System.Windows.Forms.Button();
            this.removeIDTB = new System.Windows.Forms.TextBox();
            this.removeBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // studentCourseDGV
            // 
            this.studentCourseDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentCourseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentCourseDGV.Location = new System.Drawing.Point(67, 175);
            this.studentCourseDGV.Name = "studentCourseDGV";
            this.studentCourseDGV.RowHeadersWidth = 51;
            this.studentCourseDGV.RowTemplate.Height = 24;
            this.studentCourseDGV.Size = new System.Drawing.Size(752, 300);
            this.studentCourseDGV.TabIndex = 0;
            // 
            // courseIDTB
            // 
            this.courseIDTB.Location = new System.Drawing.Point(101, 28);
            this.courseIDTB.Name = "courseIDTB";
            this.courseIDTB.Size = new System.Drawing.Size(178, 22);
            this.courseIDTB.TabIndex = 1;
            // 
            // courseCreditTB
            // 
            this.courseCreditTB.Location = new System.Drawing.Point(364, 28);
            this.courseCreditTB.Name = "courseCreditTB";
            this.courseCreditTB.Size = new System.Drawing.Size(99, 22);
            this.courseCreditTB.TabIndex = 2;
            // 
            // courseNameTB
            // 
            this.courseNameTB.Location = new System.Drawing.Point(550, 29);
            this.courseNameTB.Name = "courseNameTB";
            this.courseNameTB.Size = new System.Drawing.Size(269, 22);
            this.courseNameTB.TabIndex = 3;
            // 
            // startDayDTP
            // 
            this.startDayDTP.CalendarFont = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDayDTP.Location = new System.Drawing.Point(258, 78);
            this.startDayDTP.Name = "startDayDTP";
            this.startDayDTP.Size = new System.Drawing.Size(258, 22);
            this.startDayDTP.TabIndex = 4;
            // 
            // endDayDTP
            // 
            this.endDayDTP.Location = new System.Drawing.Point(258, 121);
            this.endDayDTP.Name = "endDayDTP";
            this.endDayDTP.Size = new System.Drawing.Size(258, 22);
            this.endDayDTP.TabIndex = 5;
            // 
            // couseIDLB
            // 
            this.couseIDLB.AutoSize = true;
            this.couseIDLB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couseIDLB.Location = new System.Drawing.Point(63, 26);
            this.couseIDLB.Name = "couseIDLB";
            this.couseIDLB.Size = new System.Drawing.Size(32, 24);
            this.couseIDLB.TabIndex = 6;
            this.couseIDLB.Text = "ID:";
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLB.Location = new System.Drawing.Point(482, 25);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(62, 24);
            this.nameLB.TabIndex = 7;
            this.nameLB.Text = "Name:";
            // 
            // creditLB
            // 
            this.creditLB.AutoSize = true;
            this.creditLB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLB.Location = new System.Drawing.Point(295, 25);
            this.creditLB.Name = "creditLB";
            this.creditLB.Size = new System.Drawing.Size(63, 24);
            this.creditLB.TabIndex = 8;
            this.creditLB.Text = "Credit:";
            // 
            // startDayLB
            // 
            this.startDayLB.AutoSize = true;
            this.startDayLB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDayLB.Location = new System.Drawing.Point(116, 77);
            this.startDayLB.Name = "startDayLB";
            this.startDayLB.Size = new System.Drawing.Size(120, 24);
            this.startDayLB.TabIndex = 9;
            this.startDayLB.Text = "Starting Date:";
            // 
            // endDayLB
            // 
            this.endDayLB.AutoSize = true;
            this.endDayLB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDayLB.Location = new System.Drawing.Point(124, 119);
            this.endDayLB.Name = "endDayLB";
            this.endDayLB.Size = new System.Drawing.Size(112, 24);
            this.endDayLB.TabIndex = 10;
            this.endDayLB.Text = "Ending Date:";
            // 
            // addCourseBT
            // 
            this.addCourseBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBT.Location = new System.Drawing.Point(550, 76);
            this.addCourseBT.Name = "addCourseBT";
            this.addCourseBT.Size = new System.Drawing.Size(124, 28);
            this.addCourseBT.TabIndex = 11;
            this.addCourseBT.Text = "ADD";
            this.addCourseBT.UseVisualStyleBackColor = true;
            this.addCourseBT.Click += new System.EventHandler(this.addCourseBT_Click);
            // 
            // removeIDTB
            // 
            this.removeIDTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIDTB.ForeColor = System.Drawing.Color.Gray;
            this.removeIDTB.Location = new System.Drawing.Point(197, 493);
            this.removeIDTB.Name = "removeIDTB";
            this.removeIDTB.Size = new System.Drawing.Size(245, 22);
            this.removeIDTB.TabIndex = 15;
            this.removeIDTB.Text = "Enter the course ID you want to remove";
            this.removeIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removeIDTB.Enter += new System.EventHandler(this.removeIDTB_Enter);
            this.removeIDTB.Leave += new System.EventHandler(this.removeIDTB_Leave);
            // 
            // removeBT
            // 
            this.removeBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBT.Location = new System.Drawing.Point(67, 487);
            this.removeBT.Name = "removeBT";
            this.removeBT.Size = new System.Drawing.Size(124, 28);
            this.removeBT.TabIndex = 16;
            this.removeBT.Text = "REMOVE";
            this.removeBT.UseVisualStyleBackColor = true;
            this.removeBT.Click += new System.EventHandler(this.removeBT_Click);
            // 
            // EditCourseUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeBT);
            this.Controls.Add(this.removeIDTB);
            this.Controls.Add(this.addCourseBT);
            this.Controls.Add(this.endDayLB);
            this.Controls.Add(this.startDayLB);
            this.Controls.Add(this.creditLB);
            this.Controls.Add(this.nameLB);
            this.Controls.Add(this.couseIDLB);
            this.Controls.Add(this.endDayDTP);
            this.Controls.Add(this.startDayDTP);
            this.Controls.Add(this.courseNameTB);
            this.Controls.Add(this.courseCreditTB);
            this.Controls.Add(this.courseIDTB);
            this.Controls.Add(this.studentCourseDGV);
            this.Name = "EditCourseUC";
            this.Size = new System.Drawing.Size(881, 540);
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox courseIDTB;
        private System.Windows.Forms.TextBox courseCreditTB;
        private System.Windows.Forms.TextBox courseNameTB;
        private System.Windows.Forms.DateTimePicker startDayDTP;
        private System.Windows.Forms.DateTimePicker endDayDTP;
        private System.Windows.Forms.Label couseIDLB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Label creditLB;
        private System.Windows.Forms.Label startDayLB;
        private System.Windows.Forms.Label endDayLB;
        private System.Windows.Forms.Button addCourseBT;
        private System.Windows.Forms.TextBox removeIDTB;
        private System.Windows.Forms.Button removeBT;
        public System.Windows.Forms.DataGridView studentCourseDGV;
    }
}
