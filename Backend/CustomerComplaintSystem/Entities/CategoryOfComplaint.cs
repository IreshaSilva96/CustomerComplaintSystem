using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class CategoryOfComplaint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryOfComplaintID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CategoryOfComplaintName { get; set; }
    }
}
