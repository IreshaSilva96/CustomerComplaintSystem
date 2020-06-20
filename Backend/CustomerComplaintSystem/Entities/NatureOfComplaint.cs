using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class NatureOfComplaint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NatureOfComplaintID { get; set; }

        [Required]
        [MaxLength(50)]
        public string NatureOfComplaintName { get; set; }

        [ForeignKey("ProductAndServiceID")]
        public ProductAndService ParentProductAndService { get; set; }
        public int ProductAndServiceID { get; set; }
    }
}
