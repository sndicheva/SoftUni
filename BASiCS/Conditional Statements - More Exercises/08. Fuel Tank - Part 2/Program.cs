using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            //double fuelTotalPrice = 0.0;
            double fuelPrice = 0.0;

            if (clubCard == "Yes")
            {
                switch (fuelType)
                {
                    case "Diesel":
                        fuelPrice = (2.33-0.12) * fuelQuantity;
                        break;
                    case "Gas":
                        fuelPrice = (0.93 - 0.08) * fuelQuantity;
                        break;
                    default:
                        fuelPrice = (2.22 - 0.18) * fuelQuantity;
                        break;
                }
            }
            else
            {
                switch (fuelType)
                {
                    case "Diesel":
                        fuelPrice = 2.33 * fuelQuantity;
                        break;
                    case "Gas":
                        fuelPrice = 0.93 * fuelQuantity;
                        break;
                    default:
                        fuelPrice = 2.22 * fuelQuantity;
                        break;
                }
            }
            if (fuelQuantity >= 20 && fuelQuantity <= 25)
            {
                fuelPrice -= fuelPrice * 0.08;
            }
            else if (fuelQuantity > 25)
            {
                fuelPrice -= fuelPrice * 0.10;
            }
            Console.WriteLine($"{fuelPrice:f2} lv.");

        }
    }
}
