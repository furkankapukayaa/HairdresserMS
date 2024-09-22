using HairdresserManagementSystem.Entity.Enum;

namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Order : BaseDomainObject
    {
        public string EmployeeId { get; set; }
        public string CustomerId { get; set; }
        public string Description { get; set; }
        public List<string> Products { get; set; }
        public decimal Tip { get; set; }
        public decimal Discount { get; set; }
        public decimal Amount { get; set; }
        public OrderPaymentType PaymentType { get; set; }
        public string ChairName { get; set; }
    }
}