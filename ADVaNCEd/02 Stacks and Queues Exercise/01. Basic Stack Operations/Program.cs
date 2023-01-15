
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int firstToken = int.Parse(tokens[0]);
int secondToken = int.Parse(tokens[1]);
int thirdToken = int.Parse(tokens[2]);

int[] inputString = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Stack<int> stack = new();

for (int i = 0; i < firstToken; i++)
{
    stack.Push(inputString[i]);
}

for (int j = 0; j < secondToken; j++)
{
    stack.Pop();
}

if (stack.Contains(thirdToken) && stack.Any())
{
    Console.WriteLine("true");
}
else if (stack.Any())
{
    Console.WriteLine($"{stack.Min()}");
}
else
{
    Console.WriteLine("0");
}