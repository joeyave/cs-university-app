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
            // 1
            Student st1 = new Student("Igor", "Zapor", new DateTime(2001, 01, 05), Education.Bachelor, 1);
            Student st2 = new Student("Rachel", "Sparks", new DateTime(1999, 05, 28), Education.Bachelor, 23);
            Student st3 = new Student("Dale", "Arden", new DateTime(1959, 05, 23), Education.Specialist, 11);
            Student st4 = new Student("Vickie", "Kistner", new DateTime(1967, 05, 17), Education.Specialist, 11);
            Student st5 = new Student("David", "Spillman", new DateTime(1998, 01, 26), Education.Bachelor, 33);
            Student st6 = new Student("Patricia", "Madden", new DateTime(1975, 07, 31), Education.Specialist, 1);
            Student st7 = new Student("Dale", "Arden", new DateTime(1959, 05, 23), Education.SecondEducation, 23);

            StudentCollection students = new StudentCollection();
            students.AddStudents(st1, st2, st3, st4, st5, st6, st7);

            Console.WriteLine("***** Students *****");
            Console.WriteLine(students.ToShortString());

            // 2
            Console.WriteLine("***** Sort by Surname *****");

            Console.WriteLine("***** Sort by Date Birth *****");

            Console.WriteLine("***** Sort by Average Mark *****");
            students.ListOfStudents.Sort(Student.SortByAvgMark);

            foreach (Student st in students.ListOfStudents)
            {
                Console.WriteLine(st.ToShortString());
            }

            Console.ReadLine();
        }
    }
}
