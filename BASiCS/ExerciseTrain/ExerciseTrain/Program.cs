using System;

namespace _03_Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine(); //("Bansko",  "Borovets", "Varna" или "Burgas"
            string packet = Console.ReadLine(); //("noEquipment",  "withEquipment", "noBreakfast" или "withBreakfast")
            string vipdiscount = Console.ReadLine(); // yes or no
            int days = int.Parse(Console.ReadLine());
            double pricePerDay = 0;
            double discount = 0;
            double endPrice = 0;

            switch (town)
            {
                case "Bansko":
                case "Borovets":
                    if (packet == "withEquipment")
                    {
                        pricePerDay = 100;
                        discount = 0.1;
                    }
                    else if (packet == "noEquipment")
                    {
                        pricePerDay = 80;
                        discount = 0.05;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    break;
                case "Varna":
                case "Burgas":
                    if (packet == "withBreakfast")
                    {
                        pricePerDay = 130;
                        discount = 0.12;
                    }
                    else if (packet == "noBreakfast")
                    {
                        pricePerDay = 100;
                        discount = 0.07;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    return;

            }
            if (days > 7)
            {
                endPrice = (days - 1) * pricePerDay;
                if (vipdiscount == "yes")
                {
                    endPrice = endPrice - (endPrice * discount);
                }
            }
            else if (days <= 7 && days >= 1)
            {
                endPrice = days * pricePerDay;
                if (vipdiscount == "yes")
                {
                    endPrice = endPrice - (endPrice * discount);
                }
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            if (endPrice > 0)
            {
                Console.WriteLine($"The price is {endPrice:f2}lv! Have a nice time!");
            }

        }
    }
}