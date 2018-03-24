using Sandbox.Contracts.FactoryMethodAsHookForChildClasses;

namespace Implementation.FactoryMethodAsHookForChildClasses.Engine
{
    public class V8Engine : IEngine
    {
        public double Volume { get; }
        public int CilindersAmount { get; }

        public V8Engine()
        {
            Volume = 3.0;
            CilindersAmount = 8;
        }
    }
}
