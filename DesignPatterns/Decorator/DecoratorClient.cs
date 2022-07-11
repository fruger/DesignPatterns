namespace DesignPatterns.Decorator;

public class DecoratorClient
{
    public void ClientCode(Computer computer)
    {
        Console.WriteLine("Result: " + computer.TurnOn());
    }
}