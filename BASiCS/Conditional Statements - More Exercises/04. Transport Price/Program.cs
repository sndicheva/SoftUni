using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            // n километра път
            int n = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();
            //double taxiStartPrice = 0.70;
            //double taxiDay = 0.79;
            //double taxiNight = 0.90;
            //double bus = 0.09;
            //double train = 0.06;

            double taxiBillDay = 0.70 + 0.79 * n;
            double taxiBillNight = 0.70 + 0.90 * n;
            double busBill = 0.09 * n;
            double trainBill = 0.06 * n;

            //транспорт:
            //•	Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            //•	Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
            //•	Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км
            if (n < 20)
            {
                if (timeOfTheDay == "day")
                {
                    Console.WriteLine($"{taxiBillDay:f2}");
                }
                else
                {
                    Console.WriteLine($"{taxiBillNight:f2}");
                }
            }
            else if (n >= 20 && n < 100)
            {
                Console.WriteLine($"{busBill:f2}");
            }
            else
            {
                Console.WriteLine($"{trainBill:f2}");
            }


            //Да се отпечата на конзолата най-ниската цена за посочения брой километри, форматирана до втория знак след десетичния разделител.
        }
    }
}
