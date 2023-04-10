using System;
using System.Collections.Generic;
using System.Linq;

namespace StQ_TheFightForGondor_0222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //waves of orcs
            int n = int.Parse(Console.ReadLine());

            Queue<int> platesOfAragorn = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int count = 1;
            for (int waves = 0; waves < n; waves++)
            {
                Stack<int> waveOfOrcs = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
                if (count % 3 == 0)
                {
                    int input = int.Parse(Console.ReadLine());
                    platesOfAragorn.Enqueue(input);
                }

                while (platesOfAragorn.Any() && waveOfOrcs.Any())
                {
                    int plate = platesOfAragorn.Peek();
                    int orc = waveOfOrcs.Peek();
                    if (orc < plate)
                    {   
                        Queue<int> updatedPlatesOfAragorn = new Queue<int>();
                        updatedPlatesOfAragorn.Enqueue(platesOfAragorn.Dequeue() - waveOfOrcs.Pop());
                        for (int i = 0; i < platesOfAragorn.Count; i++)
                        {
                            updatedPlatesOfAragorn.Enqueue(platesOfAragorn.ElementAt(i));
                        }
                        platesOfAragorn = updatedPlatesOfAragorn;
                    }
                    else if (orc == plate)
                    {
                        waveOfOrcs.Pop();
                        platesOfAragorn.Dequeue();
                    }
                    else if (orc > plate)
                    {
                        waveOfOrcs.Push(waveOfOrcs.Pop() -platesOfAragorn.Dequeue());                        
                    }
                }

                if (waveOfOrcs.Any() && !platesOfAragorn.Any()) // if Orcs pawn the Aragorn army
                {
                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                    Console.WriteLine($"Orcs left: {string.Join(", ", waveOfOrcs)}");
                    return;
                }
                count++;
            }
            //Aragorn army win
            Console.WriteLine("The people successfully repulsed the orc's attack.");
            Console.WriteLine($"Plates left: {string.Join(", ", platesOfAragorn)}");
        }
    }
}