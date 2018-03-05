using BuilderImplementation;
using BuilderImplementation.Builders;
using BuilderImplementation.Car;
using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder carBuilder = new SportCupeBuilder();
            CarAssembler carAssembler = new CarAssembler(carBuilder);

            // in this case it is ok to get the product from assembler,as created products belong to the same family
            // and if it is not the case - client code should retrieve product directly from builder
            // ex. : carBuilder.GetCar();
            ICar car = carAssembler.CreateCar();
            Console.WriteLine($"Type : {car.Type}\nFrame : {car.Frame}\nBody : {car.Body}\nEngine : {car.Engine}\nGearBox : {car.GearBox}\nWheels : {car.Wheels}");
            Console.ReadLine();
        }
    }
}
 