using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int comparisonNum = int.MinValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);

                if (num > comparisonNum)
                {
                    comparisonNum = num;
                }
                input = Console.ReadLine();                
            }
            Console.WriteLine(comparisonNum);
        }
    }
}
