namespace Entities.Contracts
{
    public interface ICar
    {
        string Type { get; }
        string Frame { get; set; }
        string GearBox { get; set; }
        string Wheels { get; set; }
        string Body { get; set; }
        string Engine { get; set; }
    }
}
