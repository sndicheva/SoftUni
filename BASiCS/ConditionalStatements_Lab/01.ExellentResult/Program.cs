using System;

namespace _01.ExellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");// (?bez else?)da se napravi proverka dali vavedenata ocenka e v diapazona 2-6
            }
           // else
           // {
           //     Console.WriteLine("Try Agin!");
           //     Console.WriteLine("Not Excellent!");
           // }


        }
    }
}
