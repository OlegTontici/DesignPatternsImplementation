namespace Contracts.CarPartsFactories
{
    public interface ICarPartsFactory
    {
        ICarEngine MakeEngine();
        ICarWindshield MakeWindshield();
    }
}
