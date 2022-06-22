using System;
using System.Linq;

namespace P06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum;
            int rightSum;

            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftSum = 0;
                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                    int nextElPos = sumLeft - 1;
                    if (sumLeft > 0)
                    {
                        leftSum += intArr[nextElPos];
                    }
                }
                rightSum = 0;
                for (int j = i; j < intArr.Length; j++)
                {
                    int nextElPos = j + 1;
                    if (j < intArr.Length - 1)
                    {
                        rightSum += intArr[nextElPos];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
