using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class Person : IDateAndCopy, IComparable, IComparer<Person>
    {
        // Field Data
        protected string studentName;
        protected string studentSurname;
        protected DateTime studentBirthDate;
        
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
            return $"[Name: {Name}, Surname: {Surname}, Birthday: {BirthDate.ToShortDateString()}, Birth Year: {BirthYear}]";
        }

        public virtual string ToShortString()
        {
            return $"[Name: {Name}; Surname: {Surname}]";
        }

        public override bool Equals(object obj) => obj?.ToString() == ToString();

        public static bool operator ==(Person p1, Person p2) => p1.Equals(p2);

        public static bool operator !=(Person p1, Person p2) => p1.Equals(p2);

        public override int GetHashCode() => ToString().GetHashCode();

        public virtual object DeepCopy()
        {
            // First get a shallow copy
            Person newPerson = (Person)this.MemberwiseClone();

            // Then fill in the gaps
            DateTime currBirthDate =
                new DateTime(this.studentBirthDate.Year, this.studentBirthDate.Month, 
                this.studentBirthDate.Day);
            newPerson.BirthDate = currBirthDate;

            return newPerson;
        }

        public int CompareTo(object obj)
        {
            Person temp = obj as Person;
            if (temp != null)        
                return this.studentSurname.CompareTo(obj);
            else
                throw new ArgumentException("Parameter is not a Person.");
        }

        public int Compare(Person p1, Person p2)
        {
            if (p1?.BirthDate > p2?.BirthDate)
            {
                return 1;
            }
            if (p1?.BirthDate < p2?.BirthDate)
            {
                return -1;
            }
            return 0;
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

        public DateTime Date { get; set; }
    }
}
