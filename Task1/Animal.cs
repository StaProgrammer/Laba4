using System;

public class Animal : LivingOrganism, IPredator, IReproducible
{
    public bool CanHunt { get; set; }
    public bool CanReproduce { get; set; }

    public Animal(double energy, int age, double size, bool canHunt, bool canReproduce)
        : base(energy, age, size)
    {
        CanHunt = canHunt;
        CanReproduce = canReproduce;
    }

    public void Hunt(LivingOrganism target)
    {
        if (CanHunt)
        {
            if (target is Animal animalTarget)
            {
                double energyGain = animalTarget.Energy * 0.5;
                Energy += energyGain;
                animalTarget.Energy -= energyGain;
            }
            else if (target is Plant plantTarget)
            {
                double energyGain = plantTarget.Energy * 0.7;
                Energy += energyGain;
                plantTarget.Energy -= energyGain;
            }
            else if (target is Microorganism microorganismTarget)
            {
                double energyGain = microorganismTarget.Energy * 0.3;
                Energy += energyGain;
                microorganismTarget.Energy -= energyGain;
            }
        }
    }

    public void Reproduce()
    {
        if (CanReproduce)
        {
            double energyLoss = Energy * 0.2;
            Energy -= energyLoss;
            Animal child = new Animal(energyLoss, 0, 0.1, true, true);
        }
    }
}
