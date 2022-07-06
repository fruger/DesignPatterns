namespace DesignPatterns.FactoryMethod;

public class LaptopCreator : Creator
{
    public override IComputer FactoryMethod()
    {
        return new Laptop();
    }
}