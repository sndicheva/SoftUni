using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            int nQuantity = int.Parse(Console.ReadLine());
            int mQuantity = int.Parse(Console.ReadLine());

            double nTotal = (n / 1.94) * nQuantity;
            double mTotal = (m / 1.94) * mQuantity;
            double totalCostEuro = nTotal + mTotal;

            Console.WriteLine($"{totalCostEuro:f2}");
        }
    }
}
