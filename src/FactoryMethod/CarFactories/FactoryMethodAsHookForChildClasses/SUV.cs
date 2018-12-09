using Implementation.FactoryMethodAsHookForChildClasses.Engine;
using Sandbox.Contracts.FactoryMethodAsHookForChildClasses;

namespace Implementation.FactoryMethodAsHookForChildClasses
{
    public class SUV : Car
    {
        protected override IEngine MakeEngine()
        {
            return new V8Engine();
        }
    }
} 
