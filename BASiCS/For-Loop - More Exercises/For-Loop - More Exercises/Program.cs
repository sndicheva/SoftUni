using System;

namespace For_Loop___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "stop")
            {
                Console.WriteLine("invalid input");
                input = Console.ReadLine();
            }
        }
    }
}
