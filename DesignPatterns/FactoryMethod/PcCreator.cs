namespace DesignPatterns.FactoryMethod;

public class PcCreator : Creator
{
    public override IComputer FactoryMethod()
    {
        return new Pc();
    }
}