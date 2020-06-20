using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountID { get; set; }

        [Required]
        public int AccountNumber { get; set; }

        [ForeignKey("AccountTypeID")]
        public AccountType ParentAccountType { get; set; }
        public int AccountTypeID { get; set; }

        [ForeignKey("BranchID")]
        public Branch ParentBranch { get; set; }
        public int BranchID { get; set; }

        [ForeignKey("AccountHolderID")]
        public AccountHolder ParentAccountHolder { get; set; }
        public int AccountHolderID { get; set; }
    }








    





    
}
