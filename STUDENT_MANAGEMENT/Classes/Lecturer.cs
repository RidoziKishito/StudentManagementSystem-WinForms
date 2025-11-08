using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_MS
{
    public class Lecturer : Person, IShow
    {
        //FIELD:
        private string fID;
        private DateTime hireDate;
        private Salary sal;
        private string academicQual;
        //PROPERTIES:
        public string FID
        {
            get { return fID; }
            set { fID = value; }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public Salary Sal
        {
            get { return sal; }
            set { sal = value; }
        }
        /// <summary>
        /// MT = Master, PHD = PhD, APS = Associate Professor, PS = Professor
        /// </summary>
        public string AcademicQual
        {
            get { return academicQual; }
            set {  academicQual = value; }
        }
        //CONSTRUCTOR:
        public Lecturer() { Sal = new Salary(); }
        public Lecturer(string id, string name, string gender, DateTime dob, string fid, string academicQual, DateTime hireDate) : base(id, name, gender, dob)
        {
            AcademicQual = academicQual;
            FID = fid;
            HireDate = hireDate;
            Sal = new Salary();
        }
        public Lecturer(string id, string name, string gender, int bDay, int bMonth, int bYear, string fid, string academicQual, int sDay, int sMonth, int sYear) : base(id, name, gender, bDay, bMonth, bYear)
        {
            FID = fid;
            HireDate = new DateTime(sYear, sMonth, sDay);
            AcademicQual = academicQual;
            Sal = new Salary();
        }
        //METHOD
        public override string PrintDetails()
        {
            return base.PrintDetails() + "\nAcademic Quality: " + AcademicQual +
                "\nFaculty ID: " + FID +
                "\nHire Date: " + HireDate.ToString("dd/MM/yyyy"); ;
        }
    }
}
