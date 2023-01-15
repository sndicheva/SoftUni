using System;
using System.Collections.Generic;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command != "Paid")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    int counter = queue.Count;
                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}