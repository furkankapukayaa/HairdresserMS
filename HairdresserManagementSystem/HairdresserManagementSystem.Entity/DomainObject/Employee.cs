﻿using HairdresserManagementSystem.Entity.Enum;

namespace HairdresserManagementSystem.Entity.DomainObject
{
    public class Employee : BaseDomainObject
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public EmployeeType Type { get; set; }
    }
}