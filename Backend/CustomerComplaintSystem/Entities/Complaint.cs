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

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string NIC { get; set; }

        [Required]
        [MaxLength(20)]
        public string ConntactNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string Description { get; set; }

        [Required]
        [MaxLength(20)]
        public DateTime ComplaintDate { get; set; }

        [Required]
        [MaxLength(20)]
        public DateTime ComplainedDate { get; set; }

        //[ForeignKey("GenderID")]
        //public Gender ParentGender { get; set; }
        //public int GenderID { get; set; }

        //[ForeignKey("CustomerTypeID")]
        //public CustomerType ParentCustomerType { get; set; }
        //public int CustomerTypeID { get; set; }

        //[ForeignKey("AccountID")]
        //public Account ParentAccount { get; set; }
        //public int AccountID { get; set; }

        //[ForeignKey("BranchID")]
        //public Branch ParentBranch { get; set; }
        //public int BranchID { get; set; }

        //[ForeignKey("CategoryOfComplaintID")]
        //public CategoryOfComplaint ParentCategoryOfComplaint { get; set; }
        //public int CategoryOfComplaintID { get; set; }

        //[ForeignKey("ComplaintStatusID")]
        //public ComplaintStatus ParentComplaintStatus { get; set; }
        //public int ComplaintStatusID { get; set; }

        //[ForeignKey("AgentID")]
        //public Agent ParentAgent { get; set; }
        //public int AgentID { get; set; }
    }
}
