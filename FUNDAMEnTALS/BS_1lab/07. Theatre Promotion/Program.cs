﻿using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;
            if (age >= 0 && age <= 18)
            {
                switch (typeOfTheDay)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 5;
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (typeOfTheDay)
                {
                    case "Weekday":
                        price = 18;
                        break;
                    case "Weekend":
                        price = 20;
                        break;
                    case "Holiday":
                        price = 12;
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (typeOfTheDay)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 10;
                        break;
                }
            }
            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
