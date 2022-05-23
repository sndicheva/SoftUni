using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 входа - дължина, ширина, височина + процент заетост
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double percent = double.Parse(Console.ReadLine());

            //изчисляваме - обем на аквариума
            double volume = lenght * width * height;

            //изчисляваме - обем в литри
            double volumeInLiters = volume / 1000;

            //изчисляваме - каква част от аквариума е заета
            double busy = percent / 100;

            //изчисляваме - колко вода трябва да се налее
            double liters = volumeInLiters * (1 - busy);

            //отпечатване на резултата на конзолата
            Console.WriteLine(liters);

        }
    }
}
