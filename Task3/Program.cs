using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Road cityRoad = new Road(50, 2, 2);

        Vehicle car1 = new Vehicle("Car 1", 60, 4, VehicleType.Car);
        Vehicle truck1 = new Vehicle("Truck 1", 40, 6, VehicleType.Truck);
        Vehicle bus1 = new Vehicle("Bus 1", 50, 5, VehicleType.Bus);

        TrafficSimulator simulator = new TrafficSimulator();
        simulator.AddVehicle(car1);
        simulator.AddVehicle(truck1);
        simulator.AddVehicle(bus1);

        for (int i = 0; i < 5; i++)
        {
            simulator.SimulateTraffic(cityRoad);
        }
    }
}
