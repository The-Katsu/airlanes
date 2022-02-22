namespace Airlanes.Models
{
    public class Tour : BaseEntity
    {
        public string Type {get; set;}
        public int Price {get; set;}
        public Guid FlightId {get; set;}
        public DateTime StartDate {get; set;}
        public int Days {get; set;}
        public Guid MealId {get; set;}
    }
}