using System;

namespace _08._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());

            if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
            {
                if (fuelQuantity >= 25)
                {
                    switch (fuelType)
                    {
                        case "Diesel":
                            Console.WriteLine("You have enough diesel.");
                            break;
                        case "Gasoline":
                            Console.WriteLine("You have enough gasoline.");
                            break;
                        case "Gas":
                            Console.WriteLine("You have enough gas.");
                            break;
                    }
                }
                else
                {
                    switch (fuelType)
                    {
                        case "Diesel":
                            Console.WriteLine("Fill your tank with diesel!");
                            break;
                        case "Gasoline":
                            Console.WriteLine("Fill your tank with gasoline!");
                            break;
                        case "Gas":
                            Console.WriteLine("Fill your tank with gas!");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
