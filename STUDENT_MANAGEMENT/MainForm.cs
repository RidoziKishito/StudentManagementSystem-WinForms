using STUDENT_MS.STUDENT_MSDataSet1TableAdapters;
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
    public partial class MainForm : Form
    {
        #region 1) Initialization
        //FOR DRAGGING
        private bool dragging = false; //check if the mouse is in dragging state
        private Point dragCursorPoint; //save the current pos of the mouse
        private Point dragFormPoint;   //save the current pos of the form
        //FOR DATA 
        Modify modify;
        string username; //save user for later use
        int role;
        //UC
        //STUDENT UCS:
        StudentHomeUC studentHomeUC1;
        StudentCourseUC studentCourseUC1;
        StudentResultUC studentResultUC1;
        StudentTuitionUC studentTuitionUC1;
        //LECTURER UCS:
        LecturerHomeUC lecturerHomeUC1;
        EditCourseUC editCourseUC1;
        LecturerResultUC lecturerResultUC1;
        SalaryUC salaryUC1;
        //ADMIN UCS:
        EditStudentUC editStudentUC1;
        EditLecturerUC editLecturerUC1;
        AdminHomeUC adminHomeUC1;
        EditTuitionUC editTuitionUC1;
        AdminResultUC adminResultUC1;
        public string Username
        {
            get { return username; }
        }

        public EditStudentUC EditStudentUC1 { get => editStudentUC1; set => editStudentUC1 = value; }
        public EditLecturerUC EditLecturerUC1 { get => editLecturerUC1; set => editLecturerUC1 = value; }

        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string username, int role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //STUDENT UCS:
            studentHomeUC1 = new StudentHomeUC();
            studentCourseUC1 = new StudentCourseUC();
            studentResultUC1 = new StudentResultUC(this);
            studentTuitionUC1 = new StudentTuitionUC(this);
            //LECTURER UCS:
            lecturerHomeUC1 = new LecturerHomeUC(this);
            editCourseUC1 = new EditCourseUC();
            lecturerResultUC1 = new LecturerResultUC();
            salaryUC1 = new SalaryUC(this);
            modify = new Modify();
            //ADMIN UCS:
            EditStudentUC1 = new EditStudentUC(this);
            EditLecturerUC1 = new EditLecturerUC(this);
            adminHomeUC1 = new AdminHomeUC();
            editTuitionUC1 = new EditTuitionUC();
            adminResultUC1 = new AdminResultUC(this);
            switch (role)
            {
                case 0:
                    //HOME_UC
                    ShowUserControl(studentHomeUC1);
                    studentHomeUC1.welcomeLB.Text = "Welcome " + Modify.GetName(username) + "!";
                    studentHomeUC1.informationLB.Text = "Information: \n" + Modify.PrintByID(username, 0);
                    setChart();
                    //COURSE_UC
                    studentCourseUC1.allCourseDGV.DataSource = modify.GetAllCourse();
                    studentCourseUC1.enrolledCourseDGV.DataSource = modify.GetEnrolledCourse(username);
                    //RESULT
                    studentResultUC1.resultDGV.DataSource = modify.GetEnrolledCourse(username);
                    break;
                case 1:
                    moneyBT.Text = "SALARY";
                    //HOME_UC
                    ShowUserControl(lecturerHomeUC1);
                    break;
                case 2:
                    courseBT.Text = "MANAGE";
                    moneyBT.Text = "MONEY";
                    ShowUserControl(adminHomeUC1);
                    break;
                default:
                    break;
            }

        }
        #endregion

        #region 2) Window Settings
        private void topPN_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true; //in dragging state
            dragCursorPoint = System.Windows.Forms.Cursor.Position; //update cursor pos
            dragFormPoint = this.Location; //update form pos
        }

        private void topPN_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                //calculate the displacement between init pos and current pos
                Point dif = Point.Subtract(System.Windows.Forms.Cursor.Position, new Size(dragCursorPoint));
                //add the displacement into the location of the form
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void topPN_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void minimizePIC_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizePIC_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void closePIC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 3) Actions
        private void logoutBT_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void courseBT_Click(object sender, EventArgs e)
        {
            switch (role)
            {
                case 0:
                    ShowUserControl(studentCourseUC1);
                    break;
                case 1:
                    ShowUserControl(editCourseUC1);
                    editCourseUC1.studentCourseDGV.DataSource = modify.GetAllCourse();
                    break;
                case 2:
                    ShowUserControl(EditStudentUC1);
                    break;
                default:
                    break;
            }
           
        }

        private void homeBT_Click(object sender, EventArgs e)
        {
            switch (role)
            {
                case 0:
                    ShowUserControl(studentHomeUC1);
                    studentHomeUC1.welcomeLB.Text = "Welcome " + Modify.GetName(username) + "!";
                    studentHomeUC1.informationLB.Text = "Information: \n" + Modify.PrintByID(username, 0);
                    setChart();
                    break;
                case 1:
                    //HOME_UC
                    ShowUserControl(lecturerHomeUC1);
                    lecturerHomeUC1.welcomeLB.Text = "Welcome " + Modify.GetName(username) + "!";
                    lecturerHomeUC1.informationLB.Text = "Information: \n" + Modify.PrintByID(username, 1);
                    break;
                case 2:
                    adminHomeUC1.welcomeLB.Text = "Welcome " + Modify.GetName(username) + "!";
                    adminHomeUC1.accountDGV.DataSource = modify.GetAllAccount();
                    ShowUserControl(adminHomeUC1);
                    break;
                default:
                    break;
            }
           
        }

        private void studentCourseUC1_Load(object sender, EventArgs e)
        {

        }

        private void setChart()
        {
            //CHART
            Dictionary<string, float> courseGpaData = Modify.GetCourseGPA("S23CS02");

            studentHomeUC1.resultChart.Series.Clear();
            studentHomeUC1.resultChart.Series.Add("GPA");
            studentHomeUC1.resultChart.Series["GPA"].ChartType = SeriesChartType.Column;

            foreach (var courseGPA in courseGpaData)
            {
                studentHomeUC1.resultChart.Series["GPA"].Points.AddXY(courseGPA.Key, courseGPA.Value);
            }
        }

        private void moneyBT_Click(object sender, EventArgs e)
        {
            switch (role)
            {
                case 0:
                    ShowUserControl(studentTuitionUC1);
                    break;
                case 1:
                    ShowUserControl(salaryUC1);
                    break;
                case 2:
                    ShowUserControl(editTuitionUC1);
                    break;
                default:
                    break;
            }
        }

        private void resultBT_Click(object sender, EventArgs e)
        {
            switch (role)
            {
                case 0:
                    ShowUserControl(studentResultUC1);
                    studentResultUC1.resultDGV.DataSource = modify.GetEnrolledCourse(username);
                    break;
                case 1:
                    ShowUserControl(lecturerResultUC1);
                    lecturerResultUC1.resultDGV.DataSource = modify.GetEnrolledCourse(username);
                    lecturerResultUC1.studentListDGV.DataSource = modify.GetStudentNameID(username);
                    break;
                case 2:
                    ShowUserControl(adminResultUC1);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 4) Other methods
        public void ShowUserControl(UserControl uc)
        {
            userControlPN.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            userControlPN.Controls.Add(uc);
        }

        #endregion

        private void userControlPN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topPN_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
