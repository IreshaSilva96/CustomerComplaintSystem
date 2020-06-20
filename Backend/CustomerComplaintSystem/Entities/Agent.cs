using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerComplaintSystem.Entities
{
    public class Agent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgentID { get; set; }

        [Required]
        [MaxLength(20)]
        public string AgentUserName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [ForeignKey("AgentTypeID")]
        public AgentType ParentAgentType { get; set; }
        public int AgentTypeID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee ParentEmployee { get; set; }
        public int EmployeeID { get; set; }

        [ForeignKey("NatureOfComplaintID")]
        public NatureOfComplaint ParentNatureOfComplaint { get; set; }
        public int NatureOfComplaintID { get; set; }
    }
}
