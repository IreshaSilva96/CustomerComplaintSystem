using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/agent")]
    [ApiController]

    public class AgentController : ControllerBase
    {
        IAgentInterface _agentRepo;

        public AgentController(IAgentInterface agentRepo)
        {
            _agentRepo = agentRepo;
        }



//Action Methods

        [HttpGet]
        public IActionResult GetAllAgents()
        {
            var agent = _agentRepo.GetAllAgents();
            return Ok(agent);
        }


        [HttpGet("search/{AgentID}")]
        public IActionResult GetAgentByID(int AgentID)
        {
            if (AgentID < 0)
            {
                BadRequest();
            }
            var agentType = _agentRepo.GetAgentByID(AgentID);
            return Ok(agentType);
        }


        [HttpPost ("create")]
        public IActionResult CreateAgent([FromBody] Agent NewAgent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewAgent == null)
            {
                return BadRequest();
            }

            _agentRepo.CreateAgent(NewAgent);
            return Ok();
        }

        [HttpPut("update/{AgentID}")]
        public IActionResult UpdateAgent(int AgentID, [FromBody] Agent AgentObject)
        {
            if (AgentID < 0)
            {
                return BadRequest();
            }

            int result = _agentRepo.UpdateAgent(AgentID, AgentObject);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }


        [HttpPut("resetpassword/{AgentID}")]
        public IActionResult ResetPassword(int AgentID)
        {
            var user = _agentRepo.ResetPassword(AgentID);

            if (user == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }

        [HttpPut("changepassword/{AgentID}")]
        public IActionResult ChangePassword(int AgentID, [FromBody] Agent NewPassword)
        {
            if (AgentID < 0)
            {
                return BadRequest();
            }

            int result = _agentRepo.ChangePassword(AgentID, NewPassword);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }

        [HttpDelete("delete/{AgentID}")]
        public IActionResult DeleteAgent(int AgentID)
        {
            if (AgentID < 0)
            {
                return BadRequest();
            }
            _agentRepo.DeleteAgent(AgentID);

            return Ok();
        }
    }
}
