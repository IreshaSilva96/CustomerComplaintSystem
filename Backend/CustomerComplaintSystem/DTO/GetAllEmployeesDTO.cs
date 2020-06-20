using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.DTO
{
    public class GetAllEmployeesDTO 
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NIC { get; set; }

        public int ContactNumber { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Branch { get; set; }
    }
}
