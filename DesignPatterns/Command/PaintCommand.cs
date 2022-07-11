namespace DesignPatterns.Command;

public class PaintCommand : ICommand
{
    public PaintCommand()
    {
        command = "Paint";
    }
    
    public override void Execute()
    {
        Console.WriteLine("Opening Paint");
    }
}