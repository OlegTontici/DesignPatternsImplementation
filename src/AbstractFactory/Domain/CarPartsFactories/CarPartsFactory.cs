using Contracts.CarPartsFactories;
using System;
using System.Linq;
using System.Reflection;

namespace CarPartsFactories
{
    public class CarPartsFactory : ICarPartsFactories
    {
        public ICarPartsFactory GetFactory(string factoryName)
        {
            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.GetInterfaces().Any(i => i == typeof(ICarPartsFactory)) && t.Name == factoryName);

            if (type != null)
            {
                return Activator.CreateInstance(type) as ICarPartsFactory;
            }

            throw new ArgumentException($"'{factoryName}' type does not exist");
        }

        public ICarPartsFactory GetFactory(CarType carType)
        {
            ICarPartsFactory carPartsFactory;
            switch (carType)
            {
                case CarType.Coupe:
                    carPartsFactory = new CoupePartsFactory();
                    break;
                case CarType.SUV:
                    carPartsFactory = new SUVPartsFactory();
                    break;
                case CarType.Truck:
                    carPartsFactory = new TruckPartsFactory();
                    break;
                default:
                    throw new ArgumentException("Unsuported factory type");
            }

            return carPartsFactory;
        }
    }
}
