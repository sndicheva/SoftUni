using System;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (flowerType == "Roses")
            {
                price = flowerQuantity * 5.00;
                if (flowerQuantity > 80)
                {
                    price = price - price * 0.10;
                }
            }
            else if (flowerType == "Dahlias")
            {
                price = flowerQuantity * 3.80;
                if (flowerQuantity > 90)
                {
                    price = price - price * 0.15;
                }
            }
            else if (flowerType == "Tulips")
            {
                price = flowerQuantity * 2.80;
                if (flowerQuantity > 80)
                {
                    price = price - price * 0.15;
                }
            }
            else if (flowerType == "Narcissus")
            {
                price = flowerQuantity * 3.00;
                if (flowerQuantity < 120)
                {
                    price = price + price * 0.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                price = flowerQuantity * 2.50;
                if (flowerQuantity < 80)
                {
                    price = price + price * 0.20;
                }
            }

            if (budget >= price)
            {
                double remainingPrice = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {remainingPrice:f2} leva left.");
            }
            else if (budget < price)
            {
                double needPrice = Math.Abs(price - budget);
                Console.WriteLine($"Not enough money, you need {needPrice:f2} leva more.");
            }
        }
    }
}
