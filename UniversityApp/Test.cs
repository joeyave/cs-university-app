using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp
{
    public class Test
    {
        // Constructors
        public Test(string testName, bool isPassed)
        {
            TestName = testName;
            IsPassed = isPassed;
        }

        public Test() { }

        // Methods
        public override string ToString()
        {
            return $"\nTest Name: {TestName}, Is Passed? {IsPassed}";
        }

        // Properties
        public string TestName { get; set; }
        public bool IsPassed { get; set; }
    }
}
