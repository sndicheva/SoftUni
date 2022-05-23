using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (num <=100) 
            {
                // znaem, che num <= 100
                bonus = 5;
            }
            else if (num > 1000) 
            {
                // znaem, che num e > 1000
                bonus = num * (10 / 100.0); // 0.1
            }
            else
            {
                // znaem, che num e mejdu 100 i 1000
                bonus = num * 0.2;
            }

            // 15 % 2 => 1 (7(0)); 12 % 2 => 0 (6(0))
            if (num % 2 == 0)
            {
                //chetno
                bonus = bonus + 1;
                //bonus += 1;
            }

            //142, 14. 7865484 delim na 10
            //// 142/10=14; 142%10=>2
            ///> 14(2) , 1(4), 786548(4)

            if (num % 10== 5)
            {
                bonus += 2; //bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
           


        }
    }
}
