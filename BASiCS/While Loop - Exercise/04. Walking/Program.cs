using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;//създаваме променлива, която ще пази броят стъпки, които е изминала
            string input = Console.ReadLine();//променлива, която ще пази входа от конзолата

            while (input!="Going home") 
            {
                steps += int.Parse(input);
                if (steps >= 10000)//steps >= 10 000
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (input== "Going home")
            {
                input = Console.ReadLine();
                steps += int.Parse(input);
            }

            if (steps < 10000)
            {
                Console.WriteLine($"{10000-steps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
        }
    }
}
