using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kidsQueue = new Queue<string>(
                Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                );
            int numberOfTosses = int.Parse(Console.ReadLine());

            int tosses = 1;
            while (kidsQueue.Count > 1)
            {
                while (tosses < numberOfTosses)
                {
                    string kid = kidsQueue.Dequeue();
                    tosses++;
                    kidsQueue.Enqueue(kid);
                }

                Console.WriteLine($"Removed {kidsQueue.Dequeue()}");
                tosses = 1;
            }

            Console.WriteLine($"Last is {kidsQueue.Dequeue()}");
        }
    }
}
