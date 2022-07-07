namespace DesignPatterns.AbstractFactory;

public class Linux : IAbstractFactory
{
    public IPc CreatePc()
    {
        return new LinuxPc();
    }

    public ILaptop CreateLaptop()
    {
        return new LinuxLaptop();
    }
}