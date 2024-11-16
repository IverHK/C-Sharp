namespace O_329A_PointsGame;

internal class Player
{
    private string _name;
    private int _points;

    internal Player(string name, int points)
    {
        _name = name;
        _points = points;
    }
    internal void Play(Player OtherPlayer)
    {
        OtherPlayer._points--;
        _points++;
    }

    internal void ShowNameAndPoints()
    {
        Console.WriteLine($"{_name} Has a total of {_points} points!"); 
    }
}