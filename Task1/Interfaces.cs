public interface IReproducible
{
    void Reproduce();
}

public interface IPredator
{
    void Hunt(LivingOrganism target);
}