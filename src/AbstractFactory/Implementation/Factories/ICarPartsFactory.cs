using Implementation.Models.Engine;
using Implementation.Models.Windshield;

namespace Implementation.Factories
{
    public interface ICarPartsFactory
    {
        ICarEngine MakeEngine();
        ICarWindshield MakeWindshield();
    }
}
