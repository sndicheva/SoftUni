using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine()); //23
            int m = int.Parse(Console.ReadLine()); //50

            //24:05

            int timeInMin = m + h * 60; // 53+ 23*60 =1380 min
            timeInMin = timeInMin + 15; // 1380+15=1395 min

            h = timeInMin / 60; // 1395 / 60 = 1 (?)<ostatak-min 24 chasa
            m = timeInMin % 60; // 1395 % 60 = ?

            //24:05>0:05
            if (h >= 24) //* h ==24
            {
                h = h - 24; // 24-24=0 //* h = 0;
            }
            if (m < 10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
            else
            {
                Console.WriteLine($"{h}:{m}");
            }



        }
    }
}
