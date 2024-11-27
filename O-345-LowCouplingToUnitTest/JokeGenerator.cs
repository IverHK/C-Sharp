using RestSharp;

namespace O_345_LowCouplingToUnitTest;

public class JokeGenerator
{
    private readonly IJokeRetriever _jokeRetriever;

    public JokeGenerator(IJokeRetriever jokeRetriever)
    {
       _jokeRetriever = jokeRetriever; 
    }
    public async Task<string> GetJokeWithWordTwoTimes(string word)
    {

        var jokes = await _jokeRetriever.GetJokes(word);

        foreach (var joke in jokes)
        {
            var firstPosition = joke.IndexOf(word, StringComparison.OrdinalIgnoreCase);
            if (firstPosition == -1) continue;
            var secondPosition = joke.IndexOf(word, firstPosition + 1, StringComparison.OrdinalIgnoreCase);
            if (secondPosition != -1) return joke;
        }
         
        return null;
    }
}