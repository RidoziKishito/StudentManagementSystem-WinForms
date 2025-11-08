using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_MS
{
    public partial class AdminResultUC : UserControl
    {
        MainForm mainForm;
        Modify modify;
        bool all = true;
        public AdminResultUC()
        {
            InitializeComponent();
        }

        public AdminResultUC(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void AdminResultUC_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            resultDGV.DataSource = modify.GetAllStudentAndCourse();
        }

        private void showAllBT_Click(object sender, EventArgs e)
        {
            all = true;
            modify = new Modify();
            resultDGV.DataSource = modify.GetAllStudentAndCourse();
        }

        private void chooseStudentBT_Click(object sender, EventArgs e)
        {
            try
            {
                string id = studentIDTB.Text;
                if (string.IsNullOrEmpty(id) || id == "Student ID")
                {
                    MessageBox.Show("ID is Empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    all = false;
                    modify = new Modify();
                    resultDGV.DataSource = modify.GetAllStudentInfo(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentIDTB_Enter(object sender, EventArgs e)
        {
            if (studentIDTB.Text == "Student ID")
            {
                studentIDTB.Text = "";
                studentIDTB.ForeColor = Color.Black;
            }
        }

        private void studentIDTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentIDTB.Text))
            {
                studentIDTB.Text = "Student ID";
                studentIDTB.ForeColor = Color.Silver;
            }
        }

        private void printBT_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                if (all)
                    printer.Title = "ALL STUDENTS RESULT";
                else 
                    printer.Title = "STUDENT RESULT: " + Modify.GetName(studentIDTB.Text); 
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToShortDateString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PorportionalColumns = true; // Keeps columns proportional
                printer.PageNumberInHeader = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "HCMUTE";
                printer.FooterSpacing = 15;
                printer.printDocument.DefaultPageSettings.Landscape = true;

                // New additions for single-page fit
                printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional; // Set proportional column widths
                printer.KeepRowsTogether = true; // Prevent splitting rows across pages


                //Check data
                if (resultDGV.DataSource != null && resultDGV.Rows.Count > 0)
                {
                    printer.PrintDataGridView(resultDGV);
                }
                else
                {
                    throw new Exception("No data available to print.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
