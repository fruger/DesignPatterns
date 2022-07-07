namespace DesignPatterns.FactoryMethod;

public class FactoryMethodClient
{
    public void Main()
    {
        ClientCode(new LaptopCreator());

        Console.WriteLine("");
        
        ClientCode(new PcCreator());
    }
    
    public void ClientCode(Creator creator)
    {
        Console.WriteLine("Client: I'm not aware of creator's class\n" + creator.Operation());
    }
}