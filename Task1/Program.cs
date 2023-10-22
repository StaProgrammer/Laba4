public class Program
{
    static void Main()
    {
        Ecosystem ecosystem = new Ecosystem();

        Animal lion = new Animal(100, 5, 1.5, true, true);
        Animal zebra = new Animal(80, 3, 1.2, true, true);
        Plant grass = new Plant(50, 2, 0.5, true);

        ecosystem.AddOrganism(lion);
        ecosystem.AddOrganism(zebra);
        ecosystem.AddOrganism(grass);

        for (int year = 1; year <= 5; year++)
        {
            Console.WriteLine($"Year {year}");
            ecosystem.SimulateEcosystem();

            foreach (var organism in ecosystem.organisms)
            {
                Console.WriteLine($"Type: {organism.GetType().Name}, Energy: {organism.Energy}, Age: {organism.Age}");
            }
        }
    }
}
