using System.Text.RegularExpressions;

string pattern = @"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string input = Console.ReadLine();

    Match match = Regex.Match(input, pattern);
    if (match.Success)
    {
        string product = match.Groups[1].Value;
        string productCode = new string(product.Where(Char.IsDigit).ToArray());
        
        if (string.IsNullOrEmpty(productCode))
        {
            productCode = "00";
        }
        Console.WriteLine($"Product group: {productCode}");
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
}