namespace DesignPatterns.Command;

public class MusicCommand : ICommand
{
    public MusicCommand()
    {
        command = "Music";
    }
    
    public override void Execute()
    {
        Console.WriteLine("Playing music");
    }
}