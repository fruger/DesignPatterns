namespace DesignPatterns.FactoryMethod;

public class Laptop : IComputer
{
    public string TurnOn()
    {
        return "Laptop is turning on...";
    }

    public string DoSomeOperation()
    {
        return "Laptop is doing some operations...";
    }
}