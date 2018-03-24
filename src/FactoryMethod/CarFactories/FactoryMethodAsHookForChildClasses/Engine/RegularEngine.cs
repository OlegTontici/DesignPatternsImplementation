using Sandbox.Contracts.FactoryMethodAsHookForChildClasses;

namespace Implementation.FactoryMethodAsHookForChildClasses.Engine
{
    public class RegularEngine : IEngine
    {
        public double Volume { get; }
        public int CilindersAmount { get; }

        public RegularEngine()
        {
            Volume = 1.2;
            CilindersAmount = 4;
        }
    }
}
