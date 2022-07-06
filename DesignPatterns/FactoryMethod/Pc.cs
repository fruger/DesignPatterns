namespace DesignPatterns.FactoryMethod;

public class Pc : IComputer
{
    public string TurnOn()
    {
        return "Pc is turning on...";
    }

    public string DoSomeOperation()
    {
        return "Pc is doing some operations...";
    }
}