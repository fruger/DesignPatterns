// See https://aka.ms/new-console-template for more information

using DesignPatterns.FactoryMethod;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;

Console.WriteLine("----------Factory Method----------");
new FactoryMethodClient().Main();

Console.WriteLine("----------Abstract Factory----------");
new AbstractFactoryClient().Main();

Console.WriteLine("----------Builder----------");
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