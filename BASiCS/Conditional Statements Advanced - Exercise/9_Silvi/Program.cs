using System;

namespace Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string visit = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double price = 0.0;
            int nights = number - 1;

            if (visit == "room for one person")
            {
                price = nights * 18.00;

            }
            else if (visit == "apartment")
            {
                if (number < 10)
                {
                    price = nights * 25.00;
                    price = price - price * 0.3;
                }
                else if (number >= 10 && number <= 15)
                {
                    price = nights * 25.00;
                    price = price - price * 0.35;
                }
                else
                {
                    price = nights * 25.00;
                    price = price - price * 0.5;
                }
            }
            else if (visit == "president apartment")
            {
                if (number < 10)
                {
                    price = nights * 35.00;
                    price = price - price * 0.1;
                }
                else if (number >= 10 && number <= 15)
                {
                    price = nights * 35.00;
                    price = price - price * 0.15;
                }

                else
                {
                    price = nights * 35.00;
                    price = price - price * 0.2;
                }
            }
            if (evaluation == "positive")
            {
                Console.WriteLine($"{(price + price * 0.25):f2}");
            }
            else
            {
                Console.WriteLine($"{(price - price * 0.1):f2}");
            }

        }
    }
}

