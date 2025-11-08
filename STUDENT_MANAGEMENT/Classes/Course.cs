using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_MS
{
    public class Course
    {
        //FIELD:
        private string name;
        private string cid;
        private int credit;
        private DateTime startDay;
        private DateTime endDay;
        //PROPERTIES:
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Cid
        {
            get { return cid; }
            set { cid = value; }
        }
        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        public DateTime StartDay
        {
            get { return startDay; }
            set { startDay = value; }
        }
        public DateTime EndDay
        {
            get { return endDay; }
            set { endDay = value; }
        }
        //CONSTRUCTORS:
        public Course() {}
        public Course(string name, string cid, int credit, DateTime startDay, DateTime endDay) 
        {
            Name = name;
            Cid = cid;
            Credit = credit;
            StartDay = startDay;
            EndDay = endDay;
        }
        //METHODS:
        public override string ToString()
        {
            return Name + " | " + Cid + " | " + Credit + " credits" +
                "\nStart: " + StartDay.ToString() + "\nEnd: " + EndDay.ToString();
        }
    }
}
