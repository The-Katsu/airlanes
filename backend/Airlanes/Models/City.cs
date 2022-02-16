namespace Airlanes.Models
{
    public class City : BaseEntity
    {
        public string Name {get; set;}
        public Guid CountryId {get; set;}
    }
}