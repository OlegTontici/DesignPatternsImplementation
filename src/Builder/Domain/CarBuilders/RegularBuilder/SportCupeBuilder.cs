﻿using BuilderImplementation.Car;
using Sandbox.Contracts;

namespace CarBuilders.RegularBuilder
{
    // different representation for 'Coupe'
    public class SportCoupeBuilder : CarBuilderBase
    {
        public SportCoupeBuilder()
        {
            _car = new Coupe();
        }

        public override void BuildFrame()
        {
            _car.Frame = "Armored frame,because its sport car,and safety is a must";
        }
        public override void InstallGearBox()
        {
            _car.GearBox = "7 steps,very fast  gearbox";
        }
        public override void InstallWheels()
        {
            _car.Wheels = "19 inches wheels";
        }
        public override void InstallBody()
        {
            _car.Body = "Carbon fiber body";
        }
        public override void InstallEngine()
        {
            _car.Engine = "4.0 l volume engine";
        }
    }
}
