namespace O_321B_ShowChosenQuantity;

public class Texts
{
    public string Text { get; set; } 
    public int Quality { get; set; }

    public Texts(string text, int quality)
    {
        Text = text;
        Quality = quality;
    }
}