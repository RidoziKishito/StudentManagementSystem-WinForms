namespace STUDENT_MS
{
    partial class StudentCourseUC
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
            this.allCourseDGV = new System.Windows.Forms.DataGridView();
            this.enrolledCourseDGV = new System.Windows.Forms.DataGridView();
            this.enrolledLB = new System.Windows.Forms.Label();
            this.allCourseLB = new System.Windows.Forms.Label();
            this.enrollBT = new System.Windows.Forms.Button();
            this.addCourseTB = new System.Windows.Forms.TextBox();
            this.removeBT = new System.Windows.Forms.Button();
            this.removeIDTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allCourseDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledCourseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // allCourseDGV
            // 
            this.allCourseDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allCourseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCourseDGV.Location = new System.Drawing.Point(114, 37);
            this.allCourseDGV.Name = "allCourseDGV";
            this.allCourseDGV.RowHeadersWidth = 51;
            this.allCourseDGV.RowTemplate.Height = 24;
            this.allCourseDGV.Size = new System.Drawing.Size(684, 165);
            this.allCourseDGV.TabIndex = 0;
            // 
            // enrolledCourseDGV
            // 
            this.enrolledCourseDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enrolledCourseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledCourseDGV.Location = new System.Drawing.Point(114, 305);
            this.enrolledCourseDGV.Name = "enrolledCourseDGV";
            this.enrolledCourseDGV.RowHeadersWidth = 51;
            this.enrolledCourseDGV.RowTemplate.Height = 24;
            this.enrolledCourseDGV.Size = new System.Drawing.Size(684, 150);
            this.enrolledCourseDGV.TabIndex = 1;
            // 
            // enrolledLB
            // 
            this.enrolledLB.AutoSize = true;
            this.enrolledLB.Font = new System.Drawing.Font("Asap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrolledLB.Location = new System.Drawing.Point(109, 267);
            this.enrolledLB.Name = "enrolledLB";
            this.enrolledLB.Size = new System.Drawing.Size(90, 26);
            this.enrolledLB.TabIndex = 18;
            this.enrolledLB.Text = "Enrolled:";
            // 
            // allCourseLB
            // 
            this.allCourseLB.AutoSize = true;
            this.allCourseLB.Font = new System.Drawing.Font("Asap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCourseLB.Location = new System.Drawing.Point(109, 8);
            this.allCourseLB.Name = "allCourseLB";
            this.allCourseLB.Size = new System.Drawing.Size(84, 26);
            this.allCourseLB.TabIndex = 19;
            this.allCourseLB.Text = "Courses:";
            // 
            // enrollBT
            // 
            this.enrollBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollBT.Location = new System.Drawing.Point(114, 219);
            this.enrollBT.Name = "enrollBT";
            this.enrollBT.Size = new System.Drawing.Size(124, 28);
            this.enrollBT.TabIndex = 21;
            this.enrollBT.Text = "ENROLL";
            this.enrollBT.UseVisualStyleBackColor = true;
            this.enrollBT.Click += new System.EventHandler(this.enrollBT_Click);
            // 
            // addCourseTB
            // 
            this.addCourseTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseTB.ForeColor = System.Drawing.Color.Gray;
            this.addCourseTB.Location = new System.Drawing.Point(259, 225);
            this.addCourseTB.Name = "addCourseTB";
            this.addCourseTB.Size = new System.Drawing.Size(253, 22);
            this.addCourseTB.TabIndex = 20;
            this.addCourseTB.Text = "Enter the course ID you want to enroll";
            this.addCourseTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addCourseTB.Enter += new System.EventHandler(this.addCourseTB_Enter);
            this.addCourseTB.Leave += new System.EventHandler(this.addCourseTB_Leave);
            // 
            // removeBT
            // 
            this.removeBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBT.Location = new System.Drawing.Point(114, 475);
            this.removeBT.Name = "removeBT";
            this.removeBT.Size = new System.Drawing.Size(124, 28);
            this.removeBT.TabIndex = 23;
            this.removeBT.Text = "REMOVE";
            this.removeBT.UseVisualStyleBackColor = true;
            this.removeBT.Click += new System.EventHandler(this.removeBT_Click);
            // 
            // removeIDTB
            // 
            this.removeIDTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIDTB.ForeColor = System.Drawing.Color.Gray;
            this.removeIDTB.Location = new System.Drawing.Point(259, 481);
            this.removeIDTB.Name = "removeIDTB";
            this.removeIDTB.Size = new System.Drawing.Size(253, 22);
            this.removeIDTB.TabIndex = 22;
            this.removeIDTB.Text = "Enter the course ID you want to remove";
            this.removeIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removeIDTB.Enter += new System.EventHandler(this.removeIDTB_Enter);
            this.removeIDTB.Leave += new System.EventHandler(this.removeIDTB_Leave);
            // 
            // StudentCourseUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeBT);
            this.Controls.Add(this.removeIDTB);
            this.Controls.Add(this.enrollBT);
            this.Controls.Add(this.addCourseTB);
            this.Controls.Add(this.allCourseLB);
            this.Controls.Add(this.enrolledLB);
            this.Controls.Add(this.enrolledCourseDGV);
            this.Controls.Add(this.allCourseDGV);
            this.Name = "StudentCourseUC";
            this.Size = new System.Drawing.Size(925, 520);
            this.Load += new System.EventHandler(this.StudentCourseUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allCourseDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledCourseDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView allCourseDGV;
        public System.Windows.Forms.DataGridView enrolledCourseDGV;
        public System.Windows.Forms.Label enrolledLB;
        public System.Windows.Forms.Label allCourseLB;
        public System.Windows.Forms.Button enrollBT;
        public System.Windows.Forms.TextBox addCourseTB;
        public System.Windows.Forms.Button removeBT;
        public System.Windows.Forms.TextBox removeIDTB;
    }
}
