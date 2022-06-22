using System;
using System.Linq;

namespace P03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] evenArr = new int[lines];
            int[] oddArr = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenArr[i] = num[0];
                    oddArr[i] = num[1];
                }
                else
                {
                    evenArr[i] = num[1];
                    oddArr[i] = num[0];
                }
            }
            Console.WriteLine(String.Join(" ", evenArr));
            Console.WriteLine(String.Join(" ", oddArr));
        }
    }
}
