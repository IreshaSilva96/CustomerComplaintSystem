using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.DTO;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class EmployeeRepository: IEmployeeInterface
    {
        ApplicationDbContext _applicationDbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }


        ICollection<GetAllEmployeesDTO> IEmployeeInterface.GetAllEmployees()
        {
            var employees = (from _employee in _applicationDbContext.Employee
                            join _branch in _applicationDbContext.Branch
                            on _employee.BranchID equals _branch.BranchID
    
                            select new GetAllEmployeesDTO
                            {
                                EmployeeID      = _employee.EmployeeID,
                                FirstName       = _employee.FirstName,
                                LastName        = _employee.LastName,
                                NIC             = _employee.NIC,
                                ContactNumber   = _employee.ContactNumber,
                                Address         = _employee.Address,
                                Email           = _employee.Email,
                                Branch          = _branch.BranchName
                            }).ToList();

            return employees;
        }


        public Employee GetEmployeeByID(int EmployeeID)
        {
            var employee = _applicationDbContext.Employee.Where(c => c.EmployeeID == EmployeeID).SingleOrDefault();
            return employee;
        }


        public ICollection<Employee> GetEmployeeByAttribute(string Attribute)
        {
            var employee = _applicationDbContext.Employee.Where(c => c.EmployeeID.ToString().Contains(Attribute)
                                                                  || c.FirstName.ToString().Contains(Attribute)
                                                                  || c.LastName.ToString().Contains(Attribute)
                                                                  || c.NIC.ToString().Contains(Attribute)
                                                                  || c.ContactNumber.ToString().Contains(Attribute)
                                                                  || c.Address.ToString().Contains(Attribute)
                                                                  || c.Email.ToString().Contains(Attribute)
                                                                  || c.BranchID.ToString().Contains(Attribute)).ToList();
            return employee;
        }
    }
}
