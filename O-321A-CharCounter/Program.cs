namespace O_321A_CharCounter;

class Program
{
    static void Main(string[] args)
    {
        var counter = new CharCounter();
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            counter.AddText(text);
            counter.ShowCounts();
        }
    }
}