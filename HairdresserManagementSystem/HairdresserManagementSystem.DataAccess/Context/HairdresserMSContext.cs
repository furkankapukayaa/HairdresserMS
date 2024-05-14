using HairdresserManagementSystem.Entity.DomainObject;
using Microsoft.EntityFrameworkCore;

namespace HairdresserManagementSystem.DataAccess.Context
{
    public class HairdresserMSContext : DbContext
    {
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Chair> Chairs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}