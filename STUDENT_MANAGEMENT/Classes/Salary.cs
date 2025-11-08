using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_MS
{
    public class Salary
    {
        //FIELD:
        private decimal amount;
        //PROPERTIES:
        public decimal Amount {
            get { return amount; } 
            set { amount = value; }
        }
        //CONSTRUCTOR:
        public Salary() { }
        public Salary(decimal amount)
        {
            Amount = amount;
        }
        //METHODS:
        public void updateSalary(string academicQual)
        {
            if (academicQual == null) throw new ArgumentNullException();
            else if (academicQual == "Master") Amount = 10000;
            else if (academicQual == "PhD") Amount = 12000;
            else if (academicQual == "A.Professor") Amount = 150000;
            else if (academicQual == "Professor") Amount = 20000;
        }
    }
}
