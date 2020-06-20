using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class AgentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgentTypeID { get; set; }

        [Required]
        [MaxLength(20)]
        public string AgentTypeName { get; set; }
    }
}
