using System;

namespace P07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{nameOne}{delimiter}{nameTwo}");
        }
    }
}
