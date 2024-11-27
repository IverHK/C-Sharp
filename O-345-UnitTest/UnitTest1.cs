using Moq;
using O_345_LowCouplingToUnitTest;

namespace O_345_UnitTest;

public class Tests
{

    [Test]
    public async Task Test1()
    {
        var JokeRetrieverMock = new Mock<IJokeRetriever>();
        JokeRetrieverMock.Setup(jsm => jsm.GetJokes(It.IsAny<string>()))
            .ReturnsAsync(new[]
            {
                "aaa bbb",
                "ccc bbb",
                "aaa aaa zzz",
            });

        var jokeGenerator = new JokeGenerator(JokeRetrieverMock.Object);
        var joke = await jokeGenerator.GetJokeWithWordTwoTimes("aaa");
        
        Assert.AreEqual("aaa aaa zzz", joke);
    }
}