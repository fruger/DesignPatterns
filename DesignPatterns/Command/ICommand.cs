namespace DesignPatterns.Command;

public abstract class ICommand
{
    public string command = "";

    public virtual void Execute()
    {
    }
}