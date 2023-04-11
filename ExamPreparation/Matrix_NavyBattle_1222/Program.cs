
int hitCount = 3;//by ==0 =>"Mission failed, U-9 disappeared! Last known coordinates [{row}, {col}]!"
int cruiserCount = 3; //by ==0 =>"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!"

int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size, size];
(int submarineRow, int submarineCol) = (0, 0);
AddingMatrixInput(matrix, size);
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] == 'S')
        {
            submarineRow = row;
            submarineCol = col;
        }
    }
}
while (true)
{
    if (hitCount == 0 || cruiserCount == 0)
    {
        break;
    }
    string command = Console.ReadLine();
    matrix[submarineRow, submarineCol] = '-';
    if (command == "up")
    {
        submarineRow--;
    }
    else if (command == "down")
    {
        submarineRow++;
    }
    else if (command == "left")
    {
        submarineCol--;
    }
    else if (command == "right")
    {
        submarineCol++;
    }
    if (matrix[submarineRow, submarineCol] == '*')
    {
        hitCount--;
        if (hitCount == 0)
        {
            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
            break;
        }
    }
    if (matrix[submarineRow, submarineCol] == 'C')
    {
        cruiserCount--;
        if (cruiserCount == 0)
        {
            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            break;
        }
    }
    matrix[submarineRow, submarineCol] = '-';
}
matrix[submarineRow, submarineCol] = 'S';

PrintMatrix(matrix);


//Entries:
static void AddingMatrixInput(char[,] matrix, int size)
{
    for (int row = 0; row < size; row++)
    {
        string rowInput = Console.ReadLine();
        for (int col = 0; col < size; col++)
        {
            matrix[row, col] = rowInput[col];            
        }
    }
}

static void PrintMatrix<T>(T[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}
