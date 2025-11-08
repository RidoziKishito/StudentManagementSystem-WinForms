using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_MS
{
    public class Student : Person, IShow
    {
        //FIELD:
        private string major;
        private string fID; //faculty ID
        private DateTime studyDate;
        private Tuition fee;
        private List<StudentCourse> courses;
        //PROPERTIES:
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public string FID
        {
            get { return fID; }
            set { fID = value; }
        }
        public DateTime StudyDate
        {
            get { return studyDate; }
            set { studyDate = value; }
        }
        public Tuition Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        public List<StudentCourse> Courses
        {
            get { return Courses; }
            set { Courses = value; }
        }
        //CONSTRUCTOR:
        public Student() { Fee = new Tuition(); }
        public Student(string id, string name, string gender, DateTime dob, string major, string fid, DateTime studyDate) : base(id, name, gender, dob)
        {
            Major = major;
            FID = fid;
            StudyDate = studyDate;
            Fee = new Tuition();
        }
        public Student(string id, string name, string gender, int bDay, int bMonth, int bYear, string major, string fid, int sDay, int sMonth, int sYear) : base(id, name, gender, bDay, bMonth, bYear)
        {
            Major = major;
            FID = fID;
            StudyDate = new DateTime(sYear, sMonth, sDay);
            Fee = new Tuition();
        }
        //METHOD
        public override string PrintDetails()
        {
            return base.PrintDetails() + "\nMajor: " + Major +
                "\nFaculty ID: " + FID +
                "\nStudy Date: " + StudyDate.ToString("dd/MM/yyyy"); ;
        }
    }
}
