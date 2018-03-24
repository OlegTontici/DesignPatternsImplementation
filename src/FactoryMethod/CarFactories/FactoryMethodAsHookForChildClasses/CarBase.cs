using Implementation.FactoryMethodAsHookForChildClasses.Engine;
using Sandbox.Contracts.FactoryMethodAsHookForChildClasses;

namespace Implementation.FactoryMethodAsHookForChildClasses
{
    public class CarBase : ICar
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
