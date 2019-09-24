using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class StudentCollection
    {
        // Delegates
        public delegate void StudentListHandler(object source, StudentListHandlerEventArgs args);

        // Events
        public event StudentListHandler StudentCountChanged;
        public event StudentListHandler StudentRefferenceChanged;

        // Fields
        private List<Student> listOfStudents = new List<Student>();

        // Constructors

        // Methods
        public void AddDefaults()
        {
            Student[] students =
            {
                new Student("Judy", "Taylor", new DateTime(1962, 11, 6),
                Education.Specialist, 5),
                new Student("Omar", "Dar", new DateTime(1992, 5, 21),
                Education.Bachelor, 3),
                new Student("Evelyn", "Devis", new DateTime(1994, 6, 26),
                Education.Specialist, 6),
                new Student("So", "Karlin", new DateTime(1975, 1, 11),
                Education.Bachelor, 2)
            };

            foreach(Student st in students)
            {
                StudentCountChanged?.Invoke(this,
                    new StudentListHandlerEventArgs("ListOfStudents", "Default students were added.", st));
            }
        }

        public void AddStudents(params Student[] students)
        {
            ListOfStudents.AddRange(students);
            foreach(Student st in students)
            {
                StudentCountChanged?.Invoke(this,
                new StudentListHandlerEventArgs("ListOfStudents", "Some students were added.", st));
            }
            
        }

        public bool Remove(int j)
        {
            try
            {
                listOfStudents.RemoveAt(j);
                StudentCountChanged?.Invoke(this,
                    new StudentListHandlerEventArgs("ListOfStudents", "Student was removed.", ListOfStudents[j]));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

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
        public string CollectionName { get; set; }

        // Indexator.
        public Student this[int index]
        {
            get => ListOfStudents[index];
            set
            {
                ListOfStudents[index] = value;

                StudentRefferenceChanged?.Invoke(this, new StudentListHandlerEventArgs("ListOfStudents", "The element was changed.", value));
            }
        }
    }
}
