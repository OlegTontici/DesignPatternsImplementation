using Implementation.FactoryMethodAsHookForChildClasses;
using Implementation.FactoryMethodAsResolver;
using Sandbox.Contracts.FactoryMethodAsResolver;
using System;
using System.Collections;

namespace Sandbox
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Hook(intervention point) for child classes example
            Contracts.FactoryMethodAsHookForChildClasses.ICar car = new SUVCar();
            Console.WriteLine($"Engine volume :{car.Engine.Volume} \nEngine cilinders amount:{car.Engine.CilindersAmount}");

            // Resolver example
            ICarResolver carResolver = new CarResolver();
            double targetPrice = 30000;
            IEnumerable cars = carResolver.ResolveByPrice(targetPrice);

            Console.Write($"\nCars under {targetPrice} : ");
            foreach (var c in cars)
            {
                Console.Write($"{c.GetType().Name},");
            }

            string targetType = "Truck";
            ICar carByType = carResolver.ResolveByType(targetType);
            Console.WriteLine($"\nType of the car resolved for '{targetType}' : {carByType.GetType()}");


            Console.ReadLine();
        }
    }
}
