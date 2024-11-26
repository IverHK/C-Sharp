namespace O_341B_ClickerGame;

public class CommandClick : ICommand
{
    public char Command { get; } = ' ';
    private ClickerGame _game;
    
    public CommandClick(ClickerGame game)
    {
        _game = game;
    }



    public void Run()
    {
        _game.CommandClick();
    }
}