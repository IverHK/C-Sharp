namespace O_341B_ClickerGame;

public class CommandSet
{
    private ICommand[] _commands;

    public CommandSet(ClickerGame game)
    {
        _commands = new ICommand[]
        {
            new CommandClick(game),
            new CommandUpgrade(game),
            new CommandSuperUpgrade(game),
            new CommandExit()
        };
    }
    
    private ICommand FindCommand(char commandInput)
    {
        foreach (var action in _commands)
        {
            if (action.Command == commandInput) return action;
        }
        return null;
    }


    public void RunCommand(char input)
    {
        var command = FindCommand(input);
        if (command != null) command.Run();
    }
}