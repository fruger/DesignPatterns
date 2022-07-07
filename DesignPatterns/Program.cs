// See https://aka.ms/new-console-template for more information

using DesignPatterns.FactoryMethod;
using DesignPatterns.AbstractFactory;

Console.WriteLine("----------Factory Method----------");
new FactoryMethodClient().Main();
Console.WriteLine("----------Abstract Factory----------");
new AbstractFactoryClient().Main();
