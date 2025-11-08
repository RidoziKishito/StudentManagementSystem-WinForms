using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace STUDENT_MS
{
    public partial class StudentCourseUC : UserControl
    {
        Modify modify;
        public StudentCourseUC()
        {
            InitializeComponent();
        }

        private void addCourseTB_Enter(object sender, EventArgs e)
        {
            if (addCourseTB.Text == "Enter the course ID you want to enroll")
            {
                addCourseTB.Text = "";
                addCourseTB.ForeColor = Color.Black;
            }
        }

        private void addCourseTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addCourseTB.Text))
            {
                addCourseTB.Text = "Enter the course ID you want to enroll";
                addCourseTB.ForeColor = Color.Silver;
            }
        }

        private void removeIDTB_Enter(object sender, EventArgs e)
        {
            if (removeIDTB.Text == "Enter the course ID you want to remove")
            {
                removeIDTB.Text = "";
                removeIDTB.ForeColor = Color.Black;
            }
        }

        private void removeIDTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(removeIDTB.Text))
            {
                removeIDTB.Text = "Enter the course ID you want to remove";
                removeIDTB.ForeColor = Color.Silver;
            }
        }

        private void enrollBT_Click(object sender, EventArgs e)
        {
            string cid = addCourseTB.Text;
            if (string.IsNullOrEmpty (cid))
            {
                MessageBox.Show("Course ID is Empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                modify = new Modify();
                modify.EnrollCourse(GetUsername(), cid);
                enrolledCourseDGV.DataSource = modify.GetEnrolledCourse(GetUsername());
            }
        }
        private void removeBT_Click(object sender, EventArgs e)
        {
            string username = GetUsername();
            string cid = removeIDTB.Text;
            if (string.IsNullOrEmpty(cid))
            {
                MessageBox.Show("Course ID is Empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                modify = new Modify();
                modify.RemoveStudentCourse(username, cid);
                enrolledCourseDGV.DataSource = modify.GetEnrolledCourse(GetUsername());
            }
        }

        private void StudentCourseUC_Load(object sender, EventArgs e)
        {

        }


        public string GetUsername()
        {
            MainForm mainForm = this.FindForm() as MainForm;
            if (mainForm != null)
            {
                string username = mainForm.Username;
                return username;
            }
            else
            {
                MessageBox.Show("MainForm not found!");
            }
            return "";
        }
    }
}
