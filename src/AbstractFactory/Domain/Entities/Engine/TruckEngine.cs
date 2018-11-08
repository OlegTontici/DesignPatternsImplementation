using Contracts;

namespace Entities.Engine
{
    public class TruckEngine : ICarEngine
    {
        public double Volume { get; private set; }
        public int CilindersAmount { get; private set; }

        public TruckEngine(double volume, int cilindersAmount)
        {
            Volume = volume;
            CilindersAmount = cilindersAmount;
        }

        public override string ToString()
        {
            return $"Volume : {Volume} , Cilinders amount : {CilindersAmount}";
        }
    }
}
