using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace STUDENT_MS
{
    public partial class EditStudentUC : UserControl
    {
        MainForm mainForm;
        Modify modify;
        Student s;
        public EditStudentUC()
        {
            InitializeComponent();
        }

        public EditStudentUC(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void nextUCLB_Click(object sender, EventArgs e)
        {
            mainForm.ShowUserControl(mainForm.EditLecturerUC1);
        }

        private void EditStudentUC_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            studentDGV.DataSource = modify.getAllStudent();
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            //check empty
            string id = idTB.Text;
            string name = nameTB.Text;
            string major = majorTB.Text;
            string fid = fIDTB.Text;
            if (string.IsNullOrEmpty(id) || id == "Student ID" ||
                string.IsNullOrEmpty(name) || name == "Full name" ||
                genderCB.SelectedIndex == -1 || 
                string.IsNullOrEmpty(major) || major == "Major" ||
                string.IsNullOrEmpty(fid) || fid == "Faculty ID")
            {
                MessageBox.Show("ERROR: MISSING VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modify = new Modify();
            try
            {
                s = new Student(idTB.Text, nameTB.Text, genderCB.SelectedItem.ToString(),
                    dobDTP.Value.Date, majorTB.Text, fIDTB.Text, studyDayDTP.Value.Date);
                modify.AddStudent(s);
                modify.AddTuition(s.ID, Convert.ToDecimal(10000));
                modify.AddAccount(s.ID, "1");
                studentDGV.DataSource = modify.getAllStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeBT_Click(object sender, EventArgs e)
        {
            try
            {
                string id = removeIDTB.Text;
                if (string.IsNullOrEmpty(id) || id == "Student ID to Remove")
                {
                    MessageBox.Show("ID is Empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    modify = new Modify();
                    modify.RemoveAccount(id);
                    modify.RemoveStudent(id);
                    studentDGV.DataSource = modify.getAllStudent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void idTB_Enter(object sender, EventArgs e)
        {
            if (idTB.Text == "Student ID")
            {
                idTB.Text = "";
                idTB.ForeColor = Color.Black;
            }
        }

        private void idTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTB.Text))
            {
                idTB.Text = "Student ID";
                idTB.ForeColor = Color.Silver;
            }
        }

        private void nameTB_Enter(object sender, EventArgs e)
        {
            if (nameTB.Text == "Full name")
            {
                nameTB.Text = "";
                nameTB.ForeColor = Color.Black;
            }
        }

        private void nameTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTB.Text))
            {
                nameTB.Text = "Full name";
                nameTB.ForeColor = Color.Silver;
            }
        }

        private void fIDTB_Enter(object sender, EventArgs e)
        {
            if (fIDTB.Text == "Faculty ID")
            {
                fIDTB.Text = "";
                fIDTB.ForeColor = Color.Black;
            }
        }

        private void fIDTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fIDTB.Text))
            {
                fIDTB.Text = "Faculty ID";
                fIDTB.ForeColor = Color.Silver;
            }
        }

        private void majorTB_Enter(object sender, EventArgs e)
        {
            if (majorTB.Text == "Major")
            {
                majorTB.Text = "";
                majorTB.ForeColor = Color.Black;
            }
        }

        private void majorTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(majorTB.Text))
            {
                majorTB.Text = "Major";
                majorTB.ForeColor = Color.Silver;
            }
        }

        private void removeIDTB_Enter(object sender, EventArgs e)
        {
            if (removeIDTB.Text == "Student ID to Remove")
            {
                removeIDTB.Text = "";
                removeIDTB.ForeColor = Color.Black;
            }
        }

        private void removeIDTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(removeIDTB.Text))
            {
                removeIDTB.Text = "Student ID to Remove";
                removeIDTB.ForeColor = Color.Silver;
            }
        }

        private void addStudentGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
