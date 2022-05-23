using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine()); //литри
            int debitPipeOne = int.Parse(Console.ReadLine()); //литри за час
            int debitPipeTwo = int.Parse(Console.ReadLine()); //литри за час
            double missedHours = double.Parse(Console.ReadLine()); //часове

            double pipeOne = missedHours * debitPipeOne;
            double pipeTwo = missedHours * debitPipeTwo;
            double poolEndVolume = pipeOne + pipeTwo;

            if (poolEndVolume <= poolVolume)
            {
                Console.WriteLine($"The pool is {poolEndVolume / poolVolume * 100:f2}% full. Pipe 1: {pipeOne / poolEndVolume * 100:f2}%. Pipe 2: {pipeTwo / poolEndVolume * 100:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {missedHours} hours the pool overflows with {poolEndVolume - poolVolume:f2} liters.");
            }
        }
    }
}
