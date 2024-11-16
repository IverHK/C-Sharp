namespace O_323B_TwelveMatchesBet;

internal class TwelveMatches
{
    internal static string BetsText;
    internal static string command;
    internal static string team;
    internal static int correctCount = 0;
    private static string[] bets = new String [12];
    private static Match[] matches = new Match [12];
    private static int matchNo;
    private static Match selectedMatch;
    private static int selectedIndex;
    
    internal static void SetMatches()
    {
        bets = BetsText.Split(',');
        matches = new Match[12];
        for (var i = 0; i < 12; i++)
        {
            matches[i] = new Match(TwelveMatches.bets[i]);
        }
    }

    internal static void FindMatchNo()
    {
        matchNo = Convert.ToInt32(command);
        selectedIndex = matchNo - 1;
        selectedMatch = matches[selectedIndex];
        selectedMatch.AddGoal(team == "H");

    }

    internal static void ShowResults()
    {
        correctCount = 0;
        
        for (var index = 0; index < TwelveMatches.matches.Length; index++)
        {
            var match = matches[index];
            matchNo = index + 1;
            var isBetCorrect = match.IsBetCorrect();
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            if (isBetCorrect) correctCount++;
            Console.WriteLine($"Kamp {TwelveMatches.matchNo}: {match.GetScore()} - {isBetCorrectText}");
        }
    }
}