
int count = int.Parse(Console.ReadLine());

Dictionary<string, MusicPiece> musicCollection = new Dictionary<string, MusicPiece>();

for (int i = 0; i < count; i++)
{
    string[] inputInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    string musicPiece = inputInfo[0];
    string composer = inputInfo[1];
    string key = inputInfo[2];
    musicCollection[musicPiece] = new MusicPiece(composer, key);
}

while (true)
{
    string[] command = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "Stop")
    {
        break;
    }
    switch (command[0])
    {
        case "Add":
            Add(musicCollection, command);
            break;
        case "Remove":
            Remove(musicCollection, command);
            break;
        case "ChangeKey":
            ChangeKey(musicCollection, command);
            break;
    }
}
foreach (var piece in musicCollection)
{
    Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
}


void Add(Dictionary<string, MusicPiece> musicCollection, string[] command)
{
    string musicPiece = command[1];
    string composer = command[2];
    string key = command[3];
    if (!musicCollection.ContainsKey(musicPiece))
    {
        musicCollection.Add(musicPiece, new MusicPiece(composer, key));
        Console.WriteLine($"{musicPiece} by {composer} in {key} added to the collection!");
    }
    else
    {
        Console.WriteLine($"{musicPiece} is already in the collection!");
    }
}

void Remove(Dictionary<string, MusicPiece> musicCollection, string[] command)
{
    string musicPiece = command[1];
    if (!musicCollection.ContainsKey(musicPiece))
    {        
        Console.WriteLine($"Invalid operation! {musicPiece} does not exist in the collection.");
    }
    else
    {
        musicCollection.Remove(musicPiece);
        Console.WriteLine($"Successfully removed {musicPiece}!");
    }
}
void ChangeKey(Dictionary<string, MusicPiece> musicCollection, string[] command)
{
    string musicPiece = command[1];
    string newKey = command[2];
    if (!musicCollection.ContainsKey(musicPiece))
    {
        Console.WriteLine($"Invalid operation! {musicPiece} does not exist in the collection.");
    }
    else
    {
        musicCollection[musicPiece].Key = newKey;
        Console.WriteLine($"Changed the key of {musicPiece} to {newKey}!");
    }
}
public class MusicPiece
{
    public MusicPiece(string composer, string key)
    {
        Composer = composer;
        Key = key;
    }

    public string Composer { get; set; }
    public string Key { get; set; }

}
