using Contracts;

namespace Entities.Windshield
{
    public class CoupeWindshield : ICarWindshield
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Thickness { get; private set; }

        public CoupeWindshield(
            double width,
            double height,
            double thickness)
        {
            Width = width;
            Height = height;
            Thickness = thickness;
        }

        public override string ToString()
        {
            return $"width : {Width} and thickness {Thickness}";
        }
    }
}
