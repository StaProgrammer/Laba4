public class Server : Computer
{
    public int MaxConnections { get; set; }

    public void StartServer()
    {
        Console.WriteLine("Server started.");
    }

    public void StopServer()
    {
        Console.WriteLine("Server stopped.");
    }
}
