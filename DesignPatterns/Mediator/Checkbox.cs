namespace DesignPatterns.Mediator;

public class Checkbox : BaseComponent
{
    public void Check()
    {
        Console.WriteLine("Check box is selected");
        
        _mediator.Notify(this, "Checked");
    }

    public void Uncheck()
    {
        Console.WriteLine("Check box isn't selected");
        
        _mediator.Notify(this, "Unchecked");
    }
}