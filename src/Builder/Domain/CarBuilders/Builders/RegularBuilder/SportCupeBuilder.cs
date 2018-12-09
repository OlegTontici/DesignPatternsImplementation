using CarBuilders.Contracts;
using Entities;

namespace CarBuilders.RegularBuilder
{
    // different representation for 'Coupe'
    public class SportCoupeBuilder : CarRegularBuilder
    {
        public SportCoupeBuilder()
        {
            _car = new Coupe();
        }

        public override CarRegularBuilder BuildFrame()
        {
            _car.Frame = "Armored frame,because its sport car,and safety is a must";
            return this;
        }
        public override CarRegularBuilder InstallGearBox()
        {
            _car.GearBox = "7 steps,very fast  gearbox";
            return this;
        }
        public override CarRegularBuilder InstallWheels()
        {
            _car.Wheels = "19 inches wheels";
            return this;
        }
        public override CarRegularBuilder InstallBody()
        {
            _car.Body = "Carbon fiber body";
            return this;
        }
        public override CarRegularBuilder InstallEngine()
        {
            _car.Engine = "4.0 l volume engine";
            return this;
        }
    }
}
