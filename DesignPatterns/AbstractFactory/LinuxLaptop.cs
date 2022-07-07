namespace DesignPatterns.AbstractFactory;

public class LinuxLaptop : ILaptop
{
    public string TurnOn()
    {
        return "Laptop with Linux is turning on...";
    }

    public string CheckCompatibility(IPc collaborator)
    {
        var result = collaborator.TurnOn();

        return $"The result of the laptop with Linux collaborating with the ({result})";
    }
}