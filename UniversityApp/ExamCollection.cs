using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class ExamCollection : ICollection<Exam>
    {
        public IEnumerator<Exam> GetEnumerator()
        {
            return new ExamEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ExamEnumerator(this);
        }

        // The inner collection to store objects.
        private List<Exam> innerCol;

        public ExamCollection()
        {
            innerCol = new List<Exam>();
        }

        // Adds an index to the collection.
        public Exam this[int index]
        {
            get { return (Exam)innerCol[index]; }
            set { innerCol[index] = value; }
        }

        // Determines if an item is in the collection
        // by using the ExamSameDimensions equality comparer.
        public bool Contains(Exam item)
        {
            bool found = false;

            foreach (Exam bx in innerCol)
            {
                // Equality defined by the Exam
                // class's implmentation of IEquitable<T>.
                if (bx.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }

        // Determines if an item is in the 
        // collection by using a specified equality comparer.
        public bool Contains(Exam item, EqualityComparer<Exam> comp)
        {
            bool found = false;

            foreach (Exam bx in innerCol)
            {
                if (comp.Equals(bx, item))
                {
                    found = true;
                }
            }

            return found;
        }

        // Adds an item if it is not already in the collection
        // as determined by calling the Contains method.
        public void Add(Exam item)
        {

            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine("A box with {0}x{1}x{2} dimensions was already added to the collection.",
                    item.Height.ToString(), item.Length.ToString(), item.Width.ToString());
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public void CopyTo(Exam[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

        public int Count
        {
            get
            {
                return innerCol.Count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Exam item)
        {
            bool result = false;

            // Iterate the inner collection to 
            // find the box to be removed.
            for (int i = 0; i < innerCol.Count; i++)
            {

                Exam curExam = (Exam)innerCol[i];

                if (new ExamSameDimensions().Equals(curExam, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}