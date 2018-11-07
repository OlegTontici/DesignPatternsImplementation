namespace Contracts.CarPartsFactories
{
    public interface ICarPartsFactories
    {
        ICarPartsFactory GetFactory(string factoryName);
        ICarPartsFactory GetFactory(CarPartsFactoriesTypes factoryType);
    }
}
