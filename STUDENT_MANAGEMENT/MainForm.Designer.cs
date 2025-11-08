namespace STUDENT_MS
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.FlowLayoutPanel sideBarFlow;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.homeBT = new System.Windows.Forms.Button();
            this.courseBT = new System.Windows.Forms.Button();
            this.resultBT = new System.Windows.Forms.Button();
            this.moneyBT = new System.Windows.Forms.Button();
            this.logoutBT = new System.Windows.Forms.Button();
            this.topPN = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.hamPIC = new System.Windows.Forms.PictureBox();
            this.closePIC = new System.Windows.Forms.PictureBox();
            this.maximizePIC = new System.Windows.Forms.PictureBox();
            this.minimizePIC = new System.Windows.Forms.PictureBox();
            this.sTUDENT_MSDataSet = new STUDENT_MS.STUDENT_MSDataSet();
            this.sTUDENT_MSDataSet2 = new STUDENT_MS.STUDENT_MSDataSet2();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new STUDENT_MS.STUDENT_MSDataSet2TableAdapters.StudentTableAdapter();
            this.userControlPN = new System.Windows.Forms.Panel();
            sideBarFlow = new System.Windows.Forms.FlowLayoutPanel();
            sideBarFlow.SuspendLayout();
            this.topPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarFlow
            // 
            sideBarFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            sideBarFlow.Controls.Add(this.homeBT);
            sideBarFlow.Controls.Add(this.courseBT);
            sideBarFlow.Controls.Add(this.resultBT);
            sideBarFlow.Controls.Add(this.moneyBT);
            sideBarFlow.Controls.Add(this.logoutBT);
            sideBarFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            sideBarFlow.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            sideBarFlow.Location = new System.Drawing.Point(0, 46);
            sideBarFlow.Name = "sideBarFlow";
            sideBarFlow.Size = new System.Drawing.Size(148, 633);
            sideBarFlow.TabIndex = 2;
            // 
            // homeBT
            // 
            this.homeBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeBT.Font = new System.Drawing.Font("Asap", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeBT.Image = ((System.Drawing.Image)(resources.GetObject("homeBT.Image")));
            this.homeBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBT.Location = new System.Drawing.Point(3, 3);
            this.homeBT.Name = "homeBT";
            this.homeBT.Size = new System.Drawing.Size(141, 64);
            this.homeBT.TabIndex = 8;
            this.homeBT.Text = "HOME";
            this.homeBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBT.UseVisualStyleBackColor = false;
            this.homeBT.Click += new System.EventHandler(this.homeBT_Click);
            // 
            // courseBT
            // 
            this.courseBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.courseBT.Font = new System.Drawing.Font("Asap", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseBT.Image = ((System.Drawing.Image)(resources.GetObject("courseBT.Image")));
            this.courseBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseBT.Location = new System.Drawing.Point(3, 73);
            this.courseBT.Name = "courseBT";
            this.courseBT.Size = new System.Drawing.Size(141, 64);
            this.courseBT.TabIndex = 9;
            this.courseBT.Text = "COURSE";
            this.courseBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.courseBT.UseVisualStyleBackColor = false;
            this.courseBT.Click += new System.EventHandler(this.courseBT_Click);
            // 
            // resultBT
            // 
            this.resultBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resultBT.Font = new System.Drawing.Font("Asap", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultBT.Image = ((System.Drawing.Image)(resources.GetObject("resultBT.Image")));
            this.resultBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultBT.Location = new System.Drawing.Point(3, 143);
            this.resultBT.Name = "resultBT";
            this.resultBT.Size = new System.Drawing.Size(141, 64);
            this.resultBT.TabIndex = 9;
            this.resultBT.Text = "RESULT";
            this.resultBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultBT.UseVisualStyleBackColor = false;
            this.resultBT.Click += new System.EventHandler(this.resultBT_Click);
            // 
            // moneyBT
            // 
            this.moneyBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moneyBT.Font = new System.Drawing.Font("Asap", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moneyBT.Image = ((System.Drawing.Image)(resources.GetObject("moneyBT.Image")));
            this.moneyBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyBT.Location = new System.Drawing.Point(3, 213);
            this.moneyBT.Name = "moneyBT";
            this.moneyBT.Size = new System.Drawing.Size(141, 64);
            this.moneyBT.TabIndex = 10;
            this.moneyBT.Text = "TUITION";
            this.moneyBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.moneyBT.UseVisualStyleBackColor = false;
            this.moneyBT.Click += new System.EventHandler(this.moneyBT_Click);
            // 
            // logoutBT
            // 
            this.logoutBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBT.Font = new System.Drawing.Font("Asap", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBT.Image = ((System.Drawing.Image)(resources.GetObject("logoutBT.Image")));
            this.logoutBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBT.Location = new System.Drawing.Point(3, 283);
            this.logoutBT.Name = "logoutBT";
            this.logoutBT.Size = new System.Drawing.Size(141, 64);
            this.logoutBT.TabIndex = 12;
            this.logoutBT.Text = "LOGOUT";
            this.logoutBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBT.UseVisualStyleBackColor = false;
            this.logoutBT.Click += new System.EventHandler(this.logoutBT_Click);
            // 
            // topPN
            // 
            this.topPN.BackColor = System.Drawing.Color.White;
            this.topPN.Controls.Add(this.lblTitle);
            this.topPN.Controls.Add(this.hamPIC);
            this.topPN.Controls.Add(this.closePIC);
            this.topPN.Controls.Add(this.maximizePIC);
            this.topPN.Controls.Add(this.minimizePIC);
            this.topPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPN.Location = new System.Drawing.Point(0, 0);
            this.topPN.Name = "topPN";
            this.topPN.Size = new System.Drawing.Size(1081, 47);
            this.topPN.TabIndex = 3;
            this.topPN.Paint += new System.Windows.Forms.PaintEventHandler(this.topPN_Paint);
            this.topPN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseDown);
            this.topPN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseMove);
            this.topPN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitle.Font = new System.Drawing.Font("Asap", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(51, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HCMUTE";
            // 
            // hamPIC
            // 
            this.hamPIC.Image = ((System.Drawing.Image)(resources.GetObject("hamPIC.Image")));
            this.hamPIC.Location = new System.Drawing.Point(-3, 0);
            this.hamPIC.Name = "hamPIC";
            this.hamPIC.Size = new System.Drawing.Size(59, 63);
            this.hamPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamPIC.TabIndex = 0;
            this.hamPIC.TabStop = false;
            // 
            // closePIC
            // 
            this.closePIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePIC.Image = ((System.Drawing.Image)(resources.GetObject("closePIC.Image")));
            this.closePIC.Location = new System.Drawing.Point(1032, 6);
            this.closePIC.Name = "closePIC";
            this.closePIC.Size = new System.Drawing.Size(34, 31);
            this.closePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePIC.TabIndex = 1;
            this.closePIC.TabStop = false;
            this.closePIC.Click += new System.EventHandler(this.closePIC_Click);
            // 
            // maximizePIC
            // 
            this.maximizePIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizePIC.Image = ((System.Drawing.Image)(resources.GetObject("maximizePIC.Image")));
            this.maximizePIC.Location = new System.Drawing.Point(992, 6);
            this.maximizePIC.Name = "maximizePIC";
            this.maximizePIC.Size = new System.Drawing.Size(34, 31);
            this.maximizePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizePIC.TabIndex = 1;
            this.maximizePIC.TabStop = false;
            this.maximizePIC.Click += new System.EventHandler(this.maximizePIC_Click);
            // 
            // minimizePIC
            // 
            this.minimizePIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizePIC.Image = ((System.Drawing.Image)(resources.GetObject("minimizePIC.Image")));
            this.minimizePIC.Location = new System.Drawing.Point(953, 6);
            this.minimizePIC.Name = "minimizePIC";
            this.minimizePIC.Size = new System.Drawing.Size(33, 31);
            this.minimizePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizePIC.TabIndex = 1;
            this.minimizePIC.TabStop = false;
            this.minimizePIC.Click += new System.EventHandler(this.minimizePIC_Click);
            // 
            // sTUDENT_MSDataSet
            // 
            this.sTUDENT_MSDataSet.DataSetName = "STUDENT_MSDataSet";
            this.sTUDENT_MSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENT_MSDataSet2
            // 
            this.sTUDENT_MSDataSet2.DataSetName = "STUDENT_MSDataSet2";
            this.sTUDENT_MSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.sTUDENT_MSDataSet2;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // userControlPN
            // 
            this.userControlPN.Dock = System.Windows.Forms.DockStyle.Right;
            this.userControlPN.Location = new System.Drawing.Point(145, 47);
            this.userControlPN.Name = "userControlPN";
            this.userControlPN.Size = new System.Drawing.Size(936, 629);
            this.userControlPN.TabIndex = 4;
            this.userControlPN.Paint += new System.Windows.Forms.PaintEventHandler(this.userControlPN_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 676);
            this.Controls.Add(this.userControlPN);
            this.Controls.Add(this.topPN);
            this.Controls.Add(sideBarFlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            sideBarFlow.ResumeLayout(false);
            this.topPN.ResumeLayout(false);
            this.topPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeBT;
        private System.Windows.Forms.Button courseBT;
        private System.Windows.Forms.Button resultBT;
        private System.Windows.Forms.Button moneyBT;
        private System.Windows.Forms.Button logoutBT;
        private System.Windows.Forms.Panel topPN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox hamPIC;
        private System.Windows.Forms.PictureBox closePIC;
        private System.Windows.Forms.PictureBox maximizePIC;
        private System.Windows.Forms.PictureBox minimizePIC;
        private STUDENT_MSDataSet sTUDENT_MSDataSet;
        private STUDENT_MSDataSet2 sTUDENT_MSDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private STUDENT_MSDataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Panel userControlPN;
    }
}

