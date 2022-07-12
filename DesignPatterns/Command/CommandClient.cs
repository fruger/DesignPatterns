namespace DesignPatterns.Command;

public class CommandClient
{
    public void Main()
    {
        CheckAction("Music");
        CheckAction("Paint");
        CheckAction("Calculation");
        CheckAction("WebBrowser");
    }
    
    public void CheckAction(string action)
    {
        Invoker invoker = new();
        ICommand iCommand = invoker.GetCommand(action);
        iCommand.Execute();
    }
}