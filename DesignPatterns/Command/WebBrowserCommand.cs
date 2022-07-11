namespace DesignPatterns.Command;
public class WebBrowserCommand : ICommand
{
    public WebBrowserCommand()
    {
        command = "WebBrowser";
    }
    
    public override void Execute()
    {
        Console.WriteLine("Opening web browser");
    }
}