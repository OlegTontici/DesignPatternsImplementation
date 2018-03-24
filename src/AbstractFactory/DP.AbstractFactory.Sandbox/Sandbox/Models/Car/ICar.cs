using Sandbox.Contracts;

namespace Sandbox.Models.Car
{
    public interface ICar
    {
        ICarEngine Engine { get; set; }
        ICarWindshield Windshield { get; set; }
    }
}
