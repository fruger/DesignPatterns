// See https://aka.ms/new-console-template for more information

using DesignPatterns.FactoryMethod;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Decorator;

Console.WriteLine("----------Factory Method----------");
new FactoryMethodClient().Main();

Console.WriteLine("----------Abstract Factory----------");
new AbstractFactoryClient().Main();

Console.WriteLine("----------Builder----------");
new BuilderClient().Main();

Console.WriteLine("----------Decorator----------");
DecoratorClient decoratorClient = new();

var simple = new DecoratorPc();
decoratorClient.ClientCode(simple);
Console.WriteLine();

Firewall firewall = new(simple);
DataEncryption dataEncryption = new(firewall);
Console.WriteLine("Client: Now I've got a protected Pc:");
decoratorClient.ClientCode(dataEncryption);

