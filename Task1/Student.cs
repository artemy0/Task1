using System;

namespace Task1
{
    class Student
    {
        //personal information
        public string FName { get; set; } // I could specify Get and Set method.
        public string LName { get; set; }
        public string Class { get; set; }
        private int age;
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

        //the constructor has a few parameter named FName, LName, Age, Class and Marks, of type string, string, int, string and Mark[]!!!
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

        // the method GetInfoAboutStudent has no parameter!!!
        public void GetInfoAboutStudent()
        {
            Console.WriteLine($"First name: {FName}\nLast name: {LName}\nAge: {Age}\nClass: {Class}\nMarks:");
            //there's used foreach statement iterates!!!
            foreach (Mark mark in Marks)
            {
                Console.WriteLine($"{mark.SubjectName} - {mark.Value}");
            }
            Console.WriteLine();
        }

        //the method GoToTheNextClass has a parameters named Number and Character, of type int and char!!!
        public void GoToTheNextClass(int Number, char Character)
        {
            Class = Number.ToString() + Character.ToString();
        }
    }
}
