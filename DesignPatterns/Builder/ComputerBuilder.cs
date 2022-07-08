namespace DesignPatterns.Builder;

public class ComputerBuilder: IComputerBuilder
{
    private Computer _computer = new Computer();

    public ComputerBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _computer = new Computer();
    }
    
    public void AddProcessor()
    {
        _computer.Add("Processor");
    }

    public void AddGraphicsCard()
    {
        _computer.Add("Graphics card");
    }

    public void AddMotherboard()
    {
        _computer.Add("Motherboard");
    }

    public void AddHardDrive()
    {
        _computer.Add("Hard drive");
    }
    
    public void AddBluetoothModule()
    {
        _computer.Add("Bluetooth module");
    }

    public Computer GetProduct()
    {
        Computer result = _computer;
        
        Reset();

        return result;
    }
}