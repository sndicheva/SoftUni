using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int time = first + second + third; // в секунди 
            //150 sek => 2 min i 30 sec
            //1 min = 60 sek

            int min = time / 60; //150 / 60 = 2
            int sec = time % 60; // 150 % 60 = 30 (150:60=2(30))

            // ako sek < 10 +> $"{min}:0{sec}"
            if (sec < 10)
            {
               Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
            
        }
    }
}
