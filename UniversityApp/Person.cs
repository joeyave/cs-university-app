using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class Person
    {
        // Fields
        private string studentName;
        private string studentSurname;
        private DateTime studentBirthDate;

        // Constructors
        public Person(string currName, string currSurname, DateTime currBirthDate)
        {
            Name = currName;
            Surname = currSurname;
            BirthDate = currBirthDate;
        }

        public Person() { }

        // Methods
        public override string ToString()
        {
            return  "Name: "          + Name +
                    "\nSurname: "     + Surname +
                    "\nBirth Date: "  + BirthDate.ToShortDateString() +
                    "\nBirth Year: "  + BirthYear;
        }

        public virtual string ToShortString()
        {
            return  "Name: "        + Name +
                    "\nSurname: "   + Surname;
        }

        // Properties
        public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public string Surname
        {
            get { return studentSurname; }
            set { studentSurname = value; }
        }
        public DateTime BirthDate
        {
            get { return studentBirthDate; }
            set { studentBirthDate = value; }
        }

        // Contains year of birth
        public int BirthYear
        {
            get { return BirthDate.Year; }
            set
            {
                studentBirthDate = new DateTime(value, studentBirthDate.Month, studentBirthDate.Day);
            }
        }
    }
}
