using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBr = int.Parse(Console.ReadLine());
            string backer = string.Empty;
            string backerNo1 = string.Empty;
            string input = string.Empty;
            int countPoints = 0;
            int maxPoints = 0;
            int counter = 0;

            for (int i = 1; i <= easterBr; i++)
            {
                counter = 0;
                backer = Console.ReadLine();
                input = Console.ReadLine();
                while (input != "Stop")
                {
                    countPoints = int.Parse(input);
                    counter += countPoints;
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{backer} has {counter} points.");
                if (counter > maxPoints)
                {
                    maxPoints = counter;
                    backerNo1 = backer;
                    Console.WriteLine($"{backerNo1} is the new number 1!");
                }                
                
            }
            Console.WriteLine($"{backerNo1} won competition with {maxPoints} points!");
        }
    }
}
