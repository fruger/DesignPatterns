namespace DesignPatterns.Command;

public class CommandClient
{
    public void CheckAction(string action)
    {
        Invoker invoker = new();
        ICommand iCommand = invoker.GetCommand(action);
        iCommand.Execute();
    }
}