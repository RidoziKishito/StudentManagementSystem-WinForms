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
    public partial class SalaryUC : UserControl
    {
        Salary s;
        MainForm mainForm;
        Modify modify;
        public SalaryUC()
        {
            InitializeComponent();
        }

        public SalaryUC(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void SalaryUC_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            s = modify.GetSalaryByID(mainForm.Username);
            currentSalaryLB.Text = s.Amount + " USD";
        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedText = academicQalDB.SelectedItem.ToString();
                if (string.IsNullOrEmpty(selectedText))
                {
                    throw new Exception("Empty Academic Qualification!");
                }
                s.updateSalary(selectedText);
                modify.UpdateSalary(mainForm.Username, s);
                currentSalaryLB.Text = s.Amount + " USD";
                modify.UpdateAcademicQual(mainForm.Username, selectedText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }
    }
}
