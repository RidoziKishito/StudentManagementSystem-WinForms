using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_MS
{
    public class Tuition
    {
        //FIELD:
        private decimal amount;
        private bool isPaid;
        //PROPERTIES:
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public bool IsPaid
        {
            get { return isPaid; }
            set { isPaid = value; }
        }
        //CONSTRUCTION:
        public Tuition() 
        { 
            IsPaid = false;
        }
        public Tuition(decimal amount)
        {
            Amount = amount;
        }
        public Tuition(decimal amount, bool isPaid)
        {
            Amount = amount;
            IsPaid = isPaid;
        }
        //METHOD:
        public void pay(decimal amount)
        {
            if (Amount < amount)
            {
                throw new Exception("Please pay the exact amount of money!");
            }
            else if (Amount > amount)
            {
                Amount -= amount;
            }
            else if (Amount == amount)
            {
                Amount = 0;
                isPaid = true;
            }
        }
    }
}
