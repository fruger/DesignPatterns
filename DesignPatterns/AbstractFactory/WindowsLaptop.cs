namespace DesignPatterns.AbstractFactory;

class WindowsLaptop : ILaptop
{
    public string TurnOn()
    {
        return "Laptop with Windows is turning on...";
    }

    public string CheckCompatibility(IPc collaborator)
    {
        var result = collaborator.TurnOn();

        return $"The result of the laptop with Windows collaborating with the ({result})";
    }
}