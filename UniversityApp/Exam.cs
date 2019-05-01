using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class Exam
    {
        // 
        public string Subject { get; set; }
        public int Mark { get; set; }
        public DateTime ExamDate { get; set; }

        // Constructors
        public Exam(string subject, int mark, DateTime examDate)
        {
            Subject = subject;
            Mark = mark;
            ExamDate = examDate;
        }

        public Exam() { }

        // Methods
        public override string ToString()
        {
            return "\nSubject: " + Subject +
                   "\nMark: " + Mark +
                   "\nExam Date: " + ExamDate.ToShortDateString();
        }
    }
}
