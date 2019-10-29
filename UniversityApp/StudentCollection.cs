using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class StudentCollection<TKey>
    {
        // Fields
        Dictionary<TKey, Student<TKey>> dictOfStudents = new Dictionary<TKey, Student<TKey>>();

        public delegate void StudentsChangedEventHandler<TKey>(object source, StudentsChangedEventArgs<TKey> args);
        public event StudentsChangedEventHandler<TKey> StudentsChanged;

        void PropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            StudentsChanged.Invoke(sender, new StudentsChangedEventArgs<TKey>
                (CollectionName, Action.Property, args.PropertyName, (sender as Student<TKey>).Key));
        }

        // Methods
        public void AddStudents(params Student<TKey>[] students)
        {
            foreach(Student<TKey> st in students)
            {
                dictOfStudents.Add(st.Key, st);
                StudentsChanged?.Invoke(this, new StudentsChangedEventArgs<TKey>
                    (CollectionName, Action.Add, st.Name, st.Key));
                st.PropertyChanged += PropertyChanged;
            }
        }

        public double Average()
        {
            return dictOfStudents.Values.Average(ret => ret.AvgMark);
        }

        public bool Remove(Student<TKey> st)
        {
            foreach (var item in dictOfStudents.Where(kvp => kvp.Value == st).ToList())
            {
                dictOfStudents.Remove(item.Key);
                StudentsChanged?.Invoke(this, new StudentsChangedEventArgs<TKey>
                    (CollectionName, Action.Remove, st.Name, st.Key));
                st.PropertyChanged -= PropertyChanged;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            foreach (var st in dictOfStudents)
            {
                sb.AppendLine(st.ToString());
            }

            return sb.ToString();
        }

        public string ToShortString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var st in dictOfStudents)
            {
                sb.AppendLine(st.Value.ToShortString());
            }

            return sb.ToString();
        }

        // Properties
        public string CollectionName { get; set; }
    }
}
