using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class StudentAvgMarkComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1?.AvgMark > s2?.AvgMark)
            {
                return 1;
            }
            if (s1?.AvgMark < s2?.AvgMark)
            {
                return -1;
            }
            return 0;
        }
    }
}
