using Implementation.FactoryMethodAsHookForChildClasses.Engine;

namespace Implementation.FactoryMethodAsHookForChildClasses
{
    public class CarBase
    {
        public IEngine Engine { get; set; }

        public CarBase()
        {
            Engine = MakeEngine();
        }

        protected virtual IEngine MakeEngine()
        {
            return new RegularEngine();
        }
    }
}
