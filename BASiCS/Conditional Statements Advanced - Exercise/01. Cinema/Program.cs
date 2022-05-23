using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем от конзолата
            string ticketType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());



            //изчисляваме броя на местата в залата
            double income = row * col;
            //проверяваме типа на билетите + изчисляваме приходите от билетите
//            •	Premiere – премиерна прожекция, на цена 12.00 лева.
//•	Normal – стандартна прожекция, на цена 7.50 лева.
//•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

                if (ticketType=="Premiere")
            {
                income = income * 12.00;
            }
            else if (ticketType=="Normal")
            {
                income = income * 7.50;
            }
            else
            {
                income = income * 5.00;
            }

            //извеждаме резултата
            //Console.WriteLine("{2:f2} leva", row, col, income); - 2:f2 -> 2 e pozicijata na promenlivata (broeneto zapochva ot 0, 1, 2...)
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
