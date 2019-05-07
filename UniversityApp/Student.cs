using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class Student : Person, IDateAndCopy
    {
        // Field Data
        private Education degree;
        private int form;
        private List<Test> tests = new List<Test>();
        private List<Exam> exams = new List<Exam>();

        // Constructors
        public Student(string stName, string stSurname, DateTime stBirthDate,
            Education stDegree, int stForm)
            : base(stName, stSurname, stBirthDate)
        {
            Degree = stDegree;
            Form = stForm;
        }

        public Student() : base() { }

        // Methods
        public void AddExams(params Exam[] exams) => Exams.AddRange(exams);

        public void AddTests(params Test[] tests) => Tests.AddRange(tests);

        public override string ToString()
        {
            string strEx = "\nExams: ";

            if (Exams != null)
            {
                foreach (var ex in Exams)
                {
                    strEx += ex + ";\n ";
                }
            }
            else
            {
                strEx += "N/A";
            }

            string strTs = "\nTests: ";

            if (Tests != null)
            {
                foreach (var ts in Tests)
                {
                    strTs += ts + ";\n ";
                }
            }
            else
            {
                strTs += "N/A";
            }


            return "\n" + base.ToString() + $"\nDegree: {Degree}, Form: {Form}\n" + strEx + strTs;
        }

        public virtual new string ToShortString()
        {
            return base.ToShortString() + $"\nDegree: {Degree} \nForm: {Form} \nAverage Mark = {AvgMark}\n";

        }

        public override object DeepCopy()
        {
            // First get a shallow copy
            Student newStudent = (Student)this.MemberwiseClone();

            // Then fill in the gaps
            List<Exam> currExams = new List<Exam>(this.Exams);
            newStudent.Exams = currExams;

            List<Test> currTests = new List<Test>(this.Tests);
            newStudent.Tests = currTests;

            return newStudent;
        }

        public IEnumerable GetTestsAndExams()
        {
            return actualImplementation();

            IEnumerable actualImplementation()
            {
                ArrayList mergedList = new ArrayList(Tests);
                mergedList.AddRange(Exams);

                foreach (var obj in mergedList)
                {
                    yield return obj;
                }
            }
        }

        public IEnumerable GetExamsWithMark(int mark)
        {
            if (mark > 5 || mark < 1)
            {
                throw new Exception("Mark out of range");
            }

            return actualImplementation();

            IEnumerable actualImplementation()
            {
                foreach (Exam ex in Exams)
                {
                    if (ex.Mark > mark)
                    {
                        yield return ex;
                    }
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            string[] strTests = new string[Tests.Count];
            string[] strExams = new string[Exams.Count];

            int i = 0;
            foreach(Test ts in Tests)
            {
                strTests[i] = ts.TestName;
                i++;
            }

            int j = 0;
            foreach (Exam ex in Exams)
            {
                strExams[j] = ex.Subject;
                j++;
            }

            string[] both = strExams.Intersect(strTests).ToArray();

            return new StudentEnumerator(both);
        }

        // Properties
        public Education Degree
        {
            get => degree;
            set => degree = value;
        }

        public int Form
        {
            get => form;
            set
            {
                if (value > 100 || value < 1)
                {
                    throw new Exception("Out of range.");
                }
                else
                {
                    form = value;
                }
            }
        }

        public List<Test> Tests
        {
            get => tests;
            set => tests = value;
        }

        public List<Exam> Exams
        {
            get => exams;
            set => exams = value;
        }

        public Person Person
        {
            get
            {
                return new Person(this.studentName, this.studentSurname, this.studentBirthDate);
            }
            set
            {
                new Person(value.Name, value.Surname, value.BirthDate);
            }
        }

        public double AvgMark
        {
            get
            {
                if (Exams == null)
                    return 0;

                double temp = 0;

                foreach (var ex in Exams)
                {
                    temp += ex.Mark;
                }
                return temp / Exams.Count;
            }
        }
    }
}
