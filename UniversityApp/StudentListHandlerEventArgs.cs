using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    class StudentListHandlerEventArgs : EventArgs
    {
        public string CollectionName { get; set; }  
        public string CollectionChanges { get; set; }
        public Student GetStudent { get; set; }

        public StudentListHandlerEventArgs(string name, string changes,
            Student student)
        {
            CollectionName = name;
            CollectionChanges = changes;
            GetStudent = student;
        }

        public StudentListHandlerEventArgs() { }

        public override string ToString()
        {
            return $"[Collection Name: {CollectionName}, Collection Changes: {CollectionChanges}. Student: {GetStudent}.\n";
        }
    }
}
