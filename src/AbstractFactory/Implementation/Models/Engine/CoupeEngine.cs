namespace Implementation.Models.Engine
{
    public class CoupeEngine : ICarEngine
    {
        public double Volume { get; set; }
        public int CilindersAmount { get; set; }

        public CoupeEngine(double volume,int cilindersAmount)
        {
            Volume = volume;
            CilindersAmount = cilindersAmount;
        }
    }
}
