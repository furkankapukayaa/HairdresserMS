namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Customer : BaseDomainObject
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}