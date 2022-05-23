using System;

namespace JivotNaPromenliva
{
    class Program
    {
        static void Main(string[] args)
        {
            //diapazon na izpolzvane/dostapvane
            //double salary; //*1 decalration
            double salary = 0; // initialization
            string currentDay = "Monday";

            if (currentDay == "Monday")
            {
                salary = double.Parse(Console.ReadLine()); //*2 initialization
            }

            Console.WriteLine(salary);
        }
    }
}
