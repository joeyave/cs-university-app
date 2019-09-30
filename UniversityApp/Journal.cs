using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class Journal
    {
        private List<JournalEntry> listOfChanges = new List<JournalEntry>();

        public void CountChanged(object source, StudentListHandlerEventArgs args)
        {
            listOfChanges.Add(new JournalEntry(args.CollectionName, 
                args.CollectionChanges, $"{args.GetStudent.Name} {args.GetStudent.Surname}"));
        }

        public void RefferenceChanged(object source, StudentListHandlerEventArgs args)
        {
            listOfChanges.Add(new JournalEntry(args.CollectionName,
                args.CollectionChanges, $"{args.GetStudent.Name} {args.GetStudent.Surname}"));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            foreach (JournalEntry je in listOfChanges)
            {
                sb.AppendLine(je.ToString());
            }

            return sb.ToString();
        }
    }
}
