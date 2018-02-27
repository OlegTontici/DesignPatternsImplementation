namespace Implementation.Models.Windshield
{
    class TruckWindshield : ICarWindshield
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Thickness { get; set; }

        public TruckWindshield(
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
