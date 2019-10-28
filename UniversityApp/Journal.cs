using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public class Journal<TKey>
    {
        private List<JournalEntry<TKey>> journalEntries = new List<JournalEntry<TKey>>();

        public void StudentsChanged(object sender, StudentsChangedEventArgs<TKey> args)
        {
            journalEntries.Add(new JournalEntry<TKey>
                (args?.CollectionName, args.Action, args.ChangedPropName, args.Key));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            foreach (var je in journalEntries)
            {
                sb.AppendLine(je.ToString());
            }

            return sb.ToString();
        }
    }
}
