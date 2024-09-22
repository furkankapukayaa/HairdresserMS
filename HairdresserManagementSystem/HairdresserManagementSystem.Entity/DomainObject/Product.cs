namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Product : BaseDomainObject
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}