using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputInt = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            if (n <= 10)
            {
                for (int i = n; i <= 10; i++)
                {
                    Console.WriteLine($"{inputInt} X {i} = {inputInt * i}");
                }
            }
            else
            {
                Console.WriteLine($"{inputInt} X {n} = {inputInt * n}");
            }

        }
    }
}
