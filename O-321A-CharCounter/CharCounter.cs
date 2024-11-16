namespace O_321A_CharCounter;

public class CharCounter
{
    private int range;
    private int[] counts;

    public CharCounter()
    {
        range = 250;
        counts = new int[range];
    }

    public void AddText(string text)
    {
        foreach (var character in text ?? string.Empty)
        {
            counts[(int)character]++;
        }
    }

    public void ShowCounts()
    {
        for (var i = 0; i < range; i++)
        {
            if (counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(character + " - " + counts[i]);
            }
        }
    }
}