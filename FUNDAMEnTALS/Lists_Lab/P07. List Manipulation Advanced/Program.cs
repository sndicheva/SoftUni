using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool changes = false;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        changes = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        changes = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        changes = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        changes = true;
                        break;
                    case "Contains":
                        int numberExistInTheList = int.Parse(tokens[1]);
                        bool isNumberExistInTheList = numbers.Contains(numberExistInTheList);
                        if (isNumberExistInTheList)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        foreach (int number in numbers)
                        {
                            if (number % 2 == 0)
                            {
                                Console.Write($"{number} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        foreach (int number in numbers)
                        {
                            if (number % 2 != 0)
                            {
                                Console.Write($"{number} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sumOfTheElements = numbers.Sum();
                        Console.WriteLine(sumOfTheElements);
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int numFilter = int.Parse(tokens[2]);
                        if (condition == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x < numFilter)));
                            //for (int i = 0; i < numbers.Count; i++)
                            //{
                            //    if (numbers[i] < numFilter)
                            //    {
                            //        Console.Write($"{numbers[i]} ");
                            //    }
                            //}
                        }
                        else if (condition == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > numFilter)));
                            //for (int i = 0; i < numbers.Count; i++)
                            //{
                            //    if (numbers[i] > numFilter)
                            //    {
                            //        Console.Write($"{numbers[i]} ");
                            //    }
                            //}
                        }
                        else if (condition == ">=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= numFilter)));
                            //for (int i = 0; i < numbers.Count; i++)
                            //{
                            //    if (numbers[i] >= numFilter)
                            //    {
                            //        Console.Write($"{numbers[i]} ");
                            //    }
                            //}
                        }
                        else if (condition == "<=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= numFilter)));
                            //for (int i = 0; i < numbers.Count; i++)
                            //{
                            //    if (numbers[i] <= numFilter)
                            //    {
                            //        Console.Write($"{numbers[i]} ");
                            //    }
                            //}
                        }                       
                        break;
                }
            }
            if (changes)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
