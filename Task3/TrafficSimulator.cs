using System;
using System.Collections.Generic;

public class TrafficSimulator
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void SimulateTraffic(Road road)
    {
        Console.WriteLine($"Simulating traffic on a {road.Length} km road with {road.Lanes} lane(s).");

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"{vehicle.Name} enters the road.");
            vehicle.Move();

            double adjustedSpeed = vehicle.Speed - (road.TrafficLevel * 5);
            Console.WriteLine($"{vehicle.Name} adjusts speed to {adjustedSpeed} km/h due to traffic level {road.TrafficLevel}.");
        }

        road.TrafficLevel++;
        Console.WriteLine($"Traffic level on the road has increased to {road.TrafficLevel}.");

        foreach (var vehicle in vehicles)
        {
            vehicle.Stop();
            Console.WriteLine($"{vehicle.Name} exits the road.");
        }
    }
}
