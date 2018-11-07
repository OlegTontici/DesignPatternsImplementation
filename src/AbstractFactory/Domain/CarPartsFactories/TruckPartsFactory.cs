using Contracts;
using Contracts.CarPartsFactories;
using Entities;

namespace CarPartsFactories
{
    internal class TruckPartsFactory : ICarPartsFactory
    {
        public ICarEngine MakeEngine()
        {
            return new Engine(12.0, 10);
        }

        public ICarWindshield MakeWindshield()
        {
            return new Windshield(2.6, 1.2, 0.4);
        }
    }
}
