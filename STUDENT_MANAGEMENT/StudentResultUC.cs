using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace STUDENT_MS
{
    public partial class StudentResultUC : UserControl
    {
        Modify modify;
        MainForm mainForm;
        public StudentResultUC()
        {
            InitializeComponent();
        }

        public StudentResultUC(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void printBT_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "STUDENT RESULT - " + Modify.GetName(mainForm.Username);
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

        private void StudentResultUC_Load(object sender, EventArgs e)
        {
            
        }

        private void resultDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
