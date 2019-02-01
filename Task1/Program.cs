using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of a class.
            Student student1 = new Student("Artem", "Gorbachev", 16, "11B",
                new Mark[] { new Mark("Mathematics", 9), new Mark("Physics", 8), new Mark("Russian language", 6) });

            GetInfoAboutStudent(student1);

            //getting average mark using the method GetAvgMark
            Console.WriteLine($"Average mark: {student1.GetAvgMark():#.##}\n");

            //assignment of all marks' value to 0.
            student1.ResetAllMarks();

            GetInfoAboutStudent(student1);

            Console.ReadKey();
        }

        public static void GetInfoAboutStudent(Student student)
        {
            Console.WriteLine($"First name: {student.FName}\nLast name: {student.LName}\nAge: {student.Age}\nClass: {student.Class}\nMarks:");
            foreach (Mark mark in student.Marks)
            {
                Console.WriteLine($"{mark.SubjectName} - {mark.Value}");
            }
            Console.WriteLine();
        }
    }
}
