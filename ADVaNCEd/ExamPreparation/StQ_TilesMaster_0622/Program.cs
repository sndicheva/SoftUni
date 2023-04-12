using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace StQ_TilesMaster_0622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // white tiles last
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            // grey tiles first
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<int, string> kitchenTable = new Dictionary<int, string>()
            {
                { 40, "Sink" },
                { 50, "Oven" },
                { 60, "Countertop"},
                { 70, "Wall" }
            };
            Dictionary<string, int> madedLocations = new Dictionary<string, int>()
            {
                { "Sink", 0 },
                { "Countertop" , 0},
                { "Oven" , 0 },
                { "Wall" , 0 },
                { "Floor", 0 }
            };
            // if white=grey => check in the table where the newformed tile can be placed, if is in the table then remove both
            //                                                                             IF IS NOT => Floor

            int currentWhite = 0;
            int currentGrey = 0;
            while (whiteTiles.Any() && greyTiles.Any())
            {
                currentWhite = whiteTiles.Pop();
                currentGrey = greyTiles.Dequeue();
                if (currentWhite == currentGrey)
                {
                    int sum = 2 * currentWhite;
                    if (kitchenTable.ContainsKey(sum))
                    {
                        madedLocations[kitchenTable[sum]]++;
                    }
                    else
                    {
                        madedLocations["Floor"]++;
                    }
                }
            // if white!= grey => gray go at back, white/2  return in the sequence
                else if (currentWhite != currentGrey)
                {
                    greyTiles.Enqueue(currentGrey);
                    whiteTiles.Push(currentWhite/2);
                }
            }
            if (whiteTiles.Any())
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }
            else { Console.WriteLine("White tiles left: none"); }
            if (greyTiles.Any())
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }
            else { Console.WriteLine("Grey tiles left: none"); }

            foreach (var location in madedLocations.Where(x=>x.Value > 0).OrderByDescending(x=>x.Value).ThenBy(x=>x.Key)) 
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }
    }
}
