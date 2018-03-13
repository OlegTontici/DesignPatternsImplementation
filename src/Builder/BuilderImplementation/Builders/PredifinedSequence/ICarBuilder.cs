using BuilderImplementation.Car;

namespace BuilderImplementation.Builders.PredifinedSequence
{
    public interface ICarBuilder
    {
        IWheelsMount MountTheFrame();
    }

    public interface CarBuilder : 
        ICarBuilder, 
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
