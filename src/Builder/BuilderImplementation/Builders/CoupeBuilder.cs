using BuilderImplementation.Car;

namespace BuilderImplementation.Builders
{
    public class CoupeBuilder : CarBuilder
    {
        public CoupeBuilder()
        {
            _car = new Coupe();
        }

        public override void BuildFrame()
        {
            _car.Frame = "Basic frame,used for most of the cars";
        }      
        public override void InstallGearBox()
        {
            _car.GearBox = "5 steps gearbox";
        }      
        public override void InstallWheels()
        {
            _car.Wheels = "17 inches wheels";
        }       
        public override void InstallBody()
        {
            _car.Body = "Lighweight alloy body";
        }      
        public override void InstallEngine()
        {
            _car.Engine = "1.4l volume engine";
        }
    }
}
