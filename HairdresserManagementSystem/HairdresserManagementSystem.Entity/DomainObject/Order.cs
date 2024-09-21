using HairdresserManagementSystem.Entity.Enum;

namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Order : BaseDomainObject
    {
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
        public decimal Tip { get; set; }
        public decimal Discount { get; set; }
        public decimal Amount { get; set; }
        public OrderPaymentType PaymentType { get; set; }
        public string ChairName { get; set; }
    }
}