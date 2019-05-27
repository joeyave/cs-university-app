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
            Student st7 = new Student("Caley", "Arden", new DateTime(1959, 05, 23), Education.SecondEducation, 23);

            st1.AddExams(new Exam("Calculus", 2, new DateTime(2019, 07, 02)),
                new Exam("C#", 5, new DateTime(2019, 07, 08)));
            st1.AddTests(new Test("C#", true), new Test("Calculus", true));

            st2.AddExams(new Exam("Calculus", 3, new DateTime(2019, 07, 02)),
                new Exam("C#", 2, new DateTime(2019, 07, 08)));
            st2.AddTests(new Test("C#", false), new Test("Calculus", true));

            st3.AddExams(new Exam("Calculus", 4, new DateTime(2019, 07, 02)),
                new Exam("C#", 3, new DateTime(2019, 07, 08)));
            st3.AddTests(new Test("C#", true), new Test("Calculus", true));

            st4.AddExams(new Exam("Calculus", 5, new DateTime(2019, 07, 02)),
                new Exam("C#", 3, new DateTime(2019, 07, 08)));
            st4.AddTests(new Test("C#", true), new Test("Calculus", true));

            st5.AddExams(new Exam("Calculus", 2, new DateTime(2019, 07, 02)),
                new Exam("C#", 4, new DateTime(2019, 07, 08)));
            st5.AddTests(new Test("C#", true), new Test("Calculus", false));

            st6.AddExams(new Exam("Calculus", 2, new DateTime(2019, 07, 02)),
                new Exam("C#", 5, new DateTime(2019, 07, 08)));
            st6.AddTests(new Test("C#", true), new Test("Calculus", false));

            st7.AddExams(new Exam("Calculus", 4, new DateTime(2019, 07, 02)),
                new Exam("C#", 5, new DateTime(2019, 07, 08)));
            st7.AddTests(new Test("C#", true), new Test("Calculus", true));

            StudentCollection students = new StudentCollection();
            students.AddStudents(st1, st2, st3, st4, st5, st6, st7);

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("***** Students *****");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(students.ToShortString());

            // 2
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("***** Sort by Surname *****");
            Console.WriteLine("-----------------------------------------------------");
            students.ListOfStudents.Sort();

            foreach (Student st in students.ListOfStudents)
            {
               Console.WriteLine(st.ToShortString());
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("***** Sort by Date Birth *****");
            Console.WriteLine("-----------------------------------------------------");
            students.ListOfStudents.Sort(Person.SortByBirthDate);

            foreach (Student st in students.ListOfStudents)
            {
                Console.WriteLine(st.ToString());
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("***** Sort by Average Mark *****");
            Console.WriteLine("-----------------------------------------------------");
            students.ListOfStudents.Sort(Student.SortByAvgMark);

            foreach (Student st in students.ListOfStudents)
            {
                Console.WriteLine(st.ToShortString());
            }

            Console.ReadLine();
        }
    }
}
