using Entities.Contracts;

namespace CarBuilders.Contracts
{
    public interface ICarPredifinedSequenceBuilder
    {
        IWheelsMount MountTheFrame();
    }

    public interface CarPredifinedSequenceBuilder : 
        ICarPredifinedSequenceBuilder, 
        IWheelsMount,
        IGearBoxMount,
        IBodyMount,
        IEngineMount,
        IFinalizer
    {

    }

    public interface IWheelsMount
    {
        IGearBoxMount MountWheels();
    }

    public interface IGearBoxMount
    {
        IBodyMount MountGearBox();
    }

    public interface IBodyMount
    {
        IEngineMount MountBody();
    }

    public interface IEngineMount
    {
        IFinalizer MountEngine(decimal volume);
    }

    public interface IFinalizer
    {
        ICar GetCar();
    }
}
