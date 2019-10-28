using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public class StudentsChangedEventArgs<TKey> : EventArgs
    {
        // Contains collection name.
        public string CollectionName { get; set; }
        // Contains information about cause of event calling.
        public Action Action { get; set; }
        // Contains property that was changed.
        public string ChangedPropName { get; set; }
        public TKey Key { get; set; }

        public StudentsChangedEventArgs(string collName, Action action, string propName, TKey key)
        {
            CollectionName = collName;
            Action = action;
            ChangedPropName = propName;
            Key = key;
        }

        public override string ToString()
        {
            return $"[Collection name: {CollectionName}, Action: {Action}, " +
                $"Changed Property: {ChangedPropName}, + Key: {Key}]";
        }
    }
}