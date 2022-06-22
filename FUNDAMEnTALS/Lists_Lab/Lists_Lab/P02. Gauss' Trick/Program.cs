using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> gauss = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers = new List<int>();

            for (int i = 0; i < gauss.Count / 2; i++)
            {
                int currentGaussNum = gauss[i] + gauss[gauss.Count - 1 - i];
               
                numbers.Add(currentGaussNum);
            }
            if (gauss.Count % 2 != 0)
            {
                numbers.Add(gauss[gauss.Count / 2 ]);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
