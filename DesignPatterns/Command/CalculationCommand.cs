namespace DesignPatterns.Command;

public class CalculationCommand : ICommand
{
    public CalculationCommand()
    {
        command = "Calculation";
    }
    
    public override void Execute()
    {
        Console.WriteLine("Doing some calculations");
    }
}