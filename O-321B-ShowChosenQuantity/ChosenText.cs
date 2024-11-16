namespace O_321B_ShowChosenQuantity;

public class ChosenText
{
    private static int chosenQuality;

    public static void DisplayInfo(Texts[] texts)
    {
        Console.WriteLine("What quality would you like to choose?");
        chosenQuality = Convert.ToInt32(Console.ReadLine());

        foreach (var text in texts)
        {
            if (text.Quality == chosenQuality)
            {
                Console.WriteLine($"Text: {text.Text}, Quality: {text.Quality}");
            }
        }
    }
}