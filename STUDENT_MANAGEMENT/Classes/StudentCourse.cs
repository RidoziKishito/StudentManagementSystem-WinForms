using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_MS
{
    public class StudentCourse : Course
    {
        //FIELDS:
        private double midterm;
        private double final;
        //PROPERTIES:
        public double Midterm
        {
            get { return midterm; }
            set { midterm = value; }
        }
        public double Final
        {
            get { return final; }
            set { final = value; }
        }
        //CONSTRUCTOR:
        public StudentCourse() : base() { }
        public StudentCourse (string name, string cid, int credit,
            DateTime startDay, DateTime endDay, double midterm, double final) : base(name, cid, credit, startDay, endDay)
        {
            Midterm = midterm;
            Final = final;
        }
        //METHODS:
        public double GetTotal()
        {
            return (Midterm + Final)/2;
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nMidterm: " + Midterm + 
                "\nFinal: " + Final + 
                "\nTotal: " + GetTotal();
        }
    }
}
