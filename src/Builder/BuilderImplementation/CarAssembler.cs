using BuilderImplementation.Builders;
using BuilderImplementation.Car;

namespace BuilderImplementation
{
    public class CarAssembler
    {
        CarBuilder _carbuilder;

        public CarAssembler(CarBuilder carbuilder)
        {
            _carbuilder = carbuilder;
        }

        public ICar CreateCar()
        {
            _carbuilder.BuildFrame();
            _carbuilder.InstallGearBox();
            _carbuilder.InstallEngine();
            _carbuilder.InstallWheels();
            _carbuilder.InstallBody();


            // in this case it is ok to return car here,as created products belong to the same family
            // and if it is not the case - client code should retrieve product directly from builder
            return _carbuilder.GetCar();
        }
    }
}
