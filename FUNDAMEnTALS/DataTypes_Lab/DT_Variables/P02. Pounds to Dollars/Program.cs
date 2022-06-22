using System;

namespace P02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            double usdRate = 1.31;

            double poundsToUsd = pounds * usdRate;

            Console.WriteLine($"{poundsToUsd:f3}");
        }
    }
}
