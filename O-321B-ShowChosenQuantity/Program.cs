namespace O_321B_ShowChosenQuantity;

class Program
{
    static void Main(string[] args)
    {
        Texts[] texts = new Texts[10];
        texts[0] = new Texts("Quick intro", 8);
        texts[1] = new Texts("Detailed overview", 9);
        texts[2] = new Texts("Brief summary", 7);
        texts[3] = new Texts("Concise report", 8);
        texts[4] = new Texts("Short analysis", 6);
        texts[5] = new Texts("Simple note", 5);
        texts[6] = new Texts("In-depth review", 9);
        texts[7] = new Texts("Clear explanation", 10);
        texts[8] = new Texts("Basic outline", 9);
        texts[9] = new Texts("Quick insight", 7);
        
        ChosenText.DisplayInfo(texts);
        
    }
}