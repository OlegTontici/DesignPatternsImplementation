using Contracts;
using Contracts.CarPartsFactories;
using Entities;

namespace CarPartsFactories
{
    internal class SUVPartsFactory : ICarPartsFactory
    {
        public ICarEngine MakeEngine()
        {
            return new Engine(3.0, 4);
        }

        public ICarWindshield MakeWindshield()
        {
            return new Windshield(1.8, 0.9, 0.4);
        }
    }
}
