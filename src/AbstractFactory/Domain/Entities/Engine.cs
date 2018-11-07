using Contracts;

namespace Entities
{
    public class Engine : ICarEngine
    {
        public double Volume { get; private set; }
        public int CilindersAmount { get; private set; }

        public Engine(double volume, int cilindersAmount)
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
