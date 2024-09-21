using HairdresserManagementSystem.Entity.Enum;

namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Chair : BaseDomainObject
    {
        public string Name { get; set; }
        public Employee Employee { get; set; }
        public ChairStatusType ChairStatusType { get; set; }
        public string? OrderId { get; set; }
    }
}