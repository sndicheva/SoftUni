using System;

int numbers = int.Parse(Console.ReadLine());

Dictionary<string, Pieces> music = new();
List<string> piecesNames = new List<string>();

for (int i = 0; i < numbers; i++)
{
    string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    string piece = input[0];
    string composer = input[1];
    string key = input[2];

    music[piece] = new Pieces(composer, key);
    piecesNames.Add(piece);
}

while (true)
{
    string command = Console.ReadLine();
    if (command == "Stop")
    {
        break;
    }

    string[] tokens = command.Split("|");
    string piece = tokens[1];

    switch (tokens[0])
    {
        case "Add":
            AddPiece(tokens, music, piece, piecesNames);
            break;
        case "Remove":
            RemovePiece(music, piece, piecesNames);
            break;
        case "ChangeKey":
            ChangeKey(tokens, music, piece);
            break;
    }

}

foreach (var piece in piecesNames)
{
    Console.WriteLine($"{piece} -> Composer: {music[piece].Composer}, Key: {music[piece].Key}");
}


static void AddPiece(string[] tokens, Dictionary<string, Pieces> music, string piece, List<string> piecesNames)
{
    string composer = tokens[2];
    string key = tokens[3];

    if (music.ContainsKey(piece))
    {
        Console.WriteLine($"{piece} is already in the collection!");
    }
    else
    {
        piecesNames.Add(piece);
        music[piece] = new Pieces(composer, key);
        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
    }
}

static void RemovePiece(Dictionary<string, Pieces> music, string piece, List<string> piecesNames)
{
    if (music.ContainsKey(piece))
    {
        piecesNames.Remove(piece);
        music.Remove(piece);
        Console.WriteLine($"Successfully removed {piece}!");
    }
    else
    {
        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
    }
}

static void ChangeKey(string[] tokens, Dictionary<string, Pieces> music, string piece)
{
    string key = tokens[2];
    if (music.ContainsKey(piece))
    {
        music[piece].Key = key;
        Console.WriteLine($"Changed the key of {piece} to {key}!");
    }
    else
    {
        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
    }
}
public class Pieces
{
    public Pieces(string composer, string key)
    {
        Composer = composer;
        Key = key;
    }

    public string Composer { get; set; }
    public string Key { get; set; }
}

