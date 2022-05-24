using System;

namespace _03._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine(); //"Bansko",  "Borovets", "Varna" или "Burgas"
            string pack = Console.ReadLine(); //"noEquipment",  "withEquipment", "noBreakfast" или "withBreakfast"
            string discount = Console.ReadLine(); // "yes" или "no"
            int days = int.Parse(Console.ReadLine());
            //double tax = 0;
            double disc = 0;
            double price = 0;
            double endPrice = 0;

            switch (city)
            {
                case "Bansko":
                case "Borovets":
                    if (pack == "noEquipment")
                    {
                        price = 80;
                        disc = 0.05;
                    }
                    else if (pack == "withEquipment")
                    {
                        price = 100;
                        disc = 0.1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    break;
                case "Varna":
                case "Burgas":
                    if (pack == "noBreakfast")
                    {
                        price = 100;
                        disc = 0.07;
                    }
                    else if (pack == "withBreakfast")
                    {
                        price = 130;
                        disc = 0.12;
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
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (days >= 1 && days <= 7)
            {
                endPrice = days * price;
                if (discount == "yes")
                {
                    endPrice -= endPrice * disc;
                }
            }
            else if (days > 7)
            {
                endPrice = (days - 1) * price;
                if (discount == "yes")
                {
                    endPrice -= endPrice * disc;
                }
            }
            if (endPrice > 0)
            {
                Console.WriteLine($"The price is {endPrice:f2}lv! Have a nice time!");
            }
        }
    }
}