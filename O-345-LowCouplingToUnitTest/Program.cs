namespace O_345_LowCouplingToUnitTest;

class Program
{
    static void Main(string[] args)
    {
        MainAsync().Wait();
    }

    static async Task MainAsync()
    {
        var chuckNorrisJokeApi = new ChuckNorrisJokeAPI();
        var generator = new JokeGenerator(chuckNorrisJokeApi);
        while (true)
        {
            Console.Write("Hvilket ord vil du at vitsene skal ha to av? ");
            var  word = Console.ReadLine();
            var joke = await generator.GetJokeWithWordTwoTimes(word);
            Console.WriteLine(joke ?? $"Fant ingen vitser med ordet \"{word}\" to ganger.");
        }
    }
}