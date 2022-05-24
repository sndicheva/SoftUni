using System;

namespace Nested_Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // _ _ _ _ _ // 12345

            string currentNum = n.ToString();// "12345"

            //стрингът currentNum има дължина (currentNum.Length) = 5

            //позиция 0: "1" => currentNum[0]
            //позиция 1: "2" => currentNum[1]
            //позиция 2: "3" => currentNum[2]
            //позиция 3: "4" => currentNum[3]
            //позиция 4: "5" => currentNum[4]

            int sum = 0;

            
            for (int i = 0; i < currentNum.Length; i++)
            {
                Console.WriteLine($"the position is {i}: '{currentNum[i]}'");
                sum += currentNum[i];

                Console.WriteLine(currentNum[i]);
                Console.WriteLine(sum);
            }
        }
    }
}
