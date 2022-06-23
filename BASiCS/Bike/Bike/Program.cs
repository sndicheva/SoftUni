using System;

namespace Bike
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorCount = int.Parse(Console.ReadLine());
            int seniorCount = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            double tax = 0;

            if (trace == "trail")
            {
                tax = juniorCount * 5.50 + seniorCount * 7;
            }
            else if (trace == "cross-country")
            {
                tax = juniorCount * 8 + seniorCount * 9.50;
                if ((juniorCount + seniorCount) >= 50)
                {
                    tax -= tax * 0.25;
                }
            }
            else if (trace == "downhill")
            {
                tax = juniorCount * 12.25 + seniorCount * 13.75;
            }
            else
            {
                tax = juniorCount * 20 + seniorCount * 21.50;
            }
            tax -= tax * 0.05;
            Console.WriteLine($"{tax:f2}");
        }
    }
}
