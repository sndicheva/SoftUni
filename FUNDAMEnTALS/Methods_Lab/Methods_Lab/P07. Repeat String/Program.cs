using System;

namespace P07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeating = int.Parse(Console.ReadLine());
            string output = GetResultOfRepeating(input, repeating);

            Console.WriteLine(output);
        }

        private static string GetResultOfRepeating(string input, int repeating)
        {
            string result = " ";
            for (int i = 0; i < repeating; i++)
            {
                Console.Write(input);
            }

            return result;
        }
    }
}
