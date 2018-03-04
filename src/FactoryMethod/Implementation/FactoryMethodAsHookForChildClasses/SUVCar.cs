using Implementation.FactoryMethodAsHookForChildClasses.Engine;

namespace Implementation.FactoryMethodAsHookForChildClasses
{
    public class SUVCar : CarBase
    {
        protected override IEngine MakeEngine()
        {
            return new V8Engine();
        }
    }
}
