﻿using System;
using System.Collections.Generic;

namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var s in input)
            {
                stack.Push(s);
            }
            while (stack.Count != 0)
            {
                Console.Write($"{stack.Pop()}");
            }
        }
    }
}