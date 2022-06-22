using System;
using System.Linq;


namespace P08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int inputSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = 0;
                    sum = array[i] + array[j];
                    if (sum == inputSum)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                }
            }
        }
    }
}
