using BuilderImplementation.Car;

namespace BuilderImplementation.Builders
{
    public class CarBuilder
    {
        protected ICar _car;

        public virtual ICar GetCar()
        {
            return _car;
        }

        public virtual void BuildFrame()
        {

        }
        public virtual void InstallGearBox()
        {

        }
        public virtual void InstallWheels()
        {

        }
        public virtual void InstallBody()
        {

        }
        public virtual void InstallEngine()
        {

        }
    }
}
