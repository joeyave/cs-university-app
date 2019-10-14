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
        public event StudentListHandler StudentsCountChanged;
        public event StudentListHandler StudentRefferenceChanged;

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

            ListOfStudents.AddRange(students);

            foreach(Student st in students)
            {
                StudentsCountChanged?.Invoke(this,
                    new StudentListHandlerEventArgs($"{CollectionName}", "Default students were added", st));
            }
        }

        public void AddStudents(params Student[] students)
        {
            ListOfStudents.AddRange(students);
            foreach(Student st in students)
            {
                StudentsCountChanged?.Invoke(this,
                new StudentListHandlerEventArgs($"{CollectionName}", "Some students were added", st));
            }
            
        }

        public bool Remove(int j)
        {
            try
            {
                StudentsCountChanged?.Invoke(this,
                    new StudentListHandlerEventArgs($"{CollectionName}", "Student was removed", ListOfStudents[j])); ;
                ListOfStudents.RemoveAt(j);
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
        public List<Student> ListOfStudents { get; set; } = new List<Student>();
        public string CollectionName { get; set; }

        // Indexator.
        public Student this[int index]
        {
            get => ListOfStudents[index];
            set
            {
                ListOfStudents[index] = value;

                StudentRefferenceChanged?.Invoke(this, new StudentListHandlerEventArgs($"{CollectionName}", $"The {index} element was changed", value));
            }
        }
    }
}
