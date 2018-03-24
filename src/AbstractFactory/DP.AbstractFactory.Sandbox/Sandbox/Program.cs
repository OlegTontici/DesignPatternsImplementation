using Implementation;
using Sandbox.CarAssemblyLine;
using Sandbox.Contracts;
using Sandbox.Models.Car;
using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarPartsFactories carPartsFactories = new CarPartsFactories();
            ICarPartsFactory carPartsFactory = carPartsFactories.GetFactory("CoupePartsFactory");
            ICarAssemblyLine carAssemblyLine = new CarAssemblyLine.CarAssemblyLine(carPartsFactory);

            ICar car = carAssemblyLine.GetCar();

            Console.WriteLine($"Parts produced by : {carPartsFactory.GetType().Name} \nCilinders amount : {car.Engine.CilindersAmount}, engine volume : {car.Engine.Volume}");
            Console.ReadLine();
        }
    }
}
