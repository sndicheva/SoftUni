using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            examMinutes = examHour * 60 + examMinutes;
            arrivalMinutes = arrivalHour * 60 + arrivalMinutes;

            int difference = Math.Abs(arrivalMinutes - examMinutes);
            int diffHour = difference / 60;
            int diffMinutes = difference % 60;

            string diffMinutesConsole = diffMinutes < 10 ? "0" + diffMinutes.ToString() : diffMinutes.ToString();
            string time = string.Empty;

            if (examMinutes < arrivalMinutes)
            {
                Console.WriteLine("Late");
                time = "after";
            }
            else if (examMinutes - arrivalMinutes <= 30)
            {
                Console.WriteLine("On time");
                time = "before";
            }
            else
            {
                Console.WriteLine("Early");
                time = "before";
            }

            if (diffHour >= 1)
            {
                Console.WriteLine($"{diffHour}:{diffMinutesConsole} hours {time} the start");
            }
            else if (diffMinutes >= 1)
            {
                Console.WriteLine($"{diffMinutes} minutes {time} the start");
            }
        }
    }
}