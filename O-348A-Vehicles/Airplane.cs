namespace O_348A_Vehicles;

public class Airplane : Vehicle
{
    private int _wingspan;
    private int _loadCapacity;
    private string _weightClass;
    
    
    public Airplane(string registrationNumber, string effect, int wingspan, int loadCapacity, string weightClass) : base(registrationNumber, effect)
    {
        _loadCapacity = loadCapacity;
        _weightClass = weightClass;
        _wingspan = wingspan;
    }

    internal override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Wingspan: {_wingspan}m");
        Console.WriteLine($"Load capacity: {_loadCapacity}T");
        Console.WriteLine($"Weight Class : {_weightClass}\n");
    }

    internal override void Transport()
    {
        Console.WriteLine("The airplane is wooshing through the air");
    }
}