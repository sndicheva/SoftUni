﻿using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum < num)
            {
                sum += int.Parse(Console.ReadLine());
                //int currentNum= int.Parse(Console.ReadLine());
                //sum += currentNum;
            }

            //while (true)
            //{
            //    if (sum>=num)
            //    {
            //        break;
            //    }
            //    sum += int.Parse(Console.ReadLine());
            //}
            Console.WriteLine(sum);
        }
    }
}
