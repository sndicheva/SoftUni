using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemum = int.Parse(Console.ReadLine());
            int rosses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); // Spring, Summer, Аutumn, Winter
            string holiday = Console.ReadLine(); // Y/N

            double holidayIncr = 0.15;
            //int arrangePrice = 2;
            double priceFLowers = 0;
            double priceBouquet = 0;
            int flowersCount = chrysanthemum + rosses + tulips;

            if (holiday == "Y")
            {
                switch (season)
                {
                    case "Spring":
                    case "Summer":
                        priceFLowers = chrysanthemum * 2.00 + rosses * 4.10 + tulips * 2.50; // 40.40
                        priceFLowers += priceFLowers * holidayIncr; // 46.46
                        if (tulips > 7)
                        {
                            priceBouquet = priceFLowers - priceFLowers * 0.05;
                        }
                        else
                        {
                            priceBouquet = priceFLowers;
                        }
                        break;
                    case "Autumn":
                        priceFLowers = chrysanthemum * 3.75 + rosses * 4.50 + tulips * 4.15;
                        priceFLowers += priceFLowers * holidayIncr;
                        priceBouquet = priceFLowers;
                        break;
                    case "Winter":
                        priceFLowers = chrysanthemum * 3.75 + rosses * 4.50 + tulips * 4.15;
                        priceFLowers += priceFLowers * holidayIncr;
                        if (rosses >= 10)
                        {
                            priceBouquet = priceFLowers - priceFLowers * 0.10;
                        }
                        else
                        {
                            priceBouquet = priceFLowers;
                        }
                        break;
                }
            }
            else
            {
                switch (season)
                {
                    case "Spring":
                    case "Summer":
                        priceFLowers = chrysanthemum * 2.00 + rosses * 4.10 + tulips * 2.50;
                        if (tulips > 7)
                        {
                            priceBouquet = priceFLowers - priceFLowers * 0.05;
                        }
                        else
                        {
                            priceBouquet = priceFLowers;
                        }
                        break;
                    case "Autumn":
                        priceFLowers = chrysanthemum * 3.75 + rosses * 4.50 + tulips * 4.15;
                        priceBouquet = priceFLowers;
                        break;
                    case "Winter":
                        priceFLowers = chrysanthemum * 3.75 + rosses * 4.50 + tulips * 4.15;
                        if (rosses >= 10)
                        {
                            priceBouquet = priceFLowers - priceFLowers * 0.10;
                        }
                        else
                        {
                            priceBouquet = priceFLowers;
                        }
                        break;
                }
            }
            if (flowersCount > 20)
            {
                priceBouquet = priceBouquet - priceBouquet * 0.20;
            }
            priceBouquet += 2;
            Console.WriteLine($"{priceBouquet:f2}");
        }
    }
}
