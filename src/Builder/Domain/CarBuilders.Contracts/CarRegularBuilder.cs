using Entities.Contracts;

namespace CarBuilders.Contracts
{
    public abstract class CarRegularBuilder
    {
        protected ICar _car;

        public virtual ICar GetCar()
        {
            return _car;
        }

        public abstract CarRegularBuilder BuildFrame();
        public abstract CarRegularBuilder InstallGearBox();
        public abstract CarRegularBuilder InstallWheels();
        public abstract CarRegularBuilder InstallBody();
        public abstract CarRegularBuilder InstallEngine();
    }
}
