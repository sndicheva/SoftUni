using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> output = new List<int>();
            int biggerCount = Math.Max(firstInput.Count, secondInput.Count);

            for (int i = 0; i < biggerCount; i++)
            {
                if (firstInput.Count > i)
                {
                    output.Add(firstInput[i]);                    
                }
                if (secondInput.Count > i)
                {                    
                    output.Add(secondInput[i]);
                }
            }

            Console.WriteLine(string.Join(" ", output));

        }
    }
}
