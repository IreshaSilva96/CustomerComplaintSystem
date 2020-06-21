using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class Complaint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComplaintID { get; set; }

        public string CustomerType { get; set; }

        public int AccountID { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        public string Branch { get; set; }

        [MaxLength(20)]
        public string NIC { get; set; }

        [Required]
        [MaxLength(20)]
        public string ContactNumber { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime ComplaintLoggedDate { get; set; }

        public string ComplaintStatus { get; set; }

        [ForeignKey("CategoryOfComplaintID")]
        public CategoryOfComplaint ParentCategoryOfComplaint { get; set; }
        public int CategoryOfComplaintID { get; set; }

        public int ProductAndServiceID { get; set; }

        public int NatureOfComplaintID { get; set; }

    }
}
