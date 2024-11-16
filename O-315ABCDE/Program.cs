namespace O_315ABCDE;

class Program
{
    static void Main(string[] args)
    {
        string reversedText = ReverseText("Hello World");
        Console.WriteLine($"The reversed text is: {reversedText}");
        
        Console.WriteLine(CountWords("hello dude"));
        Console.WriteLine(FindLongestWord("hello dude cooool"));
        int[] numbers = CreateArray(0, 100, 9);

        foreach (int element in numbers)
        {
            Console.WriteLine(element);
        }
        
    }

    

    static string ReverseText(string originalText)
    {
        char[] textArray = originalText.ToCharArray(); 
        Array.Reverse(textArray);
        return new string(textArray);
    }

    static string CountWords(string originalText)
    { 
        char[] textArray = originalText.ToCharArray();
        int spaceCount = 0;
        if (textArray.Length >= 1) spaceCount = 1;
        
        foreach (char character in textArray)
        {
            if (character == ' ') spaceCount++;
        }

        return $"There are {spaceCount} words in the text";
    }

    static string FindLongestWord(string originalText)
    {
        string[] word = originalText.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = "";

        foreach (string wordItem in word)
        {
            if (longestWord.Length < wordItem.Length) longestWord = wordItem;
        }

        return $"The longest word is {longestWord}, and it consist of {longestWord.Length} letters";
    }

    static int[] CreateArray(int start, int end, int difference)
    {
        int[] newArray = new int[((end - start) / difference) + 1];
        int counter = 0;
        for (int i = start; i < end; i += difference)
        {
            newArray[counter] = i;
            counter++;
        }

        return newArray;
    }
}