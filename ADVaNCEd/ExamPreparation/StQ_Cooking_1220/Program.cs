using System;
using System.Collections.Generic;
using System.Linq;

namespace StQ_Cooking_1220
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<int, string> receipes = new Dictionary<int, string>()
            {
                { 25, "Bread"},
                { 50, "Cake"},
                { 75, "Pastry"},
                { 100, "Fruit Pie"}
            };
            Dictionary<string, int> cooked = new Dictionary<string, int>()
            {
                { "Bread", 0},
                { "Cake", 0},
                { "Pastry", 0},
                { "Fruit Pie", 0}
            };

            while (ingredients.Any() && liquids.Any())
            {
                int cooking = ingredients.Peek() + liquids.Peek();
                if (receipes.ContainsKey(cooking))
                {
                    cooked[receipes[cooking]]++;
                    ingredients.Pop();
                    liquids.Dequeue();
                }
                else
                {
                    ingredients.Push(ingredients.Pop() + 3);
                    liquids.Dequeue();
                }
            }

            if (!cooked.ContainsValue(0))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else { Console.WriteLine("Liquids left: none"); }

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else { Console.WriteLine("Ingredients left: none"); }

            foreach (var food in cooked.OrderBy(f=>f.Key))
            {
                Console.WriteLine($"{food.Key}: {food.Value}");
            }

        }
    }
}
