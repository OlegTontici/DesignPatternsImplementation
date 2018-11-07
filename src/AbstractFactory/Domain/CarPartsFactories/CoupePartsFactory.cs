using Contracts;
using Contracts.CarPartsFactories;
using Entities;

namespace CarPartsFactories
{
    internal class CoupePartsFactory : ICarPartsFactory
    {
        public ICarEngine MakeEngine()
        {
            return new Engine(2.0, 4);
        }

        public ICarWindshield MakeWindshield()
        {
            return new Windshield(1.8, 0.7, 0.3);
        }
    }
}
