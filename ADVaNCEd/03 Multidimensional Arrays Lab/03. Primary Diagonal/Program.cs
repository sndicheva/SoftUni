using System;

int matrixSize = int.Parse(Console.ReadLine());
int[,] matrix = new int[matrixSize, matrixSize];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] rowData = Console.ReadLine().Split(" ");

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = int.Parse(rowData[col]);
    }
}
int sum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    sum += matrix[row, row];
    //for (int col = row; col <= row; col++)
    //{
    //    sum += matrix[row, col] ;
    //}
}

Console.WriteLine(sum);

//int sum1 = 0;

//for (int row = matrix.GetLength(0) - 1; row > 0 ; row--)
//{
//    for (int col = row; col <= row; col++)
//    {
//        sum1 += matrix[row, col];
//    }
//}

//Console.WriteLine(sum1);
