using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class StudentCollection
    {
        // Fields
        private List<Student> listOfStudents = new List<Student>();

        // Constructors
        // Methods
        public void AddDefaults()
        {
            ListOfStudents.Add(new Student("Judy", "Taylor", new DateTime(1962, 11, 6),
                Education.Specialist, 5));
            ListOfStudents.Add(new Student("Omar", "Dar", new DateTime(1992, 5, 21),
                Education.Bachelor, 3));
            ListOfStudents.Add(new Student("Evelyn", "Devis", new DateTime(1994, 6, 26),
                Education.Specialist, 6));
            ListOfStudents.Add(new Student("So", "Karlin", new DateTime(1975, 1, 11),
                Education.Bachelor, 2));
        }

        public void AddStudents(params Student[] students) => ListOfStudents.AddRange(students);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            foreach(Student st in ListOfStudents)
            {
                sb.AppendLine(st.ToString());
            }

            return sb.ToString();
        }

        public string ToShortString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Student st in ListOfStudents)
            {
                sb.AppendLine(st.ToShortString());
            }

            return sb.ToString();
        }

        // Properties
        public List<Student> ListOfStudents { get; set; }
    }
}
