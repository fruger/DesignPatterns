namespace DesignPatterns.Decorator;

public class DecoratorClient
{
    public void Main()
    {
        var simple = new DecoratorPc();
        ClientCode(simple);
        Console.WriteLine();

        Firewall firewall = new(simple);
        DataEncryption dataEncryption = new(firewall);
        Console.WriteLine("Client: Now I've got a protected Pc:");
        ClientCode(dataEncryption);
    }
    
    public void ClientCode(Computer computer)
    {
        Console.WriteLine("Result: " + computer.TurnOn());
    }
}