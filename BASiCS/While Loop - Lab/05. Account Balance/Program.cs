using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//"300"

            double account = 0;

            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input); // 300.0

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                    //input = Console.ReadLine();//!!! гърми в Judge !!!
                    //continue;//!!!гърми в Judge !!!
                }

                account += amount;
                Console.WriteLine($"Increase: {amount:f2}");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {account:f2}");
        }
    }
}
