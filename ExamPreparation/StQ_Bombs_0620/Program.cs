using System;
using System.Collections.Generic;
using System.Linq;

namespace StQ_Bombs_0620
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<int, string> materials = new Dictionary<int, string>()
            {
                {40, "Datura Bombs"},
                {60, "Cherry Bombs"},
                {120, "Smoke Decoy Bombs"}
            };

            Dictionary<string, int> bombPouch = new Dictionary<string, int>()
            {
                {"Datura Bombs", 0},
                {"Cherry Bombs", 0},
                {"Smoke Decoy Bombs", 0}
            };

            while (true)
            {
                if (bombEffects.Count == 0 || bombCasings.Count == 0 || PouchesAreFull(bombPouch))
                {
                    break;
                }

                int currentBombEffect = bombEffects.Peek();
                int currentBombCasing = bombCasings.Peek();
                int currentSum = currentBombCasing + currentBombEffect;
                string currentBomb = string.Empty;

                if (materials.ContainsKey(currentSum))
                {
                    currentBomb = materials[currentSum];
                    bombPouch[currentBomb]++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    bombCasings.Push(bombCasings.Pop() - 5);
                }
            }

            PrintResult(bombEffects, bombCasings, bombPouch);
        }

        private static void PrintResult(Queue<int> bombEffects, Stack<int> bombCasings, Dictionary<string, int> bombPouch)
        {
            if (PouchesAreFull(bombPouch))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
                Console.WriteLine($"Bomb Effects: {String.Join(", ", bombEffects)}");

            if (bombCasings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
                Console.WriteLine($"Bomb Casings: {String.Join(", ", bombCasings)}");

            foreach (var pouch in bombPouch.OrderBy(p => p.Key))
            {
                Console.WriteLine($"{pouch.Key}: {pouch.Value}");
            }
        }

        private static bool PouchesAreFull(Dictionary<string, int> bombPouch)
        {
            foreach (var pouch in bombPouch)
            {
                if (pouch.Value < 3)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
