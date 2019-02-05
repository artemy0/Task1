using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of a class.
            Student student1 = new Student("Artem", "Gorbachev", 16, "11B",
                new Mark[] { new Mark("Mathematics", 9), new Mark("Physics", 8), new Mark("Russian language", 6) });
            Student student2 = new Student("Mark", "Petrov", 17, "11B",
                new Mark[] { new Mark("Mathematics", 7), new Mark("Physics", 8), new Mark("Russian language", 9) });
            Student student3 = new Student("Alexey", "Yakushkin", 16, "11B",
                new Mark[] { new Mark("Mathematics", 8), new Mark("Physics", 7), new Mark("Russian language", 9) });

            //array of students
            Student[] students = new Student[] { student1, student2, student3 };

            bool iteration = true;
            //there's used do-while statement!!!
            do
            {
                Console.Write($"Select student number from 0 to {students.Length-1}. Or any other number/character to exit: ");
                int number = Convert.ToInt32(Console.ReadLine());

                //there's used switch statement!!!
                switch (number)
                {
                    case 0:
                    case 1:
                    case 2:
                        students[number].GetInfoAboutStudent();
                        //getting average mark using the method GetAvgMark
                        Console.WriteLine($"Average mark: {student1.GetAvgMark():#.##}\n");
                        break;
                    default:
                        iteration = false;
                        break;
                }

            } while (iteration);

            //assignment of all marks' value to 0 + there's used for statement iterates!!!
            for (int i = 0; i < students.Length; i++)
                students[i].ResetAllMarks();

            Console.WriteLine("Thanks for work.");
            Console.ReadKey();
        }
    }
}
