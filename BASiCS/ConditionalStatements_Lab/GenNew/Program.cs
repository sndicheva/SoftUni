using System;

namespace GenNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Console.WriteLine(5 <= 6.5);
            //*Console.WriteLine("softuni" == "Softuni"); //false // ("softuni is the best" >"softuni")->за сега не можем да ги сравняваме
            //*Console.WriteLine("softuni is the best" != "softuni");

            //*int age = int.Parse(Console.ReadLine());
            //*bool isOfAge = age >= 18; //запазваме стойността в променливата isOfAge за да можем да я ползваме и по-късно
            //*Console.WriteLine(isOfAge);

            //Example 1 - С bool
            //*int a = -5;
            //*bool isPositive = a > 0; // false
            //*            if (isPositive)
            //*{
            //*    Console.WriteLine("The number is positive!");
            //*}

            //Example 2 - Без bool
            //*int age = 39;
            //*if (age >= 18) ;
            //*{
            //*    Console.WriteLine("You can drink beer!");
            //*}

            //Math.Round(45.67, 0);
            //
            //Console.WriteLine(Math.Round(45.67));
            //* double num = 5.6789809000;
            //* Console.WriteLine($"{num:f4}");
            //* Console.WriteLine($"{Math.Round(num, 4)}"); - izpuska nulata!!!
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            // num1 < num2
            // num2 > num1
            // num1 == num2

            // breakpoint

            //if (num1 > num2)
            //{
            //    Console.WriteLine(num1);
            //}
            //else
            // {
            //    Console.WriteLine(num2);
            //}
            string weather = Console.ReadLine();

            // sunny, cloudy, rainy
            if (weather == "sunny")
            {
                Console.WriteLine("Go for a walk");
            }
            else if (weather == "cloudy")
            {
                Console.WriteLine("Take an umbrela!");
            }
            else if (weather == "rainy")
            {
                Console.WriteLine("Stay at home!");
            }


        }
    }
}
