namespace DesignPatterns.Decorator;

public class DataEncryption: Protection
{
    public DataEncryption(Computer computer) : base(computer)
    {
    }

    public override string TurnOn()
    {
        return $"Data Encryption({base.TurnOn()})";
    }
}