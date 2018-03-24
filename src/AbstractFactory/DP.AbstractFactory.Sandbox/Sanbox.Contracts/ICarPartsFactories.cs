using Sandbox.Contracts;

namespace Implementation
{
    public interface ICarPartsFactories
    {
        ICarPartsFactory GetFactory(string factoryName);
        ICarPartsFactory GetFactory(CarPartsFactoriesTypes factoryType);
    }
}
