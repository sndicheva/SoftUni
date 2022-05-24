using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double transport = 0;
            double ticketsMoney = 0;
            double neededMoney = 0;

            if (num >= 1 && num <= 4)
            {
                transport = budget * 0.75;
            }
            else if (num >= 5 && num <= 9)
            {
                transport = budget * 0.6;
            }
            else if (num >= 10 && num <= 24)
            {
                transport = budget * 0.5;
            }
            else if (num > 24 && num < 50)
            {
                transport = budget * 0.4;
            }
            else if (num >= 50)
            {
                transport = budget * 0.25;
            }

            switch (category)
            {
                case "VIP":
                    ticketsMoney = num * 499.99;
                    break;
                default:
                    ticketsMoney = num * 249.99;
                    break;
            }
            neededMoney = transport + ticketsMoney;

            if (neededMoney <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - neededMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {neededMoney - budget:f2} leva.");
            }

        }
    }
}