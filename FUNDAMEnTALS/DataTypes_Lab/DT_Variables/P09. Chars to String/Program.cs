using System;

namespace P09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());
            char charTree = char.Parse(Console.ReadLine());

            Console.WriteLine($"{charOne}{charTwo}{charTree}");
        }
    }
}
