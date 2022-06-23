using System;
using System.Collections.Generic;

namespace P03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numbersOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string name = command[0];
                bool isGuestInTheList = guests.Contains(name);

                //The guest is going!
                if (command.Length < 4)
                {
                    if (isGuestInTheList)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                //The guest is not going!
                else 
                {
                    if (isGuestInTheList)
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach (string name in guests)
            {
                Console.WriteLine(name);
            }
        }
    }
}
