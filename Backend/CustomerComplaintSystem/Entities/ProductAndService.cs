using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class ProductAndService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductAndServiceID { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductAndServiceName { get; set; }

        [ForeignKey("CategoryOfComplaintID")]
        public CategoryOfComplaint ParentCategoryOfComplaint { get; set; }
        public int CategoryOfComplaintID { get; set; }
    }
}
