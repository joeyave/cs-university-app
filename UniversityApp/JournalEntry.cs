using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class JournalEntry
    {
        public string CollectionName { get; set; }  
        public string CollectionChanges { get; set; }
        public string StudentData { get; set; } 

        public JournalEntry(string colName, string colChanges, string stData)
        {
            CollectionName = colName;
            CollectionChanges = colChanges;
            StudentData = stData;
        }

        public override string ToString()
        {
            return $"Collection name: {CollectionName}. Collection changes: {CollectionChanges}. Student's data: {StudentData}";
        }
    }
}
