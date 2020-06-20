using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/gender")]
    [ApiController]

    public class GenderCotroller : ControllerBase
    {
        IGenderInterface _genderRepo;

        public GenderCotroller(IGenderInterface genderRepo)
        {
            _genderRepo = genderRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllGenders()
        {
            var gender = _genderRepo.GetAllGenders();
            return Ok(gender);
        }


        [HttpGet("search/{GenderID}")]
        public IActionResult GetGenderByID(int GenderID)
        {
            if (GenderID < 0)
            {
                BadRequest();
            }
            var gender = _genderRepo.GetGenderByID(GenderID);
            return Ok(gender);
        }


        [HttpPost("create")]
        public IActionResult CreateGender([FromBody] Gender NewGender)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewGender == null)
            {
                return BadRequest();
            }

            _genderRepo.CreateGender(NewGender);
            return Ok();
        }


        [HttpPut("update/{GenderID}")]
        public IActionResult UpdateGender(int GenderID, [FromBody] Gender GenderObject)
        {
            if (GenderID < 0)
            {
                return BadRequest();
            }

            int result = _genderRepo.UpdateGender(GenderID, GenderObject);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }


        [HttpDelete("delete/{GenderID}")]
        public IActionResult DeleteGender(int GenderID)
        {
            if (GenderID < 0)
            {
                return BadRequest();
            }
            _genderRepo.DeleteGender(GenderID);

            return Ok();
        }

    }
}
