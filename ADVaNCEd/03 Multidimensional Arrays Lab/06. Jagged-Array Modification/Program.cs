using System;
using System.Linq;

int[][] jaggedArray = ReadJaggedArray();

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] tokens = command.Split();
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    if (row < 0 || col < 0 || row >= jaggedArray.Length || col >= jaggedArray[row].Length)
    {
        Console.WriteLine("Invalid coordinates");

    }
    else
    {
        if (tokens[0] == "add")
        {
            jaggedArray[row][col] += int.Parse(tokens[3]);
        }
        else
        {
            jaggedArray[row][col] -= int.Parse(tokens[3]);
        }
    }

    command = Console.ReadLine().ToLower();
}

for (int row = 0; row < jaggedArray.Length; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write($"{jaggedArray[row][col]} ");
    }

    Console.WriteLine();
}




static int[][] ReadJaggedArray()
{
    int rows = int.Parse(Console.ReadLine());
    int[][] jaggedArray = new int[rows][];

    for (int row = 0; row < jaggedArray.GetLength(0); row++)
    {
        jaggedArray[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
    return jaggedArray;
}