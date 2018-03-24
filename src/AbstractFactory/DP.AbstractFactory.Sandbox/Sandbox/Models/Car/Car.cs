using Sandbox.Contracts;

namespace Sandbox.Models.Car
{
    public class Car : ICar
    {
        public ICarEngine Engine { get; set; }
        public ICarWindshield Windshield { get; set; }

        public Car(ICarEngine engine, ICarWindshield windshield)
        {
            Engine = engine;
            Windshield = windshield;
        }
    }
}
