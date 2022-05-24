using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine(); //"Spring", "Summer", "Autumn" или "Winter"
            double kmPerMonth = double.Parse(Console.ReadLine());

            double paymentMonthly = 0;

            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    paymentMonthly = kmPerMonth * 0.75;
                }
                else if (season == "Summer")
                {
                    paymentMonthly = kmPerMonth * 0.90;
                }
                else
                {
                    paymentMonthly = kmPerMonth * 1.05;
                }
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    paymentMonthly = kmPerMonth * 0.95;
                }
                else if (season == "Summer")
                {
                    paymentMonthly = kmPerMonth * 1.10;
                }
                else
                {
                    paymentMonthly = kmPerMonth * 1.25;
                }
            }
            else
            {
                paymentMonthly = kmPerMonth * 1.45;
            }
            double payment = 4 * paymentMonthly;
            payment -= payment * 0.10;
            Console.WriteLine($"{payment:f2}");
        }
    }
}
