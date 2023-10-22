using System;

public class Microorganism : LivingOrganism, IReproducible
{
    public bool CanReproduce { get; set; }

    public Microorganism(double energy, int age, double size, bool canReproduce)
        : base(energy, age, size)
    {
        CanReproduce = canReproduce;
    }

    public void Reproduce()
    {
        if (CanReproduce)
        {
            double energyLoss = Energy * 0.05;
            Energy -= energyLoss;
            Microorganism child = new Microorganism(energyLoss, 0, 0.01, true);
        }
    }
}
