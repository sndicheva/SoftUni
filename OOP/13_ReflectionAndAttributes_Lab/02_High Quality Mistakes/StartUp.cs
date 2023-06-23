

using Stealer;
public class StartUp
{
    static void Main(string[] agrs)
    {

        Spy spy = new Spy();

        string result = spy.AnalyzeAccessModifiers("Stealer.Hacker");

        Console.WriteLine(result);
    }
}