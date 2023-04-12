using System;
using System.Collections.Generic;
using System.Linq;

namespace StQ_EnergyDrinks_1022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //caffeine
            Stack<int> caffeine = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            //energyDrinks
            Queue<int> energyDrinks = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            //maxcaffeine == 300
            int dailyCaffeine = 300;
            int totalCaffeine = 0;

            int currentCaffeine = 0;
            int currentEnergyDrink = 0;
            while (caffeine.Any() && energyDrinks.Any())
            {
                currentCaffeine = caffeine.Pop();
                currentEnergyDrink = energyDrinks.Dequeue();

                int sum = currentCaffeine * currentEnergyDrink;

                if (totalCaffeine + sum <= dailyCaffeine)
                {
                    totalCaffeine += sum;
                }
                else if (totalCaffeine + sum > dailyCaffeine)
                {
                    energyDrinks.Enqueue(currentEnergyDrink);
                    totalCaffeine -= 30;
                    if (totalCaffeine < 0)
                    {
                        totalCaffeine = 0;
                    }
                }
            }
            if (energyDrinks.Any())
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }
            Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");
        }
    }
}
