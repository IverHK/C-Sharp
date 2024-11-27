namespace O_348A_Vehicles;

public class Boat : Vehicle
{
    internal int _maxSpeed;
    internal int _loadCapacity;
    
    public Boat(string registrationNumber, string effect, int maxSpeed, int loadCapacity) : base(registrationNumber, effect)
    {
        _maxSpeed = maxSpeed;
        _loadCapacity = loadCapacity;
    }

    internal override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Max speed: {_maxSpeed}knops");
        Console.WriteLine($"Load capacity: {_loadCapacity} brutto");
    }


    internal override void Transport()
    {
        Console.WriteLine("The boat is floating along the way");
    }
}