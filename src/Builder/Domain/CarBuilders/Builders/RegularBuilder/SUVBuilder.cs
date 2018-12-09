using CarBuilders.Contracts;
using Entities;

namespace CarBuilders.RegularBuilder
{
    public class SUVBuilder : CarRegularBuilder
    {
        public SUVBuilder()
        {
            _car = new SUV();
        }

        public override CarRegularBuilder BuildFrame()
        {
            _car.Frame = "Strong frame,because SUV is such a big car";
            return this;
        }
        public override CarRegularBuilder InstallGearBox()
        {
            _car.GearBox = "7 steps,low rotation gearbox";
            return this;
        }
        public override CarRegularBuilder InstallWheels()
        {
            _car.Wheels = "22 inches wheels";
            return this;
        }
        public override CarRegularBuilder InstallBody()
        {
            _car.Body = "Lighweight alloy body";
            return this;
        }
        public override CarRegularBuilder InstallEngine()
        {
            _car.Engine = "3.0l volume engine";
            return this;
        }
    }
}
