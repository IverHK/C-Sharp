namespace O_341B_ClickerGame;

public class CommandExit : ICommand
{
    public char Command { get; } = 'X';

    public void Run()
    {
        Environment.Exit(0);

    }
}