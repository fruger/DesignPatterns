namespace DesignPatterns.AbstractFactory;

public class MacOsLaptop : ILaptop
{
    public string TurnOn()
    {
        return "Laptop with MacOs is turning on...";
    }

    public string CheckCompatibility(IPc collaborator)
    {
        var result = collaborator.TurnOn();

        return $"The result of the laptop with MacOs collaborating with the ({result})";
    }
}