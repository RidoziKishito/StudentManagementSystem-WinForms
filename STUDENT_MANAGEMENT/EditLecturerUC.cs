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
    public partial class EditLecturerUC : UserControl
    {
        MainForm mainForm;
        Modify modify;
        public EditLecturerUC()
        {
            InitializeComponent();
        }

        public EditLecturerUC(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }
        private void nextUCLB_Click(object sender, EventArgs e)
        {
            mainForm.ShowUserControl(mainForm.EditStudentUC1);
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditLecturerUC_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            lecturerDGV.DataSource = modify.GetAllLecturer();
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            Lecturer l;
            //check empty
            string id = idTB.Text;
            string name = nameTB.Text;
            string fid = fIDTB.Text;
            if (string.IsNullOrEmpty(id) || id == "Lecturer ID" ||
                string.IsNullOrEmpty(name) || name == "Full name" ||
                genderCB.SelectedIndex == -1 ||
                academicQalDB.SelectedIndex == -1 ||
                string.IsNullOrEmpty(fid) || fid == "Faculty ID")
            {
                MessageBox.Show("ERROR: MISSING VALUES!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modify = new Modify();
            try
            {
                l = new Lecturer(idTB.Text, nameTB.Text, genderCB.SelectedItem.ToString(),
                    dobDTP.Value.Date, fIDTB.Text, academicQalDB.SelectedItem.ToString(), hireDayDTP.Value.Date);
                modify.AddAccount(l.ID, "1");
                modify.AddLecturer(l);
                modify.UpdateSalary(l);
                lecturerDGV.DataSource = modify.GetAllLecturer();
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
                if (string.IsNullOrEmpty(id) || id == "Lecturer ID to Remove")
                {
                    MessageBox.Show("ID is Empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    modify = new Modify();
                    modify.RemoveAccount(id);
                    modify.RemoveLecturer(id);
                    lecturerDGV.DataSource = modify.GetAllLecturer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void idTB_Enter(object sender, EventArgs e)
        {
            if (idTB.Text == "Lecturer ID")
            {
                idTB.Text = "";
                idTB.ForeColor = Color.Black;
            }
        }

        private void idTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTB.Text))
            {
                idTB.Text = "Lecturer ID";
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

        private void removeIDTB_Enter(object sender, EventArgs e)
        {
            if (removeIDTB.Text == "Lecturer ID to Remove")
            {
                removeIDTB.Text = "";
                removeIDTB.ForeColor = Color.Black;
            }
        }

        private void removeIDTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(removeIDTB.Text))
            {
                removeIDTB.Text = "Lecturer ID to Remove";
                removeIDTB.ForeColor = Color.Silver;
            }
        }
    }
    
}
