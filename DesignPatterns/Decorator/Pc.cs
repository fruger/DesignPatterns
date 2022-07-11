namespace DesignPatterns.Decorator;

public class Pc : Computer
{
    public override string TurnOn()
    {
        return "Pc is turning on...";
    }
}