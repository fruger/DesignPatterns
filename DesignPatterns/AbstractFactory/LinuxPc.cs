namespace DesignPatterns.AbstractFactory;

public class LinuxPc : IPc
{
    public string TurnOn()
    {
        return "Pc with Linux is turning on...";
    }
}