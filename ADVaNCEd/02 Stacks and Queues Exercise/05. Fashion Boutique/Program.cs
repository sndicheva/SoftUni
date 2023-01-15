using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> boxOfClothes = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
);
int rackCapacity = int.Parse(Console.ReadLine());

int rackCount = 1;
int currentRack = rackCapacity;
while (boxOfClothes.Any())
{
    currentRack -= boxOfClothes.Peek();

    if (currentRack < 0)
    {
        rackCount++;
        currentRack = rackCapacity;
        continue;
    }

    boxOfClothes.Pop();
}

Console.WriteLine(rackCount);
