using HairdresserManagementSystem.Entity.Enum;

namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Appointment : BaseDomainObject
    {
        public string EmployeeId { get; set; }
        public string CustomerId { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public List<string> Products { get; set; }
        public double Amount { get; set; }
        public AppointmentStatusType AppointmentStatusType { get; set; }
    }
}