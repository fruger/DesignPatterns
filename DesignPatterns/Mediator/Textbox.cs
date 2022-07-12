namespace DesignPatterns.Mediator;

public class Textbox : BaseComponent
{
    public void Display()
    {
        Console.WriteLine("Text box is displayed");
        
        _mediator.Notify(this, "Displayed");
    }

    public void Hide()
    {
        Console.WriteLine("Text box is hidden");
        
        _mediator.Notify(this, "Hidden");
    }
}