using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Builder;

public class Technician
{
    private IComputerBuilder _computer = null!;

    public IComputerBuilder Computer
    {
        set { _computer = value; }
    }
    public void BuildMinimalPc()
    {
        _computer.AddProcessor();
        _computer.AddMotherboard();
    }

    public void BuildPremiumPc()
    {
        _computer.AddProcessor();
        _computer.AddMotherboard();
        _computer.AddGraphicsCard();
        _computer.AddHardDrive();
        _computer.AddBluetoothModule();
    }
}