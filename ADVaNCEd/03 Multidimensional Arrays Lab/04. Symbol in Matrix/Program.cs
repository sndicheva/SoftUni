using System;

int matrixSize = int.Parse(Console.ReadLine());
char[,] matrix = new char[matrixSize, matrixSize];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] rowData = Console.ReadLine().ToCharArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowData[col];
    }
}
char inputSymbol = char.Parse(Console.ReadLine());
int currentRow = -1; int currentCol = -1;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == inputSymbol)
        {
            if (currentRow < row && currentCol < col)
            {
                currentRow = row;
                currentCol = col;

            }
            else
            {
                continue;
            }
        }
        else continue;
    }
}

if (currentRow >= 0 && currentCol >= 0)
{
    Console.WriteLine($"({currentRow}, {currentCol})");
}
else
{
    Console.WriteLine($"{inputSymbol} does not occur in the matrix");
}


