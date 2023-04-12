using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace StQ_BaristaContest_0822
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //coffee Queue
            Queue<int> coffee = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            //milk Stack
            Stack<int> milk = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<int, string> baristaTable = new Dictionary<int, string>()
            {
                {50,"Cortado"},
                {75,"Espresso"},
                {100,"Capuccino"},
                {150,"Americano"},
                {200,"Latte"}
            };
            Dictionary<string, int> madedDrinks = new Dictionary<string, int>()
            {
                {"Cortado", 0},
                {"Espresso", 0},
                {"Capuccino", 0},
                {"Americano", 0},
                {"Latte", 0}
            };
            // if the sum is in the table then remove both
            int currentCoffee = 0;
            int currentMilk = 0;
            while (coffee.Any() && milk.Any())
            {
                currentCoffee = coffee.Dequeue();
                currentMilk = milk.Pop();
                int sum = currentMilk + currentCoffee;
                if (baristaTable.ContainsKey(sum))
                {
                    madedDrinks[baristaTable[sum]]++;
                }
                // if the sum is NOT in the table => remove the coffee; milk - 5 and push back
                else
                {
                    milk.Push(currentMilk - 5);
                }
            }
            if (coffee.Any() || milk.Any())
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }
            else if (!coffee.Any() && !milk.Any())
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            if (coffee.Any())
            {
                Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");
            }
            else
            {
                Console.WriteLine("Coffee left: none");
            }
            if (milk.Any())
            {
                Console.WriteLine($"Milk left: {string.Join(", ", milk)}");
            }
            else
            {
                Console.WriteLine("Milk left: none");
            }
            foreach (var drink in madedDrinks.Where(x => x.Value > 0).OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{drink.Key}: {drink.Value}");
            }
        }
    }
}
