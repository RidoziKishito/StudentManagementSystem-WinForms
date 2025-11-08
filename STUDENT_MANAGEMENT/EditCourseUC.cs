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
    public partial class EditCourseUC : UserControl
    {
        Modify modify;
        public EditCourseUC()
        {
            InitializeComponent();
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

        private void addCourseBT_Click(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                Course c = new Course(courseNameTB.Text, courseIDTB.Text, Convert.ToInt32(courseCreditTB.Text), startDayDTP.Value, endDayDTP.Value);
                modify.AddCourse(c);
                studentCourseDGV.DataSource = modify.GetAllCourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeBT_Click(object sender, EventArgs e)
        {
            try
            {
                string cid = removeIDTB.Text;
                if (string.IsNullOrEmpty(cid) || cid == "Enter the course ID you want to remove")
                {
                    MessageBox.Show("ID is Empty!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    modify = new Modify();
                    modify.RemoveCourse(cid);
                    studentCourseDGV.DataSource = modify.GetAllCourse();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
