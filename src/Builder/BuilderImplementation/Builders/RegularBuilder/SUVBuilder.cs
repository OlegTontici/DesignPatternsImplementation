using BuilderImplementation.Car;
using Sandbox.Contracts;

namespace BuilderImplementation.Builders.RegularBuilder
{
    public class SUVBuilder : CarBuilderBase
    {
        public SUVBuilder()
        {
            _car = new SUV();
        }

        public override void BuildFrame()
        {
            _car.Frame = "Strong frame,because SUV is such a big car";
        }
        public override void InstallGearBox()
        {
            _car.GearBox = "7 steps,low rotation gearbox";
        }
        public override void InstallWheels()
        {
            _car.Wheels = "22 inches wheels";
        }
        public override void InstallBody()
        {
            _car.Body = "Lighweight alloy body";
        }
        public override void InstallEngine()
        {
            _car.Engine = "3.0l volume engine";
        }
    }
}
