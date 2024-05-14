namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Settings : BaseDomainObject
    {
        public string WorkplaceName { get; set; }
        public string WorkplaceAddress { get; set; }
        public string WorkplacePhone { get; set; }
        public string WorkplaceAuthority { get; set; }
    }
}