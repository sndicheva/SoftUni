
using System;
using System.Linq;

int[] matrixSize = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[,] matrix = new int[matrixSize[0], matrixSize[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] rowData = Console.ReadLine().Split(", ");

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = int.Parse(rowData[col]);
    }
}
int sum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        sum += matrix[row, col];
    }
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);
