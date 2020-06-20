using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/categoryofcomplaint")]
    [ApiController]

    public class CategoryOfComplaintCotroller : ControllerBase
    {
        ICategoryOfComplaintInterface _categoryOfComplaintRepo;

        public CategoryOfComplaintCotroller(ICategoryOfComplaintInterface categoryOfComplaintRepo)
        {
            _categoryOfComplaintRepo = categoryOfComplaintRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllCategoriesOfComplaint()
        {
            var categoriesOfComplaint = _categoryOfComplaintRepo.GetAllCategoriesOfComplaint();
            return Ok(categoriesOfComplaint);
        }


        [HttpGet("search/{CategoryOfComplaintID}")]
        public IActionResult GetCategoryOfComplaintByID(int CategoryOfComplaintID)
        {
            if (CategoryOfComplaintID < 0)
            {
                BadRequest();
            }
            var categoryOfComplaint = _categoryOfComplaintRepo.GetCategoryOfComplaintByID(CategoryOfComplaintID);
            return Ok(categoryOfComplaint);
        }


        [HttpPost("create")]
        public IActionResult CreateCategoryOfComplaint([FromBody] CategoryOfComplaint NewCategoryOfComplaint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewCategoryOfComplaint == null)
            {
                return BadRequest();
            }

            _categoryOfComplaintRepo.CreateCategoryOfComplaint(NewCategoryOfComplaint);
            return Ok();
        }


        [HttpPut("update/{CategoryOfComplaintID}")]
        public IActionResult UpdateCategoryOfComplaint(int CategoryOfComplaintID, [FromBody] CategoryOfComplaint CategoryOfComplaintObject)
        {
            if (CategoryOfComplaintID < 0)
            {
                return BadRequest();
            }

            int result = _categoryOfComplaintRepo.UpdateCategoryOfComplaint(CategoryOfComplaintID, CategoryOfComplaintObject);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }


        [HttpDelete("delete/{CategoryOfComplaintID}")]
        public IActionResult DeleteCategoryOfComplaint(int CategoryOfComplaintID)
        {
            if (CategoryOfComplaintID < 0)
            {
                return BadRequest();
            }
            _categoryOfComplaintRepo.DeleteCategoryOfComplaint(CategoryOfComplaintID);

            return Ok();
        }

    }
}
