using System;

int[,] matrix = ReadMatrix();

int sum = 0;
int maxRow = 0;
int maxCol = 0;
for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    int currentSum = 0;

    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];


        if (currentSum > sum)
        {
            sum = currentSum;
            maxRow = row;
            maxCol = col;
        }
    }
}

Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
Console.WriteLine(sum);

static int[,] ReadMatrix()
{
    string[] matrixSize = Console.ReadLine().Split(", ");
    int rows = int.Parse(matrixSize[0]);
    int cols = int.Parse(matrixSize[1]);

    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        string[] rowData = Console.ReadLine().Split(", ");

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = int.Parse(rowData[col]);
        }
    }

    return matrix;
}