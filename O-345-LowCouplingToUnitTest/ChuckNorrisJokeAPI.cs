using RestSharp;


namespace O_345_LowCouplingToUnitTest;

public class ChuckNorrisJokeAPI : IJokeRetriever
{
    public async Task<IEnumerable<string>> GetJokes(string word)
    {
        var client = new RestClient("https://api.chucknorris.io");
        var request = new RestRequest($"/jokes/search?query={word}");
        var result = await client.GetAsync<ChuckNorrisJokeSearchResultSet>(request);
        
        return result.result.Select(joke => joke.value);
    }

}