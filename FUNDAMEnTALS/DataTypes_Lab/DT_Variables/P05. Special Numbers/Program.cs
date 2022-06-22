﻿using System;

namespace P05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputInt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputInt; i++)
            {
                int sum = 0;
                int currentNum = i;

                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
