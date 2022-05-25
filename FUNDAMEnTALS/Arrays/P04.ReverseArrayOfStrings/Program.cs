using System;

namespace P04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();

            //for (int i = items.Length; i >=0; i--)
            //{
            //   to do..
            //}

            Array.Reverse(items);
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
