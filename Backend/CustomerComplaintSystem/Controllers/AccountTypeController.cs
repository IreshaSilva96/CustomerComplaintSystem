using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/accounttype")]
    [ApiController]

    public class AccountTypeController : ControllerBase
    {
        IAccountTypeInterface _accountTypeRepo;

        public AccountTypeController(IAccountTypeInterface accountTypeRepo)
        {
            _accountTypeRepo = accountTypeRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllAccountTypes()
        {
            var accountType = _accountTypeRepo.GetAllAccountTypes();
            return Ok(accountType);
        }


        [HttpGet("{AccountTypeID}")]
        public IActionResult GetAccountTypeByID(int AccountTypeID)
        {
            if (AccountTypeID < 0)
            {
                BadRequest();
            }
            var accountType = _accountTypeRepo.GetAccountTypeByID(AccountTypeID);
            return Ok(accountType);
        }

    }
}
