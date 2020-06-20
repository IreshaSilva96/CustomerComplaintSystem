using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/complaint")]
    [ApiController]

    public class ComplaintController : ControllerBase
    {
        IComplaintInterface _complaintRepo;

        public ComplaintController(IComplaintInterface complaintRepo)
        {
            _complaintRepo = complaintRepo;
        }



//Action Methods

        [HttpGet]
        public IActionResult GetAllComplaints()
        {
            var complaints = _complaintRepo.GetAllComplaints();
            return Ok(complaints);
        }


        [HttpGet("search/{ComplaintID}")]
        public IActionResult GetComplaintByID(int ComplaintID)
        {
            if (ComplaintID < 0)
            {
                BadRequest();
            }
            var complaint = _complaintRepo.GetComplaintByID(ComplaintID);
            return Ok(complaint);
        }


        [HttpPost("create")]
        public IActionResult CreateComplaint([FromBody] Complaint NewComplaint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewComplaint == null)
            {
                return BadRequest();
            }

            _complaintRepo.CreateComplaint(NewComplaint);
            return Ok();
        }
    }
}
