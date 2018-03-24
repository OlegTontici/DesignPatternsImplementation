using Implementation.Models.Engine;
using Implementation.Models.Windshield;
using Sandbox.Contracts;

namespace Implementation.Factories
{
    public class SUVPartsFactory : ICarPartsFactory
    {
        public ICarEngine MakeEngine()
        {
            return new SUVEngine(3.0, 4);
        }

        public ICarWindshield MakeWindshield()
        {
            return new SUVWindshield(1.8, 0.9, 0.4);
        }
    }
}
