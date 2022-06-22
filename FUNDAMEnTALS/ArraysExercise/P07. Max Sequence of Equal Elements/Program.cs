using System;
using System.Linq;

namespace P07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lastNum = int.MinValue;
            int sequenceCounter = 0;
            int maxCounter = 0;
            int sequenceNum = 0;

            foreach (int i in array)
            {
                int currentNum = 0;
                currentNum = i;

                if (currentNum == lastNum)
                {
                    sequenceCounter++;
                }
                else
                {
                    sequenceCounter = 1;
                }

                if (sequenceCounter > maxCounter)
                {
                    maxCounter = sequenceCounter;
                    sequenceNum = currentNum;
                }

                lastNum = currentNum;
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{sequenceNum} ");
            }
        }
    }
}
