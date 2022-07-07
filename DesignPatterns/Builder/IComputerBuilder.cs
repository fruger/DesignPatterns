namespace DesignPatterns.Builder;

public interface IComputerBuilder
{
    void AddProcessor();
    void AddGraphicsCard();
    void AddMotherboard();
    void AddHardDrive();
}