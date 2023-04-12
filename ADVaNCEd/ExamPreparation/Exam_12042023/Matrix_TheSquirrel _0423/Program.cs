int size = int.Parse(Console.ReadLine());
List<string> commands = new List<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList());

int hazelnutsCount = 0;
char[,] matrix = new char[size, size];
(int currRow, int currCol) = (0, 0); // current position of the squirrel
AddingMatrixInput(matrix, size);

//Find InitialPosition
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == 's')
        {
            currRow = row;
            currCol = col;
        }
    }
}

for (int i = 0; i < commands.Count; i++)
{
    string commandInfo = commands[i];
    if (commandInfo == "up")
    {
        currRow--;
    }
    else if (commandInfo == "down")
    {
        currRow++;
    }
    else if (commandInfo == "left")
    {
        currCol--;
    }
    else if (commandInfo == "right")
    {
        currCol++;
    }
    //check if the is in the matrix :
    if (IsInTheMatrix(matrix, currRow, currCol))
    {
        if (matrix[currRow, currCol] == 'h')
        {
            hazelnutsCount++;
            matrix[currRow, currCol] = '*';
            if (hazelnutsCount == 3)
            {
                matrix[currRow, currCol] = 's';
                break;
            }
        }
        else if (matrix[currRow, currCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
            return;
        }
    }
    else
    {
        Console.WriteLine("The squirrel is out of the field.");
        Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");
        return;
    }
}

if (hazelnutsCount < 3)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}
else
{
    Console.WriteLine("Good job! You have collected all hazelnuts!");
}


Console.WriteLine($"Hazelnuts collected: {hazelnutsCount}");


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


static bool IsInTheMatrix<T>(T[,] matrix, int currRow, int currCol)
{
    if (currRow < 0 || currRow >= matrix.GetLength(0) || currCol < 0 || currCol >= matrix.GetLength(1))
    {
        return false;
    }
    return true;
}

