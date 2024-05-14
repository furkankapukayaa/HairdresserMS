namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Chair : BaseDomainObject
    {
        public string Name { get; set; }
        public Employee Employee { get; set; }
    }
}