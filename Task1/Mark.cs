using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Mark
    {
        //name of a subject
        public string SubjectName { get; set; }
        //mark of a subject
        public int Value { get; set; }

        public Mark(string SubjectName, int Value = 0)
        {
            this.SubjectName = SubjectName;
            this.Value = Value;
        }
    }
}
