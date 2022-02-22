namespace Airlanes.Models
{
    public class Employee : BaseEntity
    {
        public string Position {get; set;}
        public string Surname {get; set;}
        public string Name {get; set;}
        public string Patronymic {get; set;}
        public DateOnly BirthDate {get; set;}
        public string Gender {get; set;}
        public int DaysWorked {get; set;}
        public string PhoneNumber {get; set;}
        public int Salary {get; set;}
    }
}