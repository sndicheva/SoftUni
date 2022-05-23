using System;

namespace MyFirstProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is program ...
            //string name = "Ivan";
            //string surname = "Ivanov";
            //int age = 25;
            //double height = 1.80;
            //string phoneNumber = "0888888888";

            // CTRL + k + c -> comment
            // CTRL + k + u -> uncomment
            //Console.WriteLine($"Name : {name}");
            //Console.WriteLine($"Surname : {surname}");
            //Console.WriteLine($"Age : {age}");
            //Console.WriteLine($"Height : {height:f2}sm");
            //Console.WriteLine($"Phone : {phoneNumber}");
            //Console.WriteLine("He said : \"Hello\"");

            // CTRL + d -> copy current line
            // CTRL + z -> uncopy current line

            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine()); // "25" -> 25 parse - preobrazuvane kam int
            double height = double.Parse(Console.ReadLine()); // "1.75" -> 1.75
            string phoneNumber = Console.ReadLine();

            Console.WriteLine($"name : {name}");
            Console.WriteLine($"surname : {surname}");
            Console.WriteLine($"age : {age}");
            Console.WriteLine($"height : {height:f2}sm");
            Console.WriteLine($"phone : {phoneNumber}");
            





        }
    }
}
