using System;

namespace While_Loop___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //string areThereAnyDishes = Console.ReadLine();
            ////yes/no
            //
            //while (areThereAnyDishes == "yes")
            //{
            //    Console.WriteLine("Washing a dish...");
            //    areThereAnyDishes = Console.ReadLine();
            //}


            //int numberOfDishes = 10;
            //
            //while (numberOfDishes > 0)
            //{
            //    Console.WriteLine("Washing a dish...");
            //    numberOfDishes--;
            //}
            //
            //Console.WriteLine();
            //Console.WriteLine("For starts here....");
            //Console.WriteLine();
            //
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine("Washing a dish...");
            //}


            //!!!!!new String('*', password.lenght)

            // 05.balance...

            string command = Console.ReadLine();
            int sum = 0;

            while (command != "Stop")
            {
                sum += int.Parse(command);//!!!!!!!!! '10' -> 10
                command = Console.ReadLine();
            }
            Console.WriteLine(sum);

        }
    }
}
