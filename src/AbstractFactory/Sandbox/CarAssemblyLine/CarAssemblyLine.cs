using Implementation.Factories;
using Sandbox.Models.Car;

namespace Sandbox.CarAssemblyLine
{
    public class CarAssemblyLine : ICarAssemblyLine
    {
        private ICarPartsFactory _carPartsFactory;

        public CarAssemblyLine(ICarPartsFactory carPartsFactory)
        {
            _carPartsFactory = carPartsFactory;
        }

        public ICar GetCar()
        {
            return new Car(_carPartsFactory.MakeEngine(), _carPartsFactory.MakeWindshield());
        }
    }
}
