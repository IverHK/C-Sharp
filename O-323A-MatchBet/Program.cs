namespace O_323A_MatchBet;

class Program
{
    static void Main(string[] args)
    {
        Match match = new Match();

        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" +
                      " - halvgardering: HU, HB, UB\n" +
                      " - helgardering: HUB\n" +
                      "Hva har du tippet for denne kampen? ");
        match.bet = Console.ReadLine();
        while (match.matchIsRunning)
        {
            Console.Write("Kommandoer: \n" +
                          " - H = scoring hjemmelag\n" +
                          " - B = scoring bortelag\n" +
                          " - X = kampen er ferdig\n" +
                          "Angi kommando: ");

            match.command = Console.ReadLine();
            match.UpdateResults();
            Console.WriteLine($"Stillingen er {match.homeGoals}-{match.awayGoals}.");
        }

        match.showFinalResults();
    }
}