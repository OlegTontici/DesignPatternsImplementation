using Implementation.Enums;
using Implementation.Factories;
using System;
using System.Linq;
using System.Reflection;

namespace Implementation
{
    public class CarPartsFactories : ICarPartsFactories
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

        public ICarPartsFactory GetFactory(CarPartsFactoriesEnum factoryType)
        {
            ICarPartsFactory carPartsFactory;
            switch (factoryType)
            {
                case CarPartsFactoriesEnum.CoupePartsFactory:
                    carPartsFactory = new CoupePartsFactory();
                    break;
                case CarPartsFactoriesEnum.SUVPartsFactory:
                    carPartsFactory = new SUVPartsFactory();
                    break;
                case CarPartsFactoriesEnum.TruckPartsFactory:
                    carPartsFactory = new TruckPartsFactory();
                    break;
                default:
                    throw new ArgumentException("Unsuported factory type");
            }

            return carPartsFactory;
        }
    }
}
