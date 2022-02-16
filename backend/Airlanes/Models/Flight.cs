namespace Airlanes.Models
{
    public class Flight : BaseEntity
    {
        public DateTime Departure {get; set;}
        public DateTime Arrival {get; set;}
        public int Places {get; set;}
        public Guid CityId {get; set;}
        public Guid AirportId {get; set;}
        public int Price {get; set;}
    }
}