using System;

namespace P12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool isSpecial = false;
            for (int ch = 1; ch <= count; ch++)
            {
                number = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecial);
                sum = 0;
                ch = number;
            }

        }
    }
}
