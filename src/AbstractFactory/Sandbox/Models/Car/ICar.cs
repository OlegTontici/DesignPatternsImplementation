using Implementation.Models.Engine;
using Implementation.Models.Windshield;

namespace Sandbox.Models.Car
{
    public interface ICar
    {
        ICarEngine Engine { get; set; }
        ICarWindshield Windshield { get; set; }
    }
}
