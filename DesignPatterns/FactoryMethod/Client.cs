namespace DesignPatterns.FactoryMethod;

public class Client
{
    public void Main()
    {
        ClientCode(new LaptopCreator());

        Console.WriteLine("");
        
        ClientCode(new PcCreator());
    }
    
    public void ClientCode(Creator creator)
    {
        Console.WriteLine("Klient: (nie widzi klas kreatorów)\n" + creator.Operation());
    }
}