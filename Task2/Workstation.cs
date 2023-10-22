public class Workstation : Computer
{
    public string UserName { get; set; }

    public void LogIn()
    {
        Console.WriteLine($"User {UserName} logged in.");
    }

    public void LogOut()
    {
        Console.WriteLine($"User {UserName} logged out.");
    }
}
