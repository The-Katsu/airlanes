namespace Airlanes.Models
{
    public class Client : BaseEntity
    {
        public string Surname {get; set;}
        public string Name {get; set;}
        public string Patronymic {get; set;}
        public DateOnly BirthDate {get; set;}
        public string Gender {get; set;}
        public string PhoneNumber {get; set;}
    }
}