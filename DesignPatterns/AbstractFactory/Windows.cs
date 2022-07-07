namespace DesignPatterns.AbstractFactory;

class Windows : IAbstractFactory
{
    public IPc CreatePc()
    {
        return new WindowsPc();
    }

    public ILaptop CreateLaptop()
    {
        return new WindowsLaptop();
    }
}