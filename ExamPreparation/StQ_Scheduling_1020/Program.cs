using System;
using System.Collections.Generic;
using System.Linq;

namespace StQ_Scheduling_1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)); ;
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)); ;
            int taskToBeKilled = int.Parse(Console.ReadLine());
            bool isTaskBeenKilled = false;


            while (!isTaskBeenKilled)
            {
                if (tasks.Peek() == taskToBeKilled)
                {
                    Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToBeKilled}");
                    
                    isTaskBeenKilled=true;
                    break;
                }
                else if (tasks.Peek() <= threads.Peek())
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if(tasks.Peek() > threads.Peek())
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
