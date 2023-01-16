﻿using System;

string[] matrixSize = Console.ReadLine().Split(", ");
int rows = int.Parse(matrixSize[0]);
int cols = int.Parse(matrixSize[1]);

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] rowData = Console.ReadLine().Split(" ");

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = int.Parse(rowData[col]);
    }
}

for (int col = 0; col < matrix.GetLength(1); col++)
{
    int sum = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        sum += matrix[row, col];
    }

    Console.WriteLine(sum);
}