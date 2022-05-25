﻿using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                hours += 1;
                minutes = Math.Abs(60 - minutes);
                if (hours>23)
                {
                    hours = 0;
                }
                if (minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes}");
                }
                else
                Console.WriteLine($"{hours}:{minutes}");
            }    
            else
            {
                if (minutes < 10)
                {
                    Console.WriteLine($"{hours}:0{minutes}");
                }
                else
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
