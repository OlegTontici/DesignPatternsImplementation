namespace Sandbox.Contracts
{
    public class CarBuilderBase
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
