using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 1;
            double avarageGrade = 0;
            double sum = 0;
            int counter = 0;
            while (grade <= 12)
            {
                double gradeAvarage = double.Parse(Console.ReadLine());
                if (gradeAvarage <= 4)
                {
                    if (counter == 1)
                    {
                        break;
                    }
                    counter++;
                    continue;
                }
                sum += gradeAvarage;
                grade++;


            }
            avarageGrade = sum / 12;

            if (grade > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:F2}");

            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
        }
    }
}
