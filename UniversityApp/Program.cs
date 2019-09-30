using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentCollection col1 = new StudentCollection();
            StudentCollection col2 = new StudentCollection();

            Journal j1 = new Journal();
            Journal j2 = new Journal();

            col1.StudentsCountChanged += j1.CountChanged;
            col1.StudentRefferenceChanged += j1.RefferenceChanged;

            col1.StudentRefferenceChanged += j2.CountChanged;
            col2.StudentRefferenceChanged += j2.RefferenceChanged;

            Student[] students =
            {
                new Student("Michael", "Cavin", new DateTime(1942, 08, 27), Education.Specialist, 1),
                new Student("Marsha", "Brown", new DateTime(1941, 07, 15), Education.Specialist, 2),
                new Student("Dale", "Troncoso", new DateTime(1970, 10, 19), Education.Bachelor, 3)

            };

            col1.AddDefaults();
            col1.AddStudents(students);
            col1.Remove(2);
            col1.Remove(5);
            col1[3] = new Student("777", "777", new DateTime(7, 7, 7), Education.Bachelor, 7);
            col1[4] = new Student("777", "777", new DateTime(7, 7, 7), Education.Bachelor, 7);
            col1.AddStudents(new Student("777", "777", new DateTime(7, 7, 7), Education.Bachelor, 7));

            col2.AddDefaults();
            col2.AddStudents(students);
            col2.Remove(1);
            col2.Remove(3);
            col2.Remove(6);
            col2[1] = new Student("777", "777", new DateTime(7, 7, 7), Education.Bachelor, 7);
            col2.AddStudents(new Student("777", "777", new DateTime(7, 7, 7), Education.Bachelor, 7));
            col2[4] = new Student("777", "777", new DateTime(7, 7, 7), Education.Bachelor, 7);

            Console.WriteLine("***** First Journal *****");
            Console.WriteLine(j1.ToString());

            Console.WriteLine("***** Second Journal *****");
            Console.WriteLine(j2.ToString());

            Console.ReadLine();
        }
    }
}
