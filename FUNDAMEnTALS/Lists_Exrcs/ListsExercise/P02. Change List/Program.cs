using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string order = tokens[0];

                if (order == "Delete")
                {
                    int numberToDelete = int.Parse(tokens[1]);
                    numbers.RemoveAll(el => el == numberToDelete);
                }
                else if (order == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

