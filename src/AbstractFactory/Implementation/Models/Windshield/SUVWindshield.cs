namespace Implementation.Models.Windshield
{
    public class SUVWindshield : ICarWindshield
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Thickness { get; set; }

        public SUVWindshield(
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
