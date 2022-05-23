using System;

namespace text2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //string text = "SoftUni";

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
