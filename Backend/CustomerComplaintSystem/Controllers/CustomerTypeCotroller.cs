using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/customertype")]
    [ApiController]

    public class CustomerTypeCotroller : ControllerBase
    {
        ICustomerTypeInterface _customerTypeRepo;

        public CustomerTypeCotroller(ICustomerTypeInterface customerTypeRepo)
        {
            _customerTypeRepo = customerTypeRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllCustomerTypes()
        {
            var customerTypes = _customerTypeRepo.GetAllCustomerTypes();
            return Ok(customerTypes);
        }


        [HttpGet("search/{CustomerTypeID}")]
        public IActionResult GetCustomerTypeByID(int CustomerTypeID)
        {
            if (CustomerTypeID < 0)
            {
                BadRequest();
            }
            var customerType = _customerTypeRepo.GetCustomerTypeByID(CustomerTypeID);
            return Ok(customerType);
        }


        [HttpPost("create")]
        public IActionResult CreateCustomerType([FromBody] CustomerType NewCustomerType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewCustomerType == null)
            {
                return BadRequest();
            }

            _customerTypeRepo.CreateCustomerType(NewCustomerType);
            return Ok();
        }


        [HttpPut("update/{CustomerTypeID}")]
        public IActionResult UpdateCustomerType(int CustomerTypeID, [FromBody] CustomerType CustomerTypeObject)
        {
            if (CustomerTypeID < 0)
            {
                return BadRequest();
            }

            int result = _customerTypeRepo.UpdateCustomerType(CustomerTypeID, CustomerTypeObject);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }


        [HttpDelete("delete/{CustomerTypeID}")]
        public IActionResult DeleteCustomerType(int CustomerTypeID)
        {
            if (CustomerTypeID < 0)
            {
                return BadRequest();
            }
            _customerTypeRepo.DeleteCustomerType(CustomerTypeID);

            return Ok();
        }
    }
}
