namespace STUDENT_MS
{
    partial class StudentResultUC
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
            this.printBT = new System.Windows.Forms.Button();
            this.resultDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // printBT
            // 
            this.printBT.Font = new System.Drawing.Font("Asap Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBT.Location = new System.Drawing.Point(22, 430);
            this.printBT.Name = "printBT";
            this.printBT.Size = new System.Drawing.Size(107, 32);
            this.printBT.TabIndex = 1;
            this.printBT.Text = "PRINT";
            this.printBT.UseVisualStyleBackColor = true;
            this.printBT.Click += new System.EventHandler(this.printBT_Click);
            // 
            // resultDGV
            // 
            this.resultDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDGV.Location = new System.Drawing.Point(22, 17);
            this.resultDGV.Name = "resultDGV";
            this.resultDGV.RowHeadersWidth = 51;
            this.resultDGV.RowTemplate.Height = 24;
            this.resultDGV.Size = new System.Drawing.Size(844, 368);
            this.resultDGV.TabIndex = 2;
            // 
            // StudentResultUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultDGV);
            this.Controls.Add(this.printBT);
            this.Name = "StudentResultUC";
            this.Size = new System.Drawing.Size(894, 566);
            this.Load += new System.EventHandler(this.StudentResultUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button printBT;
        public System.Windows.Forms.DataGridView resultDGV;
    }
}
