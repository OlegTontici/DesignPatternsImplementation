using Sandbox.Contracts;

namespace Implementation.Models.Engine
{
    class TruckEngine : ICarEngine
    {
        public double Volume { get; set; }
        public int CilindersAmount { get; set; }

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
