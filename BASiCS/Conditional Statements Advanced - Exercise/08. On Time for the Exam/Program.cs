using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {                         // КЪДЕ МИ Е ГРЕШКАТА
            // от конзолата часа и минути на пристигане
            //обръщаме часа и минути в минути
            int examHour = int.Parse(Console.ReadLine()); // 10
            int examMin = int.Parse(Console.ReadLine()); // 00

            int arriavalHour = int.Parse(Console.ReadLine()); // 10
            int arrivalMin = int.Parse(Console.ReadLine()); // 45

            examMin = examMin + examHour * 60; // = 600
            arrivalMin = arrivalMin + arriavalHour * 60; // =645

            //late =>  examMin>arrivalMin
            //on time =>   examMin==arrivalMin || examMin - arrivalMin <= 30
            //ili early =>  examMin - arrivalMin > 30

            int difference = 0;
            int diffHour = 0;
            int diffMin = 0;

            //проверяваме дали студентът закъснява
            if (examMin < arrivalMin)
            {
                //Late
                Console.WriteLine("Late");
                //намираме разликата във времето на пристигане 
                difference = arrivalMin - examMin;
                //преобразуваме разликата в минути и часове
                diffHour = difference / 60;
                diffMin = difference % 60;

                //проверяваме дали закъснява с повече от 1 час
                if (diffHour >= 1)
                {
                    if (diffMin < 10) // дали минутите са по-малко от 10 (отпечатваме резултата с водеща 0)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours after the start");
                    }
                    Console.WriteLine($"{diffHour}:{diffMin} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes after the start");
                }
            }
            else if (examMin - arrivalMin <= 30) 
            {
                //On time
                Console.WriteLine("On time");

                if (examMin != arrivalMin)
                {
                    difference = examMin - arrivalMin;
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else // dali studentat e podranil
            {
                //Early
                Console.WriteLine("Early");
                difference =  examMin - arrivalMin;
                //преобразуваме разликата в минути и часове
                diffHour = difference / 60;
                diffMin = difference % 60;

                //проверяваме дали podranqwa с повече от 1 час
                if (diffHour >= 1)
                {
                    if (diffMin < 10) // дали минутите са по-малко от 10 (отпечатваме резултата с водеща 0)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours before the start");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes before the start");
                }
            }

        }
    }
}
