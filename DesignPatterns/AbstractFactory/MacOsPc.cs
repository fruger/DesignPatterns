namespace DesignPatterns.AbstractFactory;

public class MacOsPc : IPc
{
    public string TurnOn()
    {
        return "Pc with MacOs is turning on...";
    }
}