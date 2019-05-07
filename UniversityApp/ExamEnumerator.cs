using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{

    public class ExamEnumerator : IEnumerator<Exam>
    {
        private ExamCollection _collection;
        private int curIndex;
        private Exam curExam;


        public ExamEnumerator(ExamCollection collection)
        {
            _collection = collection;
            curIndex = -1;
            curExam = default(Exam);

        }

        public bool MoveNext()
        {
            //Avoids going beyond the end of the collection.
            if (++curIndex >= _collection.Count)
            {
                return false;
            }
            else
            {
                // Set current box to next item in collection.
                curExam = _collection[curIndex];
            }
            return true;
        }

        public void Reset() { curIndex = -1; }

        void IDisposable.Dispose() { }

        public Exam Current
        {
            get { return curExam; }
        }


        object IEnumerator.Current
        {
            get { return Current; }
        }

    }

}
