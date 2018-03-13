using System;
using BuilderImplementation.Car;

namespace BuilderImplementation.Builders.PredifinedSequence
{
    public class SequencialCarBuilder : CarBuilder
    {
        private ICar _car;

        public SequencialCarBuilder()
        {
            _car = new SUV();
        }

        public ICar GetCar()
        {
            return _car;
        }

        public IEngineMount MountBody()
        {
            _car.Body = "What a car without a body";
            return this;
        }

        public IFinalizer MountEngine(decimal volume)
        {
            _car.Engine = $"Engine with volume : {volume} litters";
            return this;
        }

        public IBodyMount MountGearBox()
        {
            _car.GearBox = "Gearbox";
            return this;
        }

        public IWheelsMount MountTheFrame()
        {
            _car.Frame = "First of all - the frame.Try to build the car without it,huh?";
            return this;
        }

        public IGearBoxMount MountWheels()
        {
            _car.Wheels = "4 Wheels...of may be 3 :D";
            return this;
        }
    }
}
