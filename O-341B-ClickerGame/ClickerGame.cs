namespace O_341B_ClickerGame;

public class ClickerGame
{
    internal int Points = 0;
    private int _pointsPerClick = 1;
    private int _pointsPerClickIncrease = 1;
    
    public void CommandClick()
    {
        Points += _pointsPerClick;
    }
    
    public void CommandUpgrade()
    {
        Points = Points >= 10 ? Points - 10 : Points;
        _pointsPerClick += _pointsPerClickIncrease;
    }
    
    public void CommandSuperUpgrade()
    {
        Points = Points >= 100 ? Points - 100 : Points;
        _pointsPerClickIncrease++;

    }
    

}