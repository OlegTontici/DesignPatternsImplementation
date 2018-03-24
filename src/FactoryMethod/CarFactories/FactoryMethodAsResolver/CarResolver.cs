using Implementation.FactoryMethodAsResolver.Car;
using Sandbox.Contracts.FactoryMethodAsResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Implementation.FactoryMethodAsResolver
{
    public class CarResolver : ICarResolver
    {
        public IEnumerable<ICar> ResolveByPrice(double moneyAmount)
        {
            return Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i == typeof(ICar)))
                .Select(carType => Activator.CreateInstance(carType))
                .Cast<ICar>()
                .Where(car => car.Price <= moneyAmount);
        }

        public ICar ResolveByType(string type)
        {
            switch (type)
            {
                case "Coupe":
                    return new Coupe();
                case "SUV":
                    return new SUV();
                case "Truck":
                    return new Truck();
                default:
                    throw new ArgumentException($"{type} is not supported");
            }
        }
    }
}
