using CarBuilders.Contracts;
using Entities.Contracts;

namespace CarBuilders
{
    public class CarAssembler
    {
        CarRegularBuilder _carbuilder;

        public CarAssembler(CarRegularBuilder carbuilder)
        {
            _carbuilder = carbuilder;
        }

        public ICar CreateCar()
        {
            _carbuilder
                .BuildFrame()
                .InstallGearBox()
                .InstallEngine()
                .InstallWheels()
                .InstallBody();


            // in this case it is ok to return car here,as created products belong to the same family
            // and if it is not the case - client code should retrieve product directly from builder
            return _carbuilder.GetCar();
        }
    }
}
