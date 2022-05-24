using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //"Summer" и "Winter"

            string location = string.Empty;     //"Alaska" и "Morocco"
            string hotelType = string.Empty;    //"Hotel", "Hut" или "Camp"
            double priceTotal = 0;

            if (budget <= 1000)
            {
                hotelType = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        priceTotal = budget * 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        priceTotal = budget * 0.45;
                        break;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                hotelType = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        priceTotal = budget * 0.80;
                        break;
                    case "Winter":
                        location = "Morocco";
                        priceTotal = budget * 0.60;
                        break;
                }
            }
            else
            {
                hotelType = "Hotel";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        break;
                    case "Winter":
                        location = "Morocco";
                        break;
                }
                priceTotal = budget * 0.90;
            }
        Console.WriteLine($"{location} - {hotelType} - {priceTotal:f2}");
        }
    }
}

