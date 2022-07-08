// See https://aka.ms/new-console-template for more information

using DesignPatterns.FactoryMethod;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;

Console.WriteLine("----------Factory Method----------");
new FactoryMethodClient().Main();

Console.WriteLine("----------Abstract Factory----------");
new AbstractFactoryClient().Main();

Console.WriteLine("----------Builder----------");
new BuilderClient().Main();