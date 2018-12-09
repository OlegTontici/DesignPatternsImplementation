using Implementation.FactoryMethodAsHookForChildClasses.Engine;
using Sandbox.Contracts.FactoryMethodAsHookForChildClasses;

namespace Implementation.FactoryMethodAsHookForChildClasses
{
    public class Car : ICar
    {
        public IEngine Engine { get; set; }

        public Car()
        {
            Engine = MakeEngine();
        }

        protected virtual IEngine MakeEngine()
        {
            return new RegularEngine();
        }
    }
}
