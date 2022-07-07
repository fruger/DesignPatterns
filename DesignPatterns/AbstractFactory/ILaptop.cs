namespace DesignPatterns.AbstractFactory;

public interface ILaptop
{
    string TurnOn();
    string CheckCompatibility(IPc collaborator);
}