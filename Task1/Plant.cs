using System;

public class Plant : LivingOrganism, IReproducible
{
    public bool CanReproduce { get; set; }

    public Plant(double energy, int age, double size, bool canReproduce)
        : base(energy, age, size)
    {
        CanReproduce = canReproduce;
    }

    public void Reproduce()
    {
        if (CanReproduce)
        {
            double energyLoss = Energy * 0.1;
            Energy -= energyLoss;
            Plant child = new Plant(energyLoss, 0, 0.05, true);
        }
    }
}
