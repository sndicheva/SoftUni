using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string operation = tokens[0];

                if (operation == "Add")
                    numbers.Add(int.Parse(tokens[1]));

                else if (operation == "Insert")
                {
                    int firstNum = int.Parse(tokens[1]);
                    int secondNum = int.Parse(tokens[2]);

                    if (secondNum < 0 || secondNum >= numbers.Count-1)
                    {
                        Console.WriteLine("Invalid index");
                       
                    }
                    else
                    numbers.Insert(secondNum, firstNum);
                }

                else if (operation == "Remove")
                {
                    int index = int.Parse(tokens[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                       
                    }
                    else
                    numbers.RemoveAt(index);
                }

                else if (operation == "Shift")
                {
                    int count = int.Parse(tokens[2]);
                    if (tokens[2] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[i]);
                            numbers.RemoveAt(i);
                        }
                    }
                    else // "right"
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers[numbers.Count - 1]);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
