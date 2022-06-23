using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace P04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            //product = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"{1+i}.{products[i]}");
            //}
            int counter = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }
        }
    }
}
