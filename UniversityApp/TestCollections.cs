using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class TestCollections
    {
        // Field Data
        List<Person> listOfPersons = new List<Person>();
        List<string> listOfStrings = new List<string>();
        Dictionary<Person, Student> dictPersonStudent = new Dictionary<Person, Student>();
        Dictionary<string, Student> dictStringStudent = new Dictionary<string, Student>();

        // Constructors
        // Generates collections with given number of the elements.
        public TestCollections(int elemNum)
        {
            for(int i = 0; i < elemNum; i++)
            {
                listOfPersons.Add(GetStudent(i).Person);
                listOfStrings.Add(GetStudent(i).Person.ToString());
                dictPersonStudent.Add(GetStudent(i).Person, GetStudent(i));
                dictStringStudent.Add(GetStudent(i).Person.ToString(), GetStudent(i));
            }
        }

        // Methods
        public static Student GetStudent(int ssn)
        {
            Student st = new Student(ssn.ToString(), ssn.ToString(),
                new DateTime(2019 - (ssn % 3), 12 - (ssn % 3), 30 - (ssn % 3)), 
                (Education)(3 - (ssn % 3)), 6 - (ssn % 6));

            return st;
        }

        public void GetSearchTime()
        {
            int listCount = listOfPersons.Count;
            int firstElementIndex = 0;
            int middleElementIndex = listCount / 2;
            int lastElementIndex = listCount - 1;
            int fakeElementIndex = listCount * 2;

            long ticksThisTime = 0;
            Stopwatch timePerParse;

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("***** Get Search Time Method *****");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("--------------First Element.--------------");

            // List of Persons
            timePerParse = Stopwatch.StartNew();
            bool contains = listOfPersons.Contains(GetStudent(firstElementIndex).Person);
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"List of Persons contains {GetStudent(firstElementIndex).Person} element. " +
                $"{contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            //List of strings
            timePerParse = Stopwatch.StartNew();
            contains = listOfStrings.Contains(GetStudent(firstElementIndex).Person.ToString());
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"List of Strings contains {GetStudent(firstElementIndex).Person.ToString()} element. " +
                $"{contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            // Dictionary of Students with Person Key
            timePerParse = Stopwatch.StartNew();
            contains = dictPersonStudent.ContainsKey(GetStudent(firstElementIndex).Person);
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"Dictionary of Students with Person Key contains " +
                $"{GetStudent(firstElementIndex).Person.ToString()} element. {contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            // Dictionary of Students with string Key
            timePerParse = Stopwatch.StartNew();
            contains = dictStringStudent.ContainsKey(GetStudent(firstElementIndex).Person.ToString());
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"Dictionary of Students with string Key contains " +
                $"{GetStudent(firstElementIndex).Person.ToString()} element. {contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");


            Console.WriteLine("\n--------------Middle Element.--------------");

            // List of Persons
            timePerParse = Stopwatch.StartNew();
            contains = listOfPersons.Contains(GetStudent(middleElementIndex).Person);
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"List of Persons contains {GetStudent(middleElementIndex).Person} element. " +
                $"{contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            //List of strings
            timePerParse = Stopwatch.StartNew();
            contains = listOfStrings.Contains(GetStudent(middleElementIndex).Person.ToString());
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"List of Strings contains {GetStudent(middleElementIndex).Person.ToString()} element. " +
                $"{contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            // Dictionary of Students with Person Key
            timePerParse = Stopwatch.StartNew();
            contains = dictPersonStudent.ContainsKey(GetStudent(middleElementIndex).Person);
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"Dictionary of Students with Person Key contains " +
                $"{GetStudent(middleElementIndex).Person.ToString()} element. {contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            // Dictionary of Students with string Key
            timePerParse = Stopwatch.StartNew();
            contains = dictStringStudent.ContainsKey(GetStudent(middleElementIndex).Person.ToString());
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"Dictionary of Students with string Key contains " +
                $"{GetStudent(middleElementIndex).Person.ToString()} element. {contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            Console.WriteLine("\n--------------Last Element.--------------");

            // List of Persons
            timePerParse = Stopwatch.StartNew();
            contains = listOfPersons.Contains(GetStudent(lastElementIndex).Person);
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"List of Persons contains {GetStudent(lastElementIndex).Person} element. " +
                $"{contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            //List of strings
            timePerParse = Stopwatch.StartNew();
            contains = listOfStrings.Contains(GetStudent(lastElementIndex).Person.ToString());
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"List of Strings contains {GetStudent(lastElementIndex).Person.ToString()} element. " +
                $"{contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            // Dictionary of Students with Person Key
            timePerParse = Stopwatch.StartNew();
            contains = dictPersonStudent.ContainsKey(GetStudent(lastElementIndex).Person);
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"Dictionary of Students with Person Key contains " +
                $"{GetStudent(lastElementIndex).Person.ToString()} element. {contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            // Dictionary of Students with string Key
            timePerParse = Stopwatch.StartNew();
            contains = dictStringStudent.ContainsKey(GetStudent(lastElementIndex).Person.ToString());
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"Dictionary of Students with string Key contains " +
                $"{GetStudent(lastElementIndex).Person.ToString()} element. {contains}");
            Console.WriteLine($"The search took {ticksThisTime - 1} ticks.");

            Console.WriteLine("\n--------------Fake Element.--------------");

            // List of Persons
            timePerParse = Stopwatch.StartNew();
            contains = listOfPersons.Contains(GetStudent(fakeElementIndex).Person);
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"List of Persons contains {GetStudent(fakeElementIndex).Person} element. " +
                $"{contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            //List of strings
            timePerParse = Stopwatch.StartNew();
            contains = listOfStrings.Contains(GetStudent(fakeElementIndex).Person.ToString());
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"List of Strings contains {GetStudent(fakeElementIndex).Person.ToString()} element. " +
                $"{contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            // Dictionary of Students with Person Key
            timePerParse = Stopwatch.StartNew();
            contains = dictPersonStudent.ContainsKey(GetStudent(fakeElementIndex).Person);
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"Dictionary of Students with Person Key contains " +
                $"{GetStudent(fakeElementIndex).Person.ToString()} element. {contains}");
            Console.WriteLine($"The search took {ticksThisTime} ticks.");

            // Dictionary of Students with string Key
            timePerParse = Stopwatch.StartNew();
            contains = dictStringStudent.ContainsKey(GetStudent(fakeElementIndex).Person.ToString());
            timePerParse.Stop();
            ticksThisTime = timePerParse.ElapsedTicks;

            Console.WriteLine($"Dictionary of Students with string Key contains " +
                $"{GetStudent(fakeElementIndex).Person.ToString()} element. {contains}");
            Console.WriteLine($"The search took {ticksThisTime - 1} ticks.");
        }
        // Properties
    }
}
