using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCarsToPass = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            int countPassedCars = 0;

            while (command != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);

                    command = Console.ReadLine();
                }
                else
                {
                    for (int i = 0; i < numbersOfCarsToPass; i++)
                    {
                        if (!cars.Any())
                        {
                            break;
                        }

                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        
                        countPassedCars++;
                    }

                    command = Console.ReadLine();
                }
            }

            Console.WriteLine($"{countPassedCars} cars passed the crossroads.");
        }
    }
}
