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

            //Exam ex1 = new Exam("Calculus", 3, new DateTime(2019, 07, 02));
            //Exam ex2 = new Exam("C#", 5, new DateTime(2019, 07, 08));
            //Exam ex3 = new Exam("C++", 5, new DateTime(2019, 06, 28));
            //Exam ex4 = new Exam("Discrete mathematics", 5, new DateTime(2019, 07, 10));
            //Exam ex5 = new Exam("Requirements Engineering", 3, new DateTime(2019, 06, 05));
            //Exam ex6 = new Exam("History", 2, new DateTime(2019, 06, 15));

            //// 1
            //Console.WriteLine("\n****** First Excersize ******");

            //Student s1 = new Student("Vlas", "Novokhatnii", new DateTime(2001, 12, 12), Education.Bachelor, 1);
            //Console.WriteLine(s1.ToShortString());

            //// 2
            //Console.WriteLine("\n****** Second Excersize ******");

            //s1.Exams = new List<Exam> { ex1, ex2 };
            //Console.WriteLine(s1.ToShortString());

            //// 3
            //Console.WriteLine("\n****** Third Excersize ******");

            //s1.AddExams(ex3, ex4, ex5, ex6);
            //Console.WriteLine(s1.ToString());

            // 1
            Person p1 = new Person("Vlas", "Novokhatnii", new DateTime(2001, 12, 12));
            Person p2 = new Person("Vlas", "Novokhatnii", new DateTime(2001, 12, 12));


            Console.WriteLine($"Equals: {p1 == p2}");
            Console.WriteLine($"\nReferenceEquals: {ReferenceEquals(p1, p2)}");
            Console.WriteLine($"\np1: {p1} \nHC: {p1.GetHashCode()} \np2: {p2} \nHC: {p2.GetHashCode()}");

            // 2
            Exam ex1 = new Exam("Calculus", 3, new DateTime(2019, 07, 02));
            Exam ex2 = new Exam("C#", 5, new DateTime(2019, 07, 08));
            Exam ex3 = new Exam("C++", 5, new DateTime(2019, 06, 28));

            Test ts1 = new Test("Term 1. Discrete mathematics", true);
            Test ts2 = new Test("Term 2. Calculus", true);

            Student st = new Student("Igor", "Zapor", new DateTime(2002, 01, 01), Education.Bachelor, 1);
            st.AddExams(ex1, ex2);
            st.AddTests(ts1, ts2);

            Console.WriteLine(st.ToString());

            // 3
            Console.WriteLine(st.Person);

            // 4
            Student stcpy = (Student)st.DeepCopy();

            st.Name = "Changed";
            st.BirthDate = new DateTime(2000, 05, 05);
            st.Degree = Education.SecondEducation;
            st.Form = 2;
            st.AddExams(ex3);
            st.AddTests(ts1);
            
            Console.WriteLine("\n------After changes.------");
            Console.WriteLine(st.ToString());
            Console.WriteLine(stcpy.ToString());

            // 5
            try
            {
                st.Form = -1;
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }

            // 6
            foreach(var obj in st.GetTestsAndExams())
            {
                Console.WriteLine(obj);
            }

            // 7
            Console.WriteLine("\n***** Ex. 7 *****");

            foreach(Exam ex in st.GetExamsWithMark(3))
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
