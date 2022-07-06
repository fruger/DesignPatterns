namespace DesignPatterns.FactoryMethod;

public abstract class Creator
{
    public abstract IComputer FactoryMethod();

    public string Operation()
    {
        var computer = FactoryMethod();
        
        var result = ($"{computer.TurnOn()} \n{computer.DoSomeOperation()}");

        return result;
    }
}