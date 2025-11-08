using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_MS
{
    public abstract class Person : IShow
    {
        //FIELD:
        private string id;
        private string name;
        private string gender;
        private DateTime dob;
        private string password;
        //PROPERTIES:
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        //CONSTRUCTOR:
        public Person() { }
        public Person(string id, string name, string gender, DateTime dob)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Dob = dob;
        }
        public Person(string id, string name, string gender, int bDay, int bMonth, int bYear)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Dob = new DateTime(bYear, bMonth, bDay);
        }
        //METHOD:
        public virtual string PrintDetails()
        {
            return "ID: " + ID + "\n"
                + "Full name: " + Name + "\n"
                + "Gender: " + Gender + "\n"
                + "Date of Birth: " + Dob.ToString("dd/MM/yyyy") + "\n";
        }
    }
}
