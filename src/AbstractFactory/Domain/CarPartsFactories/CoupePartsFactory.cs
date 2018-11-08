using Contracts;
using Contracts.CarPartsFactories;
using Entities.Engine;
using Entities.Windshield;

namespace CarPartsFactories
{
    internal class CoupePartsFactory : ICarPartsFactory
    {
        public ICarEngine MakeEngine()
        {
            return new CoupeEngine(2.0, 4);
        }

        public ICarWindshield MakeWindshield()
        {
            return new CoupeWindshield(1.8, 0.7, 0.3);
        }
    }
}
