﻿using Implementation.FactoryMethodAsHookForChildClasses.Engine;
using Sandbox.Contracts.FactoryMethodAsHookForChildClasses;

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
