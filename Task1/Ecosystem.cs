using System;
using System.Collections.Generic;

public class Ecosystem
{
    public List<LivingOrganism> organisms;

    public Ecosystem()
    {
        organisms = new List<LivingOrganism>();
    }

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void SimulateEcosystem()
    {
        foreach (var organism in organisms)
        {
            organism.Energy -= 0.1;
            organism.Grow();
        }

        foreach (var predator in organisms)
        {
            if (predator is IPredator)
            {
                foreach (var target in organisms)
                {
                    if (target != predator)
                    {
                        ((IPredator)predator).Hunt(target);

                        if (predator is IReproducible && target is IReproducible)
                        {
                            if (predator.Energy > 50 && target.Energy > 50)
                            {
                                ((IReproducible)predator).Reproduce();
                                ((IReproducible)target).Reproduce();
                            }
                        }
                    }
                }
            }
        }
    }
}
