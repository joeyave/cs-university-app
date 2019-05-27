using System;
using System.Collections.Generic;
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
        // Generates collections with given number of elements.
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

        }
        // Properties
    }
}
