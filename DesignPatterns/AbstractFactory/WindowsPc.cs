namespace DesignPatterns.AbstractFactory;

class WindowsPc : IPc
{
    public string TurnOn()
    {
        return "Pc with Windows is turning on...";
    }
}