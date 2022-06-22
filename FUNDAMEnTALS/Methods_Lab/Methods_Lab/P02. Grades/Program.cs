using System;

namespace P02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double grade = double.Parse(input);

            PrintGrade(grade);

        }

        static void PrintGrade(double grade)
        {
            if (grade >= 2 && grade < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3 && grade < 3.5)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.5 && grade < 4.5)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.5 && grade <5.5)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.5 && grade <=6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
