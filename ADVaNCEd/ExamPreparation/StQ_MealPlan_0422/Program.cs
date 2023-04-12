using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace StQ_MealPlan_0422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meal = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Stack<int> calories = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<string, int> mealTable = new Dictionary<string, int>()
            {
                { "salad", 350 },
                { "soup", 490 },
                { "pasta", 680 },
                { "steak", 790 }
            };
            int mealCount = meal.Count;

            while (calories.Any() && meal.Any())
            {
                int currentCal = calories.Pop();
                string currentMeal = meal.Dequeue();
                int caloriesLeft = currentCal - mealTable[currentMeal];

                if (caloriesLeft > 0)
                {
                    calories.Push(currentCal - mealTable[currentMeal]);
                }
                else
                {
                    if (calories.Any())
                    {
                        calories.Push(calories.Pop() + caloriesLeft);
                    }
                }
            }
            int mealsEaten = mealCount - meal.Count;
            if (!meal.Any())
            {
                Console.WriteLine($"John had {mealsEaten} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealsEaten} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meal)}.");
            }
        }
    }
}