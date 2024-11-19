namespace O_329C_BottleTask;

class Program
{
    static void Main(string[] args)
    {
        var wantedVolume = 5 ;
        var bottle1 = new Bottle(1); 
        var bottle2 = new Bottle(2);
        
        
        for (int numberOfOperations = 0; numberOfOperations <= 7; numberOfOperations++)
        {
            Operations.TryWithGivenNumberOfOperations(numberOfOperations, bottle1, bottle2, wantedVolume);
            if (Operations.solutionFound) 
            {
                break;
            }
        }
        Console.WriteLine("Program complete.");
        
    }
}


