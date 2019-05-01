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
            Exam ex1 = new Exam("Calculus",                 3, new DateTime(2019, 07, 02));
            Exam ex2 = new Exam("C#",                       5, new DateTime(2019, 07, 08));
            Exam ex3 = new Exam("C++",                      5, new DateTime(2019, 06, 28));
            Exam ex4 = new Exam("Discrete mathematics",     5, new DateTime(2019, 07, 10));
            Exam ex5 = new Exam("Requirements Engineering", 3, new DateTime(2019, 06, 05));
            Exam ex6 = new Exam("History",                  2, new DateTime(2019, 06, 15));

            // 1
            Console.WriteLine("\n****** First Excersize ******");

            Student s1 = new Student();
            Console.WriteLine(s1.ToShortString());

            // 2
            Console.WriteLine("\n****** Second Excersize ******");

            s1.Person = new Person("Vlas", "Novokhatnii", new DateTime(2001, 12, 12));
            s1.Education = Education.Bachelor;
            s1.Form = 1;
            s1.ExamInfo = new Exam[] { ex1, ex2 };      
            Console.WriteLine(s1.ToString());

            // 3
            Console.WriteLine("\n****** Third Excersize ******");

            s1.AddExams(ex3, ex4, ex5, ex6);
            Console.WriteLine(s1.ToString());

            int rows;
            int cols;

            bool checkParse;

            do
            {
                checkParse = true;

                Console.WriteLine("Input number of rows and columns. Use <,> < > or <;>.");
                string str = Console.ReadLine();
                string[] strConcat = str.Split(' ', ',', ';');

             
                if (!int.TryParse(strConcat[0], out rows) | rows <= 0 & !int.TryParse(strConcat[1], out cols) | cols <= 0)
                {
                    Console.WriteLine($"{strConcat[0]} or {strConcat[1]} doesn't match. Try again.");
                    checkParse = false;
                }
            } while (checkParse == false);

            int square = rows * cols;

            // 1D array
            Exam[] arr1D = new Exam[square];

            // 2D array
            Exam[,] arr2D = new Exam[rows, cols];

            // Jagged array
            Exam[][] jaggedArr = new Exam[rows][];
            for (int i = 0; i < rows; i++)
                jaggedArr[i] = new Exam[cols];


            // Initialising
            for (int i = 0; i < arr1D.Length; i++)
            {
                arr1D[i] = new Exam();
            }

            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    arr2D[i, j] = new Exam();
                }
            }

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = new Exam();
                }
            }


            //Time checking
            int start = Environment.TickCount;            
            for (int i = 0; i < arr1D.Length; i++)
            {
                arr1D[i].Subject = "HAHAHA";
            }
            int end = Environment.TickCount;

            Console.WriteLine("One-dimensoinal array used {0} ms.", end - start);

            start = Environment.TickCount;
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    arr2D[i, j].Subject = "HAHAHA";
                }
            }
            end = Environment.TickCount;

            Console.WriteLine("Two-dimensoinal array used {0} ms.", end - start);

            start = Environment.TickCount;
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j].Subject = "HAHAHA";
                }
            }
            end = Environment.TickCount;

            Console.WriteLine("Jagged array used {0} ms.", end - start);

            Console.ReadLine();
        }
    }
}
