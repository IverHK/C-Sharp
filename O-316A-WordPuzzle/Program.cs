namespace O_316A_WordPuzzle;

class Program
{
static void Main(string[] args)
    {
        Console.WriteLine(FindWord());
    }
    private static string FindWord()
    {
        var filename = "ordliste.txt";
        if (!File.Exists(filename))
        {
            return "File not found!";
        }
        string[] completeWordList = File.ReadAllLines(filename);
        string previousWord = "";
        var list = new List<string>();
        var gameWords = new List<string>();

        foreach (var line in completeWordList)
        {
            string[] wordList = line.Split('\t');
            
            if (wordList[1] != previousWord && !wordList[1].Contains('-') && (wordList[1].Length == 7 || wordList[1].Length == 8 || wordList[1].Length == 9 || wordList[1].Length == 10 ))
            {
//                Console.WriteLine(wordList[1]);
                list.Add(wordList[1]);
            }
            previousWord = wordList[1];
        }

        int count = 200;
        while ( count > 0)
        {
            int randomIndex = new Random().Next(0, list.Count);
            string lastPartOfFirstWord = getPartOfWord(list[randomIndex]);
            string firstPartOfSecondWord = "";
            
            foreach (var word in list)
            {
                firstPartOfSecondWord = getPartOfWord(word, 3);
                if (lastPartOfFirstWord == firstPartOfSecondWord && list.Any(word => word.Contains(lastPartOfFirstWord)))
                {
                    gameWords.Add($"{list[randomIndex]} + {word}");
                    count--;
                    break;
                }
            }
        }
        foreach (var word in gameWords){Console.WriteLine(word);}
        return $"completed";
    }
    
    private static string getPartOfWord(string word, int startIndex)
    {
        string partOfWord = word.Substring(0, startIndex); 
        return $"{partOfWord}";
    }   
    private static string getPartOfWord(string word)
    {
        string partOfWord = word.Substring(word.Length - 3);
        return $"{partOfWord}";
    }
}