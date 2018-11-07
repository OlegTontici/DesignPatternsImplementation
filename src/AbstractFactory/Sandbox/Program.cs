using CarPartsFactories;
using Contracts.CarPartsFactories;
using Sandbox.CarAssemblyLine;
using Sandbox.Models.Car;
using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarPartsFactories carPartsFactories = new CarPartsFactory();
            ICarPartsFactory carPartsFactory = carPartsFactories.GetFactory(CarPartsFactoriesTypes.TruckPartsFactory);
            ICarAssemblyLine carAssemblyLine = new CarAssemblyLine.CarAssemblyLine(carPartsFactory);

            ICar car = carAssemblyLine.GetCar();

            Console.WriteLine($"Parts produced by : {carPartsFactory.GetType().Name} \nEngine info: {car.Engine.ToString()} \nWindshield Info: {car.Windshield.ToString()}");
            Console.ReadLine();
        }
    }
}
