namespace O_341B_ClickerGame;

public class CommandSuperUpgrade : ICommand
{
    public char Command { get; } = 'S';
    private ClickerGame _game;

    public CommandSuperUpgrade(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.CommandSuperUpgrade();
    }

}