public class Network : IConnectable
{
    private List<Computer> computers = new List<Computer>();

    public void AddComputer(Computer computer)
    {
        computers.Add(computer);
    }

    public void Connect(Computer computer)
    {
        foreach (Computer c in computers)
        {
            if (c != computer)
            {
                Console.WriteLine($"{computer.IPAddress} connected to {c.IPAddress}.");
            }
        }
    }

    public void Disconnect(Computer computer)
    {
        foreach (Computer c in computers)
        {
            if (c != computer)
            {
                Console.WriteLine($"{computer.IPAddress} disconnected from {c.IPAddress}.");
            }
        }
    }

    public void TransmitData(Computer source, Computer destination, string data)
    {
        Console.WriteLine($"Transmitting data from {source.IPAddress} to {destination.IPAddress}: {data}");
    }
}
