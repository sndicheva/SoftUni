using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine()); // _ _ _ _ _ _
            int secondNum = int.Parse(Console.ReadLine()); // _ _ _ _ _ _

            int oddSum;
            int evenSum;
            string currentNum;

            for (int i = firstNum; i <= secondNum; i++)
            {
                oddSum = 0;
                evenSum = 0;

                currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j%2==0)
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum += currentNum[j];
                    }
                }
                if (oddSum==evenSum)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
