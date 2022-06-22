using System;

namespace P05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintBills(product, quantity);
        }

        static void PrintBills(string product, int quantity)
        {
            decimal coffee = 1.50m;
            decimal water = 1.00m;
            decimal coke = 1.40m;
            decimal snacks = 2.00m;

            switch (product)
            {
                case "coffee":
                    Console.WriteLine(coffee * quantity);
                    break;
                case "water":
                    Console.WriteLine(water * quantity);
                    break;
                case "coke":
                    Console.WriteLine(coke * quantity);
                    break;
                case "snacks":
                    Console.WriteLine(snacks * quantity);
                    break;
            }
        }
    }
}
