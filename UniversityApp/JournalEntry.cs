using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public class JournalEntry<TKey>
    {
        public string CollectionName { get; set; }
        public Action Action { get; set; }
        public string ChangedPropName { get; set; }
        public TKey Key { get; set; }

        public JournalEntry(string collName, Action action, string propName, TKey key)
        {
            CollectionName = collName;
            Action = action;
            ChangedPropName = propName;
            Key = key;
        }

        public override string ToString()
        {
            return $"[Collection name: {CollectionName}, Action: {Action}, " +
                $"Changed Property: {ChangedPropName}, Key: {Key}]";
        }
    }
}
