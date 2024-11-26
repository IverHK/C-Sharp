namespace O_341B_ClickerGame;

public class CommandUpgrade : ICommand
{
    public char Command { get; } = 'K';
    private ClickerGame _game;

    public CommandUpgrade(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.CommandUpgrade();
    }
}