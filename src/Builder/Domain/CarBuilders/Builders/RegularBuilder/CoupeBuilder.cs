using CarBuilders.Contracts;
using Entities;

namespace CarBuilders.RegularBuilder
{
    public class CoupeBuilder : CarRegularBuilder
    {
        public CoupeBuilder()
        {
            _car = new Coupe();
        }

        public override CarRegularBuilder BuildFrame()
        {
            _car.Frame = "Basic frame,used for most of the cars";
            return this;
        }      
        public override CarRegularBuilder InstallGearBox()
        {
            _car.GearBox = "5 steps gearbox";
            return this;
        }      
        public override CarRegularBuilder InstallWheels()
        {
            _car.Wheels = "17 inches wheels";
            return this;
        }       
        public override CarRegularBuilder InstallBody()
        {
            _car.Body = "Lighweight alloy body";
            return this;
        }      
        public override CarRegularBuilder InstallEngine()
        {
            _car.Engine = "1.4l volume engine";
            return this;
        }
    }
}
