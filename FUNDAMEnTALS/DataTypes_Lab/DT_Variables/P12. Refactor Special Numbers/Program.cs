﻿using System;

namespace P12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNum = 0;
            bool isSpecial = false;
            for (int i = 1; i <= input; i++)
            {
                currentNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNum, isSpecial);
                sum = 0;
                i = currentNum;
            }

        }
    }
}
