using System;
public enum VehicleType
{
    Car,
    Truck,
    Bus,
    Motorcycle
}

public class Vehicle : IDriveable
{
    public string Name { get; set; }
    public double Speed { get; set; }
    public double Size { get; set; }
    public VehicleType Type { get; set; }

    public Vehicle(string name, double speed, double size, VehicleType type)
    {
        Name = name;
        Speed = speed;
        Size = size;
        Type = type;
    }

    public void Move()
    {
        Console.WriteLine($"{Name} is moving at {Speed} km/h.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} has stopped.");
    }
}
