using Implementation.Enums;
using Implementation.Factories;

namespace Implementation
{
    public interface ICarPartsFactories
    {
        ICarPartsFactory GetFactory(string factoryName);
        ICarPartsFactory GetFactory(CarPartsFactoriesEnum factoryType);
    }
}
