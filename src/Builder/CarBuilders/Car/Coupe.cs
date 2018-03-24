using Sandbox.Contracts;

namespace BuilderImplementation.Car
{
    public class Coupe : ICar
    {
        public string Frame { get; set; }
        public string GearBox { get; set ; }
        public string Wheels { get; set; }
        public string Body { get; set; }
        public string Engine { get; set; }
        public string Type { get => "Coupe"; }
    }
}
