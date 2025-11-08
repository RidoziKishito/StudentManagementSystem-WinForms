using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_MS {
    public class Admin : Person, IShow
    {
        //FIELD:
        private DateTime hireDate;
        //PROPERTIES:
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        //CONSTRUCTOR:
        public Admin() { }
        public Admin(string id, string name, string gender, DateTime dob, DateTime hireDate) : base(id, name, gender, dob)
        {
            HireDate = hireDate;
        }
        public Admin(string id, string name, string gender, int bDay, int bMonth, int bYear, int sDay, int sMonth, int sYear) : base(id, name, gender, bDay, bMonth, bYear)
        {
            HireDate = new DateTime(sYear, sMonth, sDay);
        }
        //METHOD
        public override string PrintDetails()
        {
            return base.PrintDetails() +
                "\nHire Date: " + HireDate.ToString(); ;
        }
    }
}
