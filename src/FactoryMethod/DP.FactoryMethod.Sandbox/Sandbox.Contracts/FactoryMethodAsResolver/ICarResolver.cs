using System.Collections.Generic;

namespace Sandbox.Contracts.FactoryMethodAsResolver
{
    public interface ICarResolver
    {
        IEnumerable<ICar> ResolveByPrice(double moneyAmount);
        ICar ResolveByType(string type);
    }
}
