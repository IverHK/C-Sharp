namespace O_348A_Vehicles;

public abstract class Vehicle
{
    private readonly string _registrationNumber;
    private readonly string _effect;

    protected Vehicle(string registrationNumber, string effect)
    {
        _registrationNumber = registrationNumber;
        _effect = effect;
    }


    internal virtual void ShowInfo()
    {
        Console.WriteLine($"\nVehicle: ");
        Console.WriteLine($"Registration number: {_registrationNumber}");
        Console.WriteLine($"Effect: {_effect}");
    }

    internal abstract void Transport();
}