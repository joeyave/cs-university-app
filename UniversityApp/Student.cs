using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class Student
    {
        // Fields
        private Person _person;
        private Education _education;
        private int _form;
        private Exam[] _examInfo;

        // Constructors
        public Student(Person person, Education education, int form)
        {
            Person = person;
            Education = education;
            Form = form;
        }

        public Student() { }

        // Methods
        public void AddExams(params Exam[] exams)
        {
            if (ExamInfo == null)
            {
                ExamInfo = exams;
            }
            else
            {                
                Array.Resize(ref _examInfo, exams.Length + ExamInfo.Length);
                exams.CopyTo(ExamInfo, ExamInfo.Length - exams.Length);
            }
        }

        public override string ToString()
        {
            string s = "\nExams: ";
           
            for (int i = 0; i < ExamInfo.Length; i++)
            {
                s += ExamInfo[i] + ";\n ";
            }

            return "\n" + Person +
                    "\nEducation: " + Education +
                    "\nForm: " + Form + "\n" + s;  
        }

        public virtual string ToShortString()
        {
            return Person +
                    "\nEducation: " + Education +
                    "\nForm: " + Form +
                    "\nAverage mark: " + AvgMark;
        }

        // Properties
        public Person Person
        {
            get => _person;
            set => _person = value;
        }
        public Education Education
        {
            get => _education;
            set => _education = value;
        }
        public int Form
        {
            get => _form;
            set => _form = value;
        }

        public Exam[] ExamInfo
        {
            get => _examInfo;
            set => _examInfo = value;
        }

        public double AvgMark
        {
            get
            {
                if (ExamInfo == null)
                    return 0;

                double temp = 0;

                for (int i = 0; i < ExamInfo.Length; i++)
                {
                    temp += ExamInfo[i].Mark;
                }
                return temp / ExamInfo.Length;
            }
        }
    }
}
