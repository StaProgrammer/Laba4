using System;
public static class Program
{
    public static void Main()
    {
        Server server = new Server
        {
            IPAddress = "192.168.0.1",
            Power = 1000,
            OperatingSystem = "Windows Server",
            MaxConnections = 100
        };

        Workstation workstation = new Workstation
        {
            IPAddress = "192.168.0.2",
            Power = 500,
            OperatingSystem = "Windows 10",
            UserName = "User1"
        };

        Router router = new Router
        {
            IPAddress = "192.168.0.254",
            Power = 200,
            OperatingSystem = "Embedded OS"
        };

        Network network = new Network();
        network.AddComputer(server);
        network.AddComputer(workstation);
        network.AddComputer(router);

        network.Connect(server);
        network.Connect(workstation);
        network.Connect(router);

        network.TransmitData(workstation, server, "Hello, server!");

        network.Disconnect(router);
        network.Disconnect(server);
        network.Disconnect(workstation);
    }
}
