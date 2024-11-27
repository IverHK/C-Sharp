namespace O_348A_Vehicles;

public abstract class Vehicle
{
    protected string RegistrationNumber;
    protected string Effect;

    protected Vehicle(string registrationNumber, string effect)
    {
        RegistrationNumber = registrationNumber;
        Effect = effect;
    }


    internal virtual void ShowInfo()
    {
        Console.WriteLine($"\nVehicle: ");
        Console.WriteLine($"Registration number: {RegistrationNumber}");
        Console.WriteLine($"Effect: {Effect}");
    }

    internal abstract void Transport();
}