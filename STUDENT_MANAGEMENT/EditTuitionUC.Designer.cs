namespace STUDENT_MS
{
    partial class EditTuitionUC
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
            this.tuitionDGV = new System.Windows.Forms.DataGridView();
            this.changeDB = new System.Windows.Forms.GroupBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.addBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionDGV)).BeginInit();
            this.changeDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tuitionDGV
            // 
            this.tuitionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tuitionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tuitionDGV.Location = new System.Drawing.Point(17, 16);
            this.tuitionDGV.Name = "tuitionDGV";
            this.tuitionDGV.RowHeadersWidth = 51;
            this.tuitionDGV.RowTemplate.Height = 24;
            this.tuitionDGV.Size = new System.Drawing.Size(892, 337);
            this.tuitionDGV.TabIndex = 1;
            // 
            // changeDB
            // 
            this.changeDB.Controls.Add(this.idTB);
            this.changeDB.Controls.Add(this.amountTB);
            this.changeDB.Controls.Add(this.addBT);
            this.changeDB.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDB.Location = new System.Drawing.Point(134, 359);
            this.changeDB.Name = "changeDB";
            this.changeDB.Size = new System.Drawing.Size(674, 78);
            this.changeDB.TabIndex = 49;
            this.changeDB.TabStop = false;
            this.changeDB.Text = "Change Tuition";
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.ForeColor = System.Drawing.Color.Gray;
            this.idTB.Location = new System.Drawing.Point(6, 33);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(197, 22);
            this.idTB.TabIndex = 38;
            this.idTB.Text = "Student ID";
            this.idTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idTB.Enter += new System.EventHandler(this.idTB_Enter);
            this.idTB.Leave += new System.EventHandler(this.idTB_Leave);
            // 
            // amountTB
            // 
            this.amountTB.Font = new System.Drawing.Font("Asap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTB.ForeColor = System.Drawing.Color.Gray;
            this.amountTB.Location = new System.Drawing.Point(209, 33);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(356, 22);
            this.amountTB.TabIndex = 36;
            this.amountTB.Text = "Amount";
            this.amountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTB.Enter += new System.EventHandler(this.amountTB_Enter);
            this.amountTB.Leave += new System.EventHandler(this.amountTB_Leave);
            // 
            // addBT
            // 
            this.addBT.Font = new System.Drawing.Font("Asap SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBT.Location = new System.Drawing.Point(571, 27);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(97, 35);
            this.addBT.TabIndex = 37;
            this.addBT.Text = "ADD";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // EditTuitionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changeDB);
            this.Controls.Add(this.tuitionDGV);
            this.Name = "EditTuitionUC";
            this.Size = new System.Drawing.Size(930, 460);
            this.Load += new System.EventHandler(this.EditTuitionUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tuitionDGV)).EndInit();
            this.changeDB.ResumeLayout(false);
            this.changeDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tuitionDGV;
        private System.Windows.Forms.GroupBox changeDB;
        public System.Windows.Forms.TextBox idTB;
        public System.Windows.Forms.TextBox amountTB;
        public System.Windows.Forms.Button addBT;
    }
}
