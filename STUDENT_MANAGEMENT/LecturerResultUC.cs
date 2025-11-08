using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_MS
{
    public partial class LecturerResultUC : UserControl
    {
        Modify modify;
        string id;
        public LecturerResultUC()
        {
            InitializeComponent();
        }

        private void chooseStudentBT_Click(object sender, EventArgs e)
        {
            try
            {
                id = studentIDTB.Text;
                if (string.IsNullOrEmpty(id) || id == "Student ID")
                {
                    MessageBox.Show("ID is Empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    modify = new Modify();
                    resultDGV.DataSource = modify.GetEnrolledCourse(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeIDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentIDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void printBT_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "STUDENT RESULT - " + Modify.GetName(id);
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

        private void resultDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //COURSE ID (WRONG NAME)
        private void removeIDTB_Enter(object sender, EventArgs e)
        {
            if (removeIDTB.Text == "Course ID")
            {
                removeIDTB.Text = "";
                removeIDTB.ForeColor = Color.Black;
            }
        }
        //COURSE ID (WRONG NAME)
        private void removeIDTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(removeIDTB.Text))
            {
                removeIDTB.Text = "Course ID";
                removeIDTB.ForeColor = Color.Silver;
            }
        }

        private void gradeTB_Enter(object sender, EventArgs e)
        {
            if (gradeTB.Text == "Midterm")
            {
                gradeTB.Text = "";
                gradeTB.ForeColor = Color.Black;
            }
        }

        private void gradeTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gradeTB.Text))
            {
                gradeTB.Text = "Midterm";
                gradeTB.ForeColor = Color.Silver;
            }
        }

        private void assignBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(removeIDTB.Text) || string.IsNullOrEmpty(gradeTB.Text) || string.IsNullOrEmpty(finalGradeTB.Text)
                    || string.IsNullOrEmpty(id))
                {
                    throw new Exception("Missing value!!");
                }
                string cid = removeIDTB.Text; //COURSE ID (WRONG NAME)
                float midterm = Convert.ToSingle(gradeTB.Text);
                float final = Convert.ToSingle(finalGradeTB.Text);
                modify.AssignGrade(id, cid, midterm, final);
                resultDGV.DataSource = modify.GetEnrolledCourse(id);
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void finalGradeTB_Enter(object sender, EventArgs e)
        {
            if (finalGradeTB.Text == "Final")
            {
                finalGradeTB.Text = "";
                finalGradeTB.ForeColor = Color.Black;
            }
        }

        private void finalGradeTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(finalGradeTB.Text))
            {
                finalGradeTB.Text = "Final";
                finalGradeTB.ForeColor = Color.Silver;
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

        private void LecturerResultUC_Load(object sender, EventArgs e)
        {

        }
    }
}
