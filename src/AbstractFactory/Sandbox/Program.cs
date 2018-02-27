﻿using Implementation;
using Implementation.Enums;
using Implementation.Factories;
using Sandbox.CarAssemblyLine;
using Sandbox.Models.Car;
using System;
using System.Linq;
using System.Reflection;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarPartsFactories carPartsFactories = new CarPartsFactories();
            ICarPartsFactory carPartsFactory = carPartsFactories.GetFactory(CarPartsFactoriesEnum.SUVPartsFactory);
            ICarAssemblyLine carAssemblyLine = new CarAssemblyLine.CarAssemblyLine(carPartsFactory);

            ICar car = carAssemblyLine.GetCar();

            Console.WriteLine($"Parts produced by : {carPartsFactory.GetType().Name} \nCilinders amount : {car.Engine.CilindersAmount}, engine volume : {car.Engine.Volume}");
            Console.ReadLine();
        }
    }
}