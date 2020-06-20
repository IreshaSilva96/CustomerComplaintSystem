using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [MaxLength(20)]
        public string NIC { get; set; }

        [MaxLength(20)]
        public int ContactNumber { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }

        [ForeignKey("BranchID")]
        public Branch ParentBranch { get; set; }
        public int BranchID { get; set; }
    }
}
