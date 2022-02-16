namespace Airlanes.Models
{
    public class Trip : BaseEntity
    {
        public Guid EmployeeId {get; set;}
        public Guid ClientId {get; set;}
        public Guid TourId {get; set;}
        public DateTime TimeOfSale {get; set;}
    }
}