namespace O_341B_ClickerGame;

public interface ICommand
{
    char Command { get; }

    void Run();
}