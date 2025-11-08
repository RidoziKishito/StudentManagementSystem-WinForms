namespace STUDENT_MS
{
    partial class StudentHomeUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.informationLB = new System.Windows.Forms.Label();
            this.welcomeLB = new System.Windows.Forms.Label();
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // informationLB
            // 
            this.informationLB.AutoSize = true;
            this.informationLB.Font = new System.Drawing.Font("Asap SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLB.Location = new System.Drawing.Point(23, 63);
            this.informationLB.Name = "informationLB";
            this.informationLB.Size = new System.Drawing.Size(131, 24);
            this.informationLB.TabIndex = 4;
            this.informationLB.Text = "INFORMATION:";
            // 
            // welcomeLB
            // 
            this.welcomeLB.AutoSize = true;
            this.welcomeLB.Font = new System.Drawing.Font("Asap", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.welcomeLB.Location = new System.Drawing.Point(20, 14);
            this.welcomeLB.Name = "welcomeLB";
            this.welcomeLB.Size = new System.Drawing.Size(153, 37);
            this.welcomeLB.TabIndex = 3;
            this.welcomeLB.Text = "WELCOME!";
            // 
            // resultChart
            // 
            this.resultChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.resultChart.BorderlineColor = System.Drawing.Color.Navy;
            this.resultChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.resultChart.Legends.Add(legend1);
            this.resultChart.Location = new System.Drawing.Point(400, 24);
            this.resultChart.Name = "resultChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.resultChart.Series.Add(series1);
            this.resultChart.Size = new System.Drawing.Size(481, 502);
            this.resultChart.TabIndex = 5;
            this.resultChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Asap SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Navy;
            title1.Name = "Title1";
            title1.Text = "ACADEMIC RESULT";
            this.resultChart.Titles.Add(title1);
            // 
            // StudentHomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultChart);
            this.Controls.Add(this.informationLB);
            this.Controls.Add(this.welcomeLB);
            this.Name = "StudentHomeUC";
            this.Size = new System.Drawing.Size(934, 546);
            this.Load += new System.EventHandler(this.StudentHomeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label informationLB;
        public System.Windows.Forms.Label welcomeLB;
        public System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
    }
}
