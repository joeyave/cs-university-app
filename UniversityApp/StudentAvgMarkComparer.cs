using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class StudentAvgMarkComparer<TKey> : IComparer<Student<TKey>>
    {
        public int Compare(Student<TKey> s1, Student<TKey> s2)
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
