namespace O_348A_Vehicles;

public class Car : Vehicle
{
    private readonly int _maxSpeed;
    private readonly string _color;
    private readonly string _weightClass;
    
    public Car(string registrationNumber, string effect, int maxSpeed, string color, string weightClass) : base( registrationNumber,  effect)
    {
        _maxSpeed = maxSpeed;
        _color = color;
        _weightClass = weightClass;
    }

    internal override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Max Speed: {_maxSpeed}km/t");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Weight Class : {_weightClass}\n");
    }

    internal void CompareWith(Car car, Car otherCar)
    {
        if (otherCar == car) Console.WriteLine("This is the same vehicle\n");
        else Console.WriteLine("This is a different vehicle\n");
    }

    internal override void Transport()
    {
        Console.WriteLine("The car is driving\n");
    }
}