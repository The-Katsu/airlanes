namespace Airlanes.Models
{
    public class Hotel : BaseEntity
    {
        public string Name {get; set;}
        public Guid CityId {get; set;}
        public int Stars {get; set;}
        public int PriceForNight {get; set;}
        public string Placement {get; set;}
    }
}