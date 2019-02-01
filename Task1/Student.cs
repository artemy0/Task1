using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student
    {
        //personal information
        public string FName { get; set; } // I could specify Get and Set method.
        public string LName { get; set; }
        public string Class { get; set; }
        public int age;
        public int Age
        {
            get{ return age;}
            set
            {
                if (value >= 0)
                    age = value;
                else
                    throw new Exception("A person's age can not be less than zero.");
            }
        }

        //array of Marks
        public Mark[] Marks;

        public Student(string FName, string LName, int Age, string Class, params Mark[] Marks)
        {
            this.FName = FName;
            this.LName = LName;
            this.Age = Age;
            this.Class = Class;
            this.Marks = Marks;
        }

        //GetAvgMark (returning average of all marks) method
        public double GetAvgMark()
        {
            double res = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                res += Marks[i].Value;
            }
            res /= Marks.Length;
            return res;
        }

        //ResetAllMarks (making all student’s marks equal to zero) method
        public void ResetAllMarks()
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                Marks[i].Value = 0;
            }
        }
    }
}
