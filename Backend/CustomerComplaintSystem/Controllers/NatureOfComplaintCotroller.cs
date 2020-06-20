using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/natureofcomplaint")]
    [ApiController]

    public class NatureOfComplaintCotroller : ControllerBase
    {
        INatureOfComplaintInterface _natureOfComplaintRepo;

        public NatureOfComplaintCotroller(INatureOfComplaintInterface natureOfComplainRepo)
        {
            _natureOfComplaintRepo = natureOfComplainRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllNaturesOfComplaint()
        {
            var naturesOfComplaint = _natureOfComplaintRepo.GetAllNaturesOfComplaint();
            return Ok(naturesOfComplaint);
        }


        [HttpGet("search/{NatureOfComplaintID}")]
        public IActionResult GetNatureOfComplaintByID(int NatureOfComplaintID)
        {
            if (NatureOfComplaintID < 0)
            {
                BadRequest();
            }
            var natureOfComplaint = _natureOfComplaintRepo.GetNatureOfComplaintByID(NatureOfComplaintID);
            return Ok(natureOfComplaint);
        }


        [HttpPost("create")]
        public IActionResult CreateNatureOfComplaint([FromBody] NatureOfComplaint NewNatureOfComplaint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewNatureOfComplaint == null)
            {
                return BadRequest();
            }

            _natureOfComplaintRepo.CreateNatureOfComplaint(NewNatureOfComplaint);
            return Ok();
        }


        [HttpPut("update/{NatureOfComplaintID}")]
        public IActionResult UpdateNatureOfComplaint(int NatureOfComplaintID, [FromBody] NatureOfComplaint NatureOfComplaintObject)
        {
            if (NatureOfComplaintID < 0)
            {
                return BadRequest();
            }

            int result = _natureOfComplaintRepo.UpdateNatureOfComplaint(NatureOfComplaintID, NatureOfComplaintObject);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }


        [HttpDelete("delete/{NatureOfComplaintID}")]
        public IActionResult DeleteNatureOfComplaint(int NatureOfComplaintID)
        {
            if (NatureOfComplaintID < 0)
            {
                return BadRequest();
            }
            _natureOfComplaintRepo.DeleteNatureOfComplaint(NatureOfComplaintID);

            return Ok();
        }
    }
}
