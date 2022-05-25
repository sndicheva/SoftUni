using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine(); // username
            //string password = Console.ReadLine(); // reverse username = password

            string password = string.Empty;
            //int counter = 0;

            for (int reverseIndex = userName.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                password += userName[reverseIndex];
            }

            for (int count = 1; count <= 4; count++)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    if (count == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        continue;
                    }
                }
            }
        }
    }
}