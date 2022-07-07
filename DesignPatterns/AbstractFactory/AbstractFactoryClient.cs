namespace DesignPatterns.AbstractFactory;

public class AbstractFactoryClient
{
    public void Main()
    {
        Console.WriteLine("Client: Testing client code with the first factory type:");
        ClientMethod(new Windows());
        
        Console.WriteLine("Client: Testing client code with the second factory type:");
        ClientMethod(new Linux());
        
        Console.WriteLine("Client: Testing client code with the third factory type:");
        ClientMethod(new MacOs());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var pc = factory.CreatePc();
        var laptop = factory.CreateLaptop();

        Console.WriteLine(pc.TurnOn());
        Console.WriteLine(laptop.CheckCompatibility(pc));
    }
}