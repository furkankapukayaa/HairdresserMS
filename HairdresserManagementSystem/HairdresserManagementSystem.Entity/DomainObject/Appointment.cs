namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Appointment : BaseDomainObject
    {
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public ICollection<Product> Products { get; set; }
        public double Amount { get; set; }
    }
}