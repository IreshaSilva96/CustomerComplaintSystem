using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/agenttype")]
    [ApiController]

    public class AgentTypeController : ControllerBase
    {
        IAgentTypeInterface _agentTypeRepo;

        public AgentTypeController(IAgentTypeInterface agentTypeRepo)
        {
            _agentTypeRepo = agentTypeRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllAgentTypes()
        {
            var agentType = _agentTypeRepo.GetAllAgentTypes();
            return Ok(agentType);
        }


        [HttpGet("search/{AgentTypeID}")]
        public IActionResult GetAgentTypeByID(int AgentTypeID)
        {
            if (AgentTypeID < 0)
            {
                BadRequest();
            }
            var agentType = _agentTypeRepo.GetAgentTypeByID(AgentTypeID);
            return Ok(agentType);
        }


        [HttpPost("create")]
        public IActionResult CreateAgentType([FromBody] AgentType NewAgentType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewAgentType == null)
            {
                return BadRequest();
            }

            _agentTypeRepo.CreateAgentType(NewAgentType);
            return Ok();
        }


        [HttpPut("update/{AgentTypeID}")]
        public IActionResult UpdateAgentType(int AgentTypeID, [FromBody] AgentType AgentTypeObject)
        {
            if (AgentTypeID < 0)
            {
                return BadRequest();
            }

            int result = _agentTypeRepo.UpdateAgentType(AgentTypeID, AgentTypeObject);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }


        [HttpDelete("delete/{AgentTypeID}")]
        public IActionResult DeleteAgentType(int AgentTypeID)
        {
            if (AgentTypeID < 0)
            {
                return BadRequest();
            }
            _agentTypeRepo.DeleteAgentType(AgentTypeID);

            return Ok();
        }
    }
}
