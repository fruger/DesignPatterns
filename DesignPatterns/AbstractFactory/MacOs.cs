namespace DesignPatterns.AbstractFactory;

public class MacOs : IAbstractFactory
{
    public IPc CreatePc()
    {
        return new MacOsPc();
    }

    public ILaptop CreateLaptop()
    {
        return new MacOsLaptop();
    }
}