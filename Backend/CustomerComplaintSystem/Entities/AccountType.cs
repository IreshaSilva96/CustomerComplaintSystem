using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class AccountType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountTypeID { get; set; }

        [Required]
        [MaxLength(20)]
        public string AccountTypeName { get; set; }

    }
}
