using System;

namespace _06._Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
                //<= 10 "slow"
            //bool isSlow = speed <= 10;
                //>10&<50 "average"
            //bool isAvMin = speed > 10;
            //bool isAvMax = speed < 50;
                //>50&<150 "fast"
            //bool isFastMin = speed > 50;
            //bool isFastMax = speed < 150;
                //>150&<1000 "ultra fast"
            //bool isUFastMin = speed > 150;
            //bool isUFMax = speed < 1000;
                //>=1000 "extremely fast"
            //bool isExtFast = speed >= 1000;

            if (speed <= 10)                            //(isSlow)
            {
                Console.WriteLine("slow");
            }
            else if ((speed > 10) & (speed <= 50))       //(isAvMin & isAvMax)
            {
                Console.WriteLine("average");
            }
            else if ((speed > 50) & (speed <= 150))      //(isFastMin & isFastMax)
            {
                Console.WriteLine("fast");
            }
            else if ((speed > 150) & (speed <= 1000))   //(isUFastMin & isUFMax)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed >= 1000)                    //(isExtFast)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
