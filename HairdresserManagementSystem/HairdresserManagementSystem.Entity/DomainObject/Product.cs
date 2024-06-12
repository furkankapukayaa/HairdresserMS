namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Product : BaseDomainObject
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}