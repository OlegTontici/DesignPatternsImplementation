using Sandbox.Contracts;

namespace Implementation.Models.Windshield
{
    public class CoupeWindshield : ICarWindshield
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Thickness { get; set; }

        public CoupeWindshield(
            double width,
            double height,
            double thickness)
        {
            Width = Width;
            Height = height;
            Thickness = thickness;
        }
    }
}
