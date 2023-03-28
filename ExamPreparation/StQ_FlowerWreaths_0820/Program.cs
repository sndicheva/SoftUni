using System;
using System.Collections.Generic;
using System.Linq;

namespace StQ_FlowerWreaths_0820
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int leftoverFlowers = 0;
            const int wreath = 15;
            int wreathCount = 0;

            int sum = 0;

            while (roses.Count > 0 && lilies.Count > 0)
            {
                sum = roses.Peek() + lilies.Peek();

                if (sum == wreath)
                {
                    wreathCount++;
                    RemoveFlowers(roses, lilies);
                }
                else if (sum > wreath)
                {
                    int currentLilies = lilies.Peek();
                    while (sum > wreath)
                    {
                        currentLilies -= 2;
                        sum = roses.Peek() + currentLilies;
                    }
                    if (sum == wreath)
                    {
                        wreathCount++;
                        RemoveFlowers(roses, lilies);
                    }
                    else
                    {
                        leftoverFlowers += sum;
                        RemoveFlowers(roses, lilies);
                    }
                }
                else
                {
                    //LeftOverFlowers()
                    leftoverFlowers += roses.Dequeue() + lilies.Pop();
                }
                sum = 0;
            }
            int left = leftoverFlowers / 15;
            wreathCount += left;

            if (wreathCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathCount} wreaths more!");
            }
        }

        private static void RemoveFlowers(Queue<int> roses, Stack<int> lilies)
        {
            roses.Dequeue();
            lilies.Pop();
        }
    }
}
