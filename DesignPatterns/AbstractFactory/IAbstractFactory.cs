namespace DesignPatterns.AbstractFactory;

public interface IAbstractFactory
{
    IPc CreatePc();
    ILaptop CreateLaptop();
}