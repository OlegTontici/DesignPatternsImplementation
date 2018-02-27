using Implementation.Models.Engine;
using Implementation.Models.Windshield;

namespace Implementation.Factories
{
    class TruckPartsFactory : ICarPartsFactory
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
