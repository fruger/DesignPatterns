namespace DesignPatterns.Builder;

public class BuilderClient
{
    public void Main()
    {
        var technician = new Technician();
        var computerBuilder = new ComputerBuilder();
        technician.Computer = computerBuilder;

        Console.WriteLine("Computer with minimal equipment:");
        technician.BuildMinimalPc();
        Console.WriteLine(computerBuilder.GetProduct().ListParts());

        Console.WriteLine("Computer with premium equipment:");
        technician.BuildPremiumPc();
        Console.WriteLine(computerBuilder.GetProduct().ListParts());

        Console.WriteLine("Custom computer:");
        computerBuilder.AddProcessor();
        computerBuilder.AddMotherboard();
        computerBuilder.AddHardDrive();
        Console.WriteLine(computerBuilder.GetProduct().ListParts());
    }
}