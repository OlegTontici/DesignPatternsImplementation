using CarBuilders;
using CarBuilders.Contracts;
using CarBuilders.PredifinedSequence;
using CarBuilders.RegularBuilder;
using Entities.Contracts;
using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRegularBuilder carBuilder = new CoupeBuilder();
            CarAssembler carAssembler = new CarAssembler(carBuilder);

            // in this case it is ok to get the product from assembler,as created products belong to the same family
            // and if it is not the case - client code should retrieve product directly from builder
            // ex. : carBuilder.GetCar();
            ICar car = carAssembler.CreateCar();
            PrintCarInfo(car);

            // build the car using predefined sequence of steps.
            // This way we can ensure product is not returned in an invalid state(without wheels for exampe).
            ICarPredifinedSequenceBuilder sequencialCarBuilder = new SequencialCarBuilder();
            var theCar = sequencialCarBuilder
                .MountTheFrame()
                .MountWheels()
                .MountGearBox()
                .MountBody()
                .MountEngine(3.2m)
                .GetCar();

            Console.WriteLine("\n");

            PrintCarInfo(theCar);

            Console.ReadLine();
        }

        static void PrintCarInfo(ICar car)
        {
            Console.WriteLine($"Type : {car.Type}\nFrame : {car.Frame}\nBody : {car.Body}\nEngine : {car.Engine}\nGearBox : {car.GearBox}\nWheels : {car.Wheels}");
        }
    }
}
 