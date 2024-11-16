namespace O_323B_TwelveMatchesBet;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" +
                      " - halvgardering: HU, HB, UB\n" +
                      " - helgardering: HUB\n" +
                      "Skriv inn dine 12 tippinger med komma mellom hver (en tipping for hver kamp): ? ");
        TwelveMatches.BetsText = Console.ReadLine();
        TwelveMatches.SetMatches();

        while (true)
        {
            Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
            TwelveMatches.command = Console.ReadLine();
            if (TwelveMatches.command == "X") break;
            Console.Write("Kommandoer: \n" +
                          " - H = scoring hjemmelag\n" +
                          " - B = scoring bortelag\n" +
                          " - X = kampen er ferdig\n" +
                          "Angi kommando: ");
            TwelveMatches.team = Console.ReadLine();
            TwelveMatches.FindMatchNo();
            TwelveMatches.ShowResults();

            Console.WriteLine($"Du har {TwelveMatches.correctCount} rette.");

        }
    }
}