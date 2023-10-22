public class Router : Computer
{
    public List<Computer> ConnectedComputers { get; } = new List<Computer>();

    public void Connect(Computer computer)
    {
        ConnectedComputers.Add(computer);
        Console.WriteLine($"{computer.IPAddress} connected to the router.");
    }

    public void Disconnect(Computer computer)
    {
        ConnectedComputers.Remove(computer);
        Console.WriteLine($"{computer.IPAddress} disconnected from the router.");
    }
}