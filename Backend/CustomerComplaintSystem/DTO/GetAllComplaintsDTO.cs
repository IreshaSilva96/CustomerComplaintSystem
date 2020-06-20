using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerComplaintSystem.DTO
{
    public class GetAllComplaintsDTO
    {
        public int ComplaintID { get; set; }

        public string FullName { get; set; }

        public int AccountNumber { get; set; }

        public string NIC { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public DateTime DateOfComplaint { get; set; }

        public DateTime ComplaintLoggedDate { get; set; }

        public string Gender { get; set; }

        public string CustomerType { get; set; }

        public string Branch { get; set; }

        public string CategoryofComplaint { get; set; }

        public string ProductandService { get; set; }

        public string NatureOfComplaint { get; set; }

        public string ComplaintStatus { get; set; }

        public string Agent { get; set; }
    }
}
