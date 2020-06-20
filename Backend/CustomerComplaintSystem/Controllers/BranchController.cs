using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/branch")]
    [ApiController]

    public class BranchController : ControllerBase
    {
        IBranchInterface _branchRepo;

        public BranchController(IBranchInterface branchRepo)
        {
            _branchRepo = branchRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllBranches()
        {
            var branch = _branchRepo.GetAllBranches();
            return Ok(branch);
        }


        [HttpGet("search/{BranchID}")]
        public IActionResult GetBranchByID(int BranchID)
        {
            if (BranchID < 0)
            {
                BadRequest();
            }
            var branch = _branchRepo.GetBranchByID(BranchID);
            return Ok(branch);
        }


        [HttpPost("create")]
        public IActionResult CreateBranch([FromBody] Branch NewBranch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewBranch == null)
            {
                return BadRequest();
            }

            _branchRepo.CreateBranch(NewBranch);
            return Ok();
        }


        [HttpPut("update/{BranchID}")]
        public IActionResult UpdateBranch(int BranchID, [FromBody] Branch BranchObject)
        {
            if (BranchID < 0)
            {
                return BadRequest();
            }

            int result = _branchRepo.UpdateBranch(BranchID, BranchObject);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }


        [HttpDelete("delete/{BranchID}")]
        public IActionResult DeleteBranch(int BranchID)
        {
            if (BranchID < 0)
            {
                return BadRequest();
            }
            _branchRepo.DeleteBranch(BranchID);

            return Ok();
        }
    }
}
