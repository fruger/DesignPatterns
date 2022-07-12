namespace DesignPatterns.Mediator;

public class MediatorClient
{
    public void Main()
    {
        Checkbox checkbox = new();
        Textbox textbox = new();
        
        new ConcreteMediator(checkbox, textbox);
        Console.WriteLine("Client selects the check box");
        checkbox.Check();

        Console.WriteLine();

        Console.WriteLine("Client deselects the check box");
        checkbox.Uncheck();
    }
}