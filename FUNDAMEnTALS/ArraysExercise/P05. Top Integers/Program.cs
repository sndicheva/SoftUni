using System;
using System.Linq;

namespace P05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int curEl = arr[i];
                bool curBigestEl = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextEl = arr[j];
                    if (curEl <= nextEl)
                    {
                        curBigestEl = false;
                        break;
                    }
                }
                if (curBigestEl)
                {
                    Console.Write($"{curEl} ");
                }
            }
        }
    }
}
