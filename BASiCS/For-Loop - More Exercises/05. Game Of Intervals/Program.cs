using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double n1 = 0;//From 0 to 9
            double n2 = 0;//From 10 to 19
            double n3 = 0;//From 20 to 29
            double n4 = 0;//From 30 to 39
            double n5 = 0;//From 40 to 50

            double result = 0;
            int intN1 = 0;
            int intN2 = 0;
            int intN3 = 0;
            int intN4 = 0;
            int intN5 = 0;
            int intN6 = 0;


            for (int i = 1; i <= moves; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    n1 = number * 0.2;
                    result += n1;
                    intN1++;
                }
                else if (number >= 10 && number <= 19)
                {
                    n2 = number * 0.3;
                    result += n2;
                    intN2++;
                }
                else if (number >= 20 && number <= 29)
                {
                    n3 = number * 0.4;
                    result += n3;
                    intN3++;
                }
                else if (number >= 30 && number <= 39)
                {
                    n4 = 50;
                    result += n4;
                    intN4++;
                }
                else if (number >= 40 && number <= 50)
                {
                    n5 = 100;
                    result += n5;
                    intN5++;
                }
                else
                {
                    result = result / 2;
                    intN6++;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {intN1 * 1.0 / moves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {intN2 * 1.0 / moves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {intN3 * 1.0 / moves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {intN4 * 1.0 / moves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {intN5 * 1.0 / moves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {intN6 * 1.0 / moves * 100:f2}%");

        }
    }
}
