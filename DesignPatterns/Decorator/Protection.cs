namespace DesignPatterns.Decorator;

public abstract class Protection : Computer
{
    protected Computer _computer;

    public Protection(Computer computer)
    {
        _computer = computer;
    }

    public override string TurnOn()
    {
        if (_computer != null)
        {
            return _computer.TurnOn();
        }
        else
        {
            return string.Empty;
        }
    }
}