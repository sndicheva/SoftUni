using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenuOrder = int.Parse(Console.ReadLine());
            int fishMenuOrder = int.Parse(Console.ReadLine());
            int veganMenuOrder = int.Parse(Console.ReadLine());

            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double veganMenuPrice = 8.15;
            double deliveryCost = 2.50;

            double order = chickenMenuOrder * chickenMenuPrice + fishMenuOrder * fishMenuPrice + veganMenuOrder * veganMenuPrice;
            double desert = order * 20 / 100;

            double totalOrderPrice = order + desert + deliveryCost;

            Console.WriteLine(totalOrderPrice);
        }
    }
}
