using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0.0;
            string destination = "";
            string tripType = "";

            //•	При 100лв.или по-малко – някъде в Bulgaria
            //o   Лято – 30 % от бюджета Camp
            //o   Зима – 70 % от бюджета  Hotel

            //•	При 1000лв.или по малко – някъде на Balkans
            //o   Лято – 40 % от бюджета  Camp
            //o   Зима – 80 % от бюджета  Hotel
            switch (season)
            {
                case "summer":
                    tripType = "Camp";
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";                        
                        price = budget * 0.30;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        destination = "Balkans";
                        price = budget * 0.40;
                    }
                    else
                    {    tripType = "Hotel";
                    destination = "Europe";
                    price = budget * 0.90;}
                    break;
                case "winter":
                    tripType = "Hotel";
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        price = budget * 0.70;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        destination = "Balkans";
                        price = budget * 0.80;
                    }
                    else
                    {
                        tripType = "Hotel";
                        destination = "Europe";
                        price = budget * 0.90;
                    }
                    break;
                default:                    
                    break;
            }

            //•	При повече от 1000лв. – някъде из Europe  - Hotel
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{tripType} - {price:f2}");
        }
    }
}
