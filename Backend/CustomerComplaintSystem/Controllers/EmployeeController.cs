using System;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/employee")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        IEmployeeInterface _employeeRepo;

        public EmployeeController(IEmployeeInterface employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeRepo.GetAllEmployees();
            return Ok(employees);
        }


        [HttpGet("searchbyid/{employeeID}")]
        public IActionResult GetEmployeeByID(int EmployeeID)
        {
            var employee = _employeeRepo.GetEmployeeByID(EmployeeID);
            return Ok(employee);
        }


        [HttpGet("searchbyattribute/{Attribute}")]
        public IActionResult GetEmployeeByAttribute(string Attribute)
        {
            var employee = _employeeRepo.GetEmployeeByAttribute(Attribute);
            return Ok(employee);
        }
    }
}
