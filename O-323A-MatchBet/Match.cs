namespace O_323A_MatchBet;

internal class Match
{
    internal string bet;
    internal string command;
    internal int homeGoals { get; private set; } = 0;
    internal int awayGoals { get; private set; } = 0;
    internal bool matchIsRunning { get; private set; } = true;
    internal string isBetCorrectText { get; private set; }
    private string _result;
    private bool _isBetCorrect;
        


    internal void UpdateResults()
    {
        matchIsRunning = command != "X";
        if (command == "H") homeGoals++;
        else if (command == "B") awayGoals++;
    }

    internal void showFinalResults()
    {
        _result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
        _isBetCorrect = bet.Contains(_result);
        isBetCorrectText = _isBetCorrect ? "riktig" : "feil";
    }
}
