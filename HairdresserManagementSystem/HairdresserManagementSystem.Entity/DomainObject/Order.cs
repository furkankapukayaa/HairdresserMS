using HairdresserManagementSystem.Entity.Enum;

namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Order : BaseDomainObject
    {
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
        public double Tip { get; set; }
        public double Discount { get; set; }
        public double Amount { get; set; }
        public OrderPaymentType PaymentType { get; set; }
    }
}