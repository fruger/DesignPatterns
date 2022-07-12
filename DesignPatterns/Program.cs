// See https://aka.ms/new-console-template for more information

using DesignPatterns.FactoryMethod;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Command;
using DesignPatterns.Decorator;

Console.WriteLine("----------Factory Method----------");
new FactoryMethodClient().Main();

Console.WriteLine("----------Abstract Factory----------");
new AbstractFactoryClient().Main();

Console.WriteLine("----------Builder----------");
new BuilderClient().Main();

Console.WriteLine("----------Decorator----------");
new DecoratorClient().Main();

Console.WriteLine("----------Command----------");
new CommandClient().Main();




