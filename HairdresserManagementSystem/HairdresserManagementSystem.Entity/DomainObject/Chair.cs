using HairdresserManagementSystem.Entity.Enum;

namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Chair : BaseDomainObject
    {
        public string Name { get; set; }
        public string EmployeeId { get; set; }
        public ChairStatusType ChairStatusType { get; set; } = ChairStatusType.Boş;
        public string? OrderId { get; set; }
    }
}