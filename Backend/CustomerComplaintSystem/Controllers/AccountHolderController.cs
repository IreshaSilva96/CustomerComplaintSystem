using System;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [ApiController]
    [Route("api/accountholder")]
    

    public class AccountHolderController : ControllerBase
    {
        IAccountHolderInterface _accountHolderRepo;

        public AccountHolderController(IAccountHolderInterface accountHolderRepo)
        {
            _accountHolderRepo = accountHolderRepo;

        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllAccountHolders()
        {

            return Ok();
        }
    }
}
