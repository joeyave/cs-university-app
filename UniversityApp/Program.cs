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
            Console.WriteLine("\n********** 1 **********");
            Person p1 = new Person("Vlas", "Novokhatnii", new DateTime(2001, 01, 12));
            Person p2 = new Person("Vlas", "Novokhatnii", new DateTime(2001, 01, 12));


            Console.WriteLine($"Equals: {p1 == p2}");
            Console.WriteLine($"\nReferenceEquals: {ReferenceEquals(p1, p2)}");
            Console.WriteLine($"\np1: {p1} \nHC: {p1.GetHashCode()} \np2: {p2} \nHC: {p2.GetHashCode()}");

            // 2
            Console.WriteLine("\n********** 2 **********");
            Exam ex1 = new Exam("Calculus", 2, new DateTime(2019, 07, 02));
            Exam ex2 = new Exam("C#", 5, new DateTime(2019, 07, 08));
            Exam ex3 = new Exam("C++", 5, new DateTime(2019, 06, 28));

            Test ts1 = new Test("C#", true);
            Test ts2 = new Test("Calculus", true);
            Test ts3 = new Test("C++", true);

            Student st = new Student("Igor", "Zapor", new DateTime(2001, 01, 05), Education.Bachelor, 1);
            st.AddExams(ex1, ex2);
            st.AddTests(ts1, ts2);

            Console.WriteLine(st.ToString());

            // 3
            Console.WriteLine("\n********** 3 **********");
            Console.WriteLine(st.Person);

            // 4
            Console.WriteLine("\n********** 4 **********");
            Student stcpy = (Student)st.DeepCopy();

            Console.WriteLine("Before changes:");
            Console.WriteLine(st.ToString());
            Console.WriteLine(stcpy.ToString());

            st.Name = "NewName";
            st.Surname = "NewSurname";
            st.BirthDate = new DateTime(2001, 01, 01);
            st.Degree = Education.SecondEducation;
            st.Form = 10;
            st.AddExams(ex3);
            st.AddTests(ts3);
            
            Console.WriteLine("\nAfter changes:");
            Console.WriteLine(st.ToString());
            Console.WriteLine(stcpy.ToString());

            // 5
            Console.WriteLine("\n********** 5 **********");
            try
            {
                st.Form = -1;
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }

            // 6
            Console.WriteLine("\n********** 6 **********");
            foreach (var obj in st.GetTestsAndExams())
            {
                Console.WriteLine(obj);
            }

            // 7
            Console.WriteLine("\n********** 7 **********");
            try
            {
                foreach (Exam ex in st.GetExamsWithMark(0))
                {
                    Console.WriteLine(ex);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }

            // 8
            Console.WriteLine("\n********** 8 **********");
            Console.WriteLine("Subjects that are in Tests and Exams:");
            foreach(var subj in st)
            {
                Console.WriteLine(subj);
            }

            // 9
            Console.WriteLine("\n********** 9 **********");
            Console.WriteLine("Passed Tests and Exams: ");
            foreach(var subj in st.GetPassedTestsAndExams())
            {
                Console.WriteLine(subj);
            }
            // 10
            Console.WriteLine("\n********** 10 **********");
            Console.WriteLine("Passed Tests with Exams: ");
            foreach(Test ts in st.GetPassedTestsWithExams())
            {
                Console.WriteLine(ts);
            }
            Console.ReadLine();
        }
    }
}
