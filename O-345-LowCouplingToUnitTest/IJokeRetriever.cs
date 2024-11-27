namespace O_345_LowCouplingToUnitTest;

public interface IJokeRetriever
{
    Task<IEnumerable<string>> GetJokes(string word);
}