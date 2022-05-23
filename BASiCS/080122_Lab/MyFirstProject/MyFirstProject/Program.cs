using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = "Ivan";
            string surname = "Ivanov";
            int age = 25;
            double height = 1.80;
            string phoneNumber = "0888888888";
            
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Surname : {surname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Height : {height:f2}sm");
            Console.WriteLine($"Phone : {phoneNumber}");
            Console.WriteLine("He said : \"Hello\"");

        }
    }
 
}
