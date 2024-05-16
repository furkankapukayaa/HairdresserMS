using HairdresserManagementSystem.DataAccess.Context;
using HairdresserManagementSystem.Entity.DomainObject;
using HairdresserManagementSystem.Entity.Enum;

namespace HairdresserManagementSystem.UserInterface.Events
{
    public class AppSettings
    {
        private HairdresserMSContext hairdresserMSContext = new HairdresserMSContext();
        public void CreateAdmin()
        {
            var employeeControl = hairdresserMSContext.Employees.FirstOrDefault(x => x.Email == "admin@hairdresserms");
            if (employeeControl == null)
            {
                Employee employee = new Employee
                {
                    NameSurname = "HairdresserMS Admin",
                    Email = "admin@hairdresserms",
                    Password = "a",
                    Phone = "+905555555555",
                    Type = EmployeeType.Manager
                };

                hairdresserMSContext.Employees.Add(employee);
                hairdresserMSContext.SaveChanges();
            }
            else
            {
                employeeControl.NameSurname = "HairdresserMS Admin";
                employeeControl.Email = "admin@hairdresserms";
                employeeControl.Password = "a";
                employeeControl.Phone = "+905555555555";
                employeeControl.Type = EmployeeType.Manager;
                employeeControl.IsDeleted = false;
                employeeControl.Status = true;
                hairdresserMSContext.SaveChanges();
            }
        }
    }
}