using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        
        public string Town { get; set; }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town) : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Town = " + this.Town);

            return result.ToString();
        }
    }
}
