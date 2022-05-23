using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rate = Console.ReadLine();

            double price = 0.0;
            int nights = days - 1;

            switch (roomType)
            {
                case "room for one person":
                    price = nights * 18.00;
                    break;
                case "apartment":
                    price = nights * 25.00;
                    if (days < 10)
                    {
                        price -= price * 0.30;
                    }
                    else if (days >= 10 && days < 15)
                    {
                        price -= price * 0.35;
                    }
                    else
                    {
                        price -= price * 0.50;
                    }
                    break;
                case "president apartment":
                    price = nights * 35.00;
                    if (days < 10)
                    {
                        price -= price * 0.10;
                    }
                    else if (days >= 10 && days < 15)
                    {
                        price -= price * 0.35;
                    }
                    else
                    {
                        price -= price * 0.20;
                    }
                    break;                
            }
            if (rate == "positive")
            {

                price += price * 0.25;
                Console.WriteLine($"{price:f2}");
            }
            else
            {
                price -= price * 0.10;
                Console.WriteLine($"{price:f2}");
            }
        }
        
    }
}

