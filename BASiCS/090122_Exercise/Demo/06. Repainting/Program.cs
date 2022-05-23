using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // kolichestva - najlon, boja, razreditel, chasove  - int
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            // costs - nylonPrice = 1.50, paintPrice - 14.50, thinnerPrice - 5.00
            // reserve - paint + (paint * 10 / 100)
            // reserve - nylon * 2
            // bags - bagCost = 0.40
            // workHour = sumMatherialCosts * 30/100
            // workCost = hours * workHour
            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = (paint + paint * 0.1) * 14.50;
            double thinnerPrice = thinner * 5;
            double bagPrice = 0.40;
            double matherialsCost = nylonPrice + paintPrice + thinnerPrice + bagPrice;
            double workCost = (matherialsCost * 0.3) * hours;
            double finalPrice = matherialsCost + workCost;

            Console.WriteLine(finalPrice);
        }
    }
}
