namespace DesignPatterns.Decorator;

public class Firewall: Protection
{
    public Firewall(Computer computer) : base(computer)
    {
    }

    public override string TurnOn()
    {
        return $"Firewall({base.TurnOn()})";
    }
}