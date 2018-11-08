using Contracts;
using Contracts.CarPartsFactories;
using Entities.Engine;
using Entities.Windshield;

namespace CarPartsFactories
{
    internal class TruckPartsFactory : ICarPartsFactory
    {
        public ICarEngine MakeEngine()
        {
            return new TruckEngine(12.0, 10);
        }

        public ICarWindshield MakeWindshield()
        {
            return new TruckWindshield(2.6, 1.2, 0.4);
        }
    }
}
