namespace DesignPatterns.Mediator;

public class ConcreteMediator : IMediator
{
    private Checkbox _checkbox;
    private Textbox _textbox;

    public ConcreteMediator(Checkbox checkbox, Textbox textbox)
    {
        _checkbox = checkbox;
        _checkbox.SetMediator(this);
        _textbox = textbox;
        _textbox.SetMediator(this);
    }
    
    public void Notify(object sender, string action)
    {
        if (action == "Checked")
        {
            Console.WriteLine("Mediator reacts and triggers following operations");
            _textbox.Display();
        }
        if (action == "Unchecked")
        {
            Console.WriteLine("Mediator reacts and triggers following operations");
            _textbox.Hide();
        }
    }
}