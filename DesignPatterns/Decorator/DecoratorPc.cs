namespace DesignPatterns.Decorator;

public class DecoratorPc : Computer
{
    public override string TurnOn()
    {
        return "Pc is turning on";
    }
}