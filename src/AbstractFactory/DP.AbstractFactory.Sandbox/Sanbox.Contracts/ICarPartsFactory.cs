namespace Sandbox.Contracts
{
    public interface ICarPartsFactory
    {
        ICarEngine MakeEngine();
        ICarWindshield MakeWindshield();
    }
}
