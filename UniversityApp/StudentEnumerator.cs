using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{

    public class StudentEnumerator : IEnumerator
    {
        string[] subjects;
        int position = -1;

        public StudentEnumerator(string[] s)
        {
            subjects = s;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= subjects.Length)
                    throw new InvalidOperationException();
                return subjects[position];
            }
        }

        public bool MoveNext()
        {
            if (position < subjects.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
