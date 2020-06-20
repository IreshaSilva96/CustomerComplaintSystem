using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class ComplaintStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComplaintStatusID { get; set; }

        [Required]
        [MaxLength(20)]
        public string ComplaintStatusName { get; set; }
    }
}
