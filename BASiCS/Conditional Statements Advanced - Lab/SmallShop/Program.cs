﻿using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 read input
            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            // 2 create a variable named price = 0
            double price = 0;
            //град   coffee water   beer sweets  peanuts
            //Sofia   0.50    0.80    1.20    1.45    1.60
            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            //Varna   0.45    0.70    1.10    1.35    1.55


            // 3 create a series of conditions for the city
            switch (city)
            {
                case "Sofia":
                    if (item == "coffee")
                    {
                        price = 0.50;
                    }
                    else if (item == "water")
                    {
                        price = 0.80;
                    }
                    else if (item == "beer")
                    {
                        price = 1.20;
                    }
                    else if (item == "sweets")
                    {
                        price = 1.45;
                    }
                    else if (item == "peanuts")
                    {
                        price = 1.60;
                    }
                    break;
                case "Plovdiv":
                    if (item == "coffee")
                    {
                        price = 0.40;
                    }
                    else if (item == "water")
                    {
                        price = 0.70;
                    }
                    else if (item == "beer")
                    {
                        price = 1.15;
                    }
                    else if (item == "sweets")
                    {
                        price = 1.30;
                    }
                    else if (item == "peanuts")
                    {
                        price = 1.50;
                    }
                    break;
                case "Varna":
                    if (item == "coffee")
                    {
                        price = 0.45;
                    }
                    else if (item == "water")
                    {
                        price = 0.70;
                    }
                    else if (item == "beer")
                    {
                        price = 1.10;
                    }
                    else if (item == "sweets")
                    {
                        price = 1.35;
                    }
                    else if (item == "peanuts")
                    {
                        price = 1.55;
                    }
                    break;
            }
            // 3.1 another series for the produst
            // 3.2 set the price for ea product according to the product and the city

            // 4 calculate the total price - quantity * price
            double totalPrice = quantity * price;

            // 5 print the result
            Console.WriteLine(totalPrice);

        }
    }
}
