int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
int playerRow = 0;
int playerCol = 0;
int moves = 0;
int reachedOpponents = 0;

string[,] playground = new string[rows, cols];
InitialPlayground(rows, cols, playground);
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (playground[row, col] == "B")
        {
            playerRow = row;
            playerCol = col;
        }
    }
}
while (true)
{
    string command = Console.ReadLine();
    if (command == "Finish")
    {
        break;
    }

    switch (command)
    {
        case "up":
            Move(-1, 0);
            break;
        case "down":
            Move(1, 0);
            break;
        case "left":
            Move(0, -1);
            break;
        case "right":
            Move(0, 1);
            break;
    }
    if (reachedOpponents == 3)
    {
        break;
    }
}
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {reachedOpponents} Moves made: {moves}");

void Move(int row, int col)
{
    if (IsInPlayground(playerRow + row, playerCol + col))
    {
        if (playground[playerRow + row, playerCol + col] == "O")
        {
            return;
        }
        else if (playground[playerRow + row, playerCol + col] == "P")
        {
            moves++;
            reachedOpponents++;
            playground[playerRow, playerCol] = "-";
            playground[playerRow + row, playerCol + col] = "B";
            playerRow += row;
            playerCol += col;
        }
        else if (playground[playerRow + row, playerCol + col] == "-")
        {
            moves++;
            playerRow += row;
            playerCol += col;
        }
    }
    else return;
}

bool IsInPlayground(int row, int col)
{
    return row >= 0 && row < rows && col >= 0 && col < cols;
}

void InitialPlayground(int rows, int cols, string[,] playground)
{
    for (int row = 0; row < rows; row++)
    {
        char[] inputRows = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
        for (int col = 0; col < cols; col++)
        {
            playground[row, col] = inputRows[col].ToString();
        }
    }
}