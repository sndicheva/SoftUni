using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeToReturn = 100*double.Parse(Console.ReadLine());
          
            int count = 0;

            // 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01

            //primer => 5.23=> 2*2.00 + 1.00+0.20+0.02+0.01

            //5.23- 2=> 3.23 -> count =1
            //3.23 -2=> 1.23-> count =1+1
            //1.23-1 => 0.23 -> count =1+1+1
            //0.23 = 0.20 => 0.03 -> count =1+1+1+1
            //0.03 - 0.02 => 0.01 -> count =1+1+1+1+1
            //0.01-0.01 =>0.00  -> count =1+1+1+1+1+1 = 6
            while (changeToReturn > 0)
            {
                if (changeToReturn >= 200)
                {
                    changeToReturn -= 200;
                    count++;
                }
                else if (changeToReturn >= 100)
                {
                    changeToReturn -= 100;
                    count++;
                }
                else if (changeToReturn >= 50)
                {
                    changeToReturn -= 50;
                    count++;
                }
                else if (changeToReturn >= 20)
                {
                    changeToReturn -= 20;
                    count++;
                }
                else if (changeToReturn >= 10)
                {
                    changeToReturn -= 10;
                    count++;
                }
                else if (changeToReturn >= 5)
                {
                    changeToReturn -= 5;
                    count++;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2;
                    count++;
                }
                else if (changeToReturn >= 1)
                {
                    changeToReturn -= 1;
                    count++;
                }
                else
                {
                    changeToReturn = 0; // въведено странно число от конзолата?! със стотни например
                }
            }
            Console.WriteLine(count);

        }
    }
}
