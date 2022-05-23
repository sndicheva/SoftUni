using System;

namespace _05._Number__100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isLessThan200 = num <= 200;
            bool isGrThan100 = num >= 100;
            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (isGrThan100&isLessThan200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
