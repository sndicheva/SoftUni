﻿using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            string input = ""; //вид действие - spend или save
            double money = 0;

            int daysCount = 0; //брой изминали дни
            int spendCount = 0; //ПОРЕДНИ дни в които харчи

            while (availableMoney < neededMoney)
            {
                input = Console.ReadLine(); //вид действие - spend или save
                money = double.Parse(Console.ReadLine());
                daysCount++;

                if (input == "save")
                {
                    availableMoney += money;
                    spendCount = 0;
                }
                else
                {
                    availableMoney -= money;
                    spendCount++;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                }
            }

            if (availableMoney>=neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
