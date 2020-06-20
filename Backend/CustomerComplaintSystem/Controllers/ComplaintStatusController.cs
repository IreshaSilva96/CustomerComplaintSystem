using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/complaintstatus")]
    [ApiController]

    public class ComplaintStatusController : ControllerBase
    {
        IComplaintStatusInterface _complaintStatusRepo;

        public ComplaintStatusController(IComplaintStatusInterface complaintStatusRepo)
        {
            _complaintStatusRepo = complaintStatusRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllComplaintStatuses()
        {
            var complaintStatuses = _complaintStatusRepo.GetAllComplaintStatuses();
            return Ok(complaintStatuses);
        }


        [HttpGet("search/{ComplaintStatusID}")]
        public IActionResult GetComplaintStatusByID(int ComplaintStatusID)
        {
            if (ComplaintStatusID < 0)
            {
                BadRequest();
            }
            var complaintStatus = _complaintStatusRepo.GetComplaintStatusByID(ComplaintStatusID);
            return Ok(complaintStatus);
        }


        [HttpPost("create")]
        public IActionResult CreateComplaintStatus([FromBody] ComplaintStatus NewComplaintStatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewComplaintStatus == null)
            {
                return BadRequest();
            }

            _complaintStatusRepo.CreateComplaintStatus(NewComplaintStatus);
            return Ok();
        }


        [HttpPut("update/{ComplaintStatusID}")]
        public IActionResult UpdateComplaintStatus(int ComplaintStatusID, [FromBody] ComplaintStatus ComplaintStatusObject)
        {
            if (ComplaintStatusID < 0)
            {
                return BadRequest();
            }

            int result = _complaintStatusRepo.UpdateComplaintStatus(ComplaintStatusID, ComplaintStatusObject);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }


        [HttpDelete("delete/{ComplaintStatusID}")]
        public IActionResult DeleteComplaintStatus(int ComplaintStatusID)
        {
            if (ComplaintStatusID < 0)
            {
                return BadRequest();
            }
            _complaintStatusRepo.DeleteComplaintStatus(ComplaintStatusID);

            return Ok();
        }
    }
}
