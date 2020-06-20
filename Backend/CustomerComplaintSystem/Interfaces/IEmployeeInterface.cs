using System;
using System.Collections.Generic;
using CustomerComplaintSystem.DTO;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IEmployeeInterface
    {
        ICollection<GetAllEmployeesDTO> GetAllEmployees();

        Employee GetEmployeeByID(int EmployeeID);

        ICollection<Employee> GetEmployeeByAttribute(string Attribute);
    }
}
