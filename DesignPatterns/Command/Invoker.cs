using System.Collections;

namespace DesignPatterns.Command;

public class Invoker
{
    private ArrayList objArrayList = new();

    public Invoker()
    {
        objArrayList.Add(new CalculationCommand());
        objArrayList.Add(new MusicCommand());
        objArrayList.Add(new WebBrowserCommand());
        objArrayList.Add(new PaintCommand());
    }

    public ICommand GetCommand(string command)
    {
        foreach (var obj in objArrayList)
        {
            ICommand objCommand = (ICommand)obj;
            if (objCommand.command == command)
            {
                return objCommand;
            }
        }

        return null!;
    }
}