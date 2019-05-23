using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class PersonDateBirthComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            if (p1?.BirthDate > p2?.BirthDate)
            {
                return 1;
            }
            if (p1?.BirthDate < p2?.BirthDate)
            {
                return -1;
            }
            return 0;
        }
    }
}
