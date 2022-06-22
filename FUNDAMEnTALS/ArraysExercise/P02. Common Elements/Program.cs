using System;

namespace P02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            foreach (string element in secondArray)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    string elementArrOne = firstArray[i];
                    if (element == elementArrOne)
                    {
                        Console.Write($"{elementArrOne} ");
                        break;
                    }
                }
            }
        }
    }
}
