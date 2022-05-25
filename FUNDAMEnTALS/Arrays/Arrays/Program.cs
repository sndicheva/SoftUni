using System;
using System.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbersArray = new int[6];//new-заделя памет за масива
            ////int number1 = 6;
            ////int number2 = 5;
            ////....
            //numbersArray[3] = 88;
            //Console.WriteLine(numbersArray.Length);
            //Console.WriteLine(numbersArray[0]);
            //Console.WriteLine(numbersArray[3]);
            ////Console.WriteLine(numbersArray[6]); // IndexOutOfRangeException !!!

            //int indexToSearch = 7;
            //bool inArray = indexToSearch >= 0 && indexToSearch <= numbersArray.Length - 1;
            //Console.WriteLine(numbersArray[indexToSearch]);




            //string[] stringsArray = new string[3];

            //float[] floatArray = new float[8];
            //------------------------------------------------------------------------------------------------

            //string[] rawItems = Console.ReadLine().Split();
            //int[] items = new int[rawItems.Length];

            //for (int i = 0; i < rawItems.Length; i++)
            //{
            //    items[i] = int.Parse(rawItems[i]);
            //}
            //Console.WriteLine(items);<-----не работи!!!
            //--------------------------------------------------
            int[] items = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"index: {i} value: {items[i]}");
            }
        }
    }
}
