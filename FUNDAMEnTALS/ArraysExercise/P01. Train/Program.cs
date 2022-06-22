using System;

namespace P01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsNum = int.Parse(Console.ReadLine());

            int[] wagons = new int[wagonsNum];
            int sum = 0;

            for (int index = 0; index < wagons.Length; index++)
            {
                wagons[index] = int.Parse(Console.ReadLine());
                sum += wagons[index];
            }
            foreach (int wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
