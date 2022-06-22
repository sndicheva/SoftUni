using System;

namespace P06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbolOne = char.Parse(Console.ReadLine());
            char symbolTwo = char.Parse(Console.ReadLine());
            char symbolTree = char.Parse(Console.ReadLine());

            Console.WriteLine($"{symbolTree} {symbolTwo} {symbolOne}");
        }
    }
}
