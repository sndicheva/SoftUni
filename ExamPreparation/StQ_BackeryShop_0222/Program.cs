using System;
using System.Collections.Generic;
using System.Linq;

namespace StQ_BackeryShop_0222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));

            Dictionary<double, string> receipes = new Dictionary<double, string>()// product, water needing
            {
                { 50, "Croissant" },
                { 40, "Muffin" },
                { 30, "Baguette" },
                { 20, "Bagel" }
            };

            Dictionary<string, int> backedProducts = new Dictionary<string, int>() // maded products, count
            {
                {"Croissant", 0 },
                {"Muffin", 0 },
                {"Baguette", 0 },
                {"Bagel", 0 }
            };

            while (water.Count > 0 && flour.Count > 0)
            {
                double firstWater = water.Peek();
                double lastFlour = flour.Peek();

                double waterPercentage = (firstWater / (firstWater + lastFlour)) * 100;
                if (receipes.ContainsKey(waterPercentage))
                {
                    string product = receipes[waterPercentage];
                    backedProducts[product]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else
                {
                    backedProducts["Croissant"]++;
                    flour.Push(flour.Pop() - water.Dequeue());
                }
            }

            foreach (var (product, quantity) in backedProducts.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                if (quantity > 0)
                {
                    Console.WriteLine($"{product}: {quantity}");
                }
            }
            if (water.Count > 0)
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }
            else
            {
                Console.WriteLine("Water left: None");
            }
            if (flour.Count > 0)
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}
