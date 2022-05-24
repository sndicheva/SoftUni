using System;

namespace _08._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num1 = 0;
            double num2 = 0;
            double currentSum = 0;
            double sum = 0;
            double difference = 0;
            double maxDiff = 0;

            for (int i = 1; i <= n; i++)
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                currentSum = num1 + num2;
                if (i==1)
                {
                    sum = currentSum;
                }
                else
                {
                    difference = Math.Abs(sum - currentSum);
                    sum = currentSum;
                }
                if (difference>maxDiff)
                {
                    maxDiff = difference;
                }
            }
            if (maxDiff==0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
