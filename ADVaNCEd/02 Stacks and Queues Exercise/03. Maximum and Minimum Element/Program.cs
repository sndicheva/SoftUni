using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> numbersStack = new();

int numberOfCommands = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfCommands; i++)
{
    string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
    string token = tokens[0];
    switch (token)
    {
        case "1":
            int token2 = int.Parse(tokens[1]);
            numbersStack.Push(int.Parse(tokens[1]));
            break;
        case "2":
            numbersStack.Pop();
            break;
        case "3":
            if (!numbersStack.Any())
            {
                break;
            }
            Console.WriteLine(numbersStack.Max());
            break;
        case "4":
            if (!numbersStack.Any())
            {
                break;
            }
            Console.WriteLine(numbersStack.Min());
            break;
    }
}

Console.WriteLine(String.Join(", ", numbersStack));
