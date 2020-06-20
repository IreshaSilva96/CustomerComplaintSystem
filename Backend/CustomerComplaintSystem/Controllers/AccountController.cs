using System;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/account")]
    [ApiController]

    public class AccountController :ControllerBase
    {
        IAccountInterface _accountRepo;

        public AccountController(IAccountInterface accountRepo)
        {
            _accountRepo = accountRepo;

        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllAccounts()
        {
            var account = _accountRepo.GetAllAccounts();
            return Ok(account);
        }


        [HttpGet("{AccountID}")]
        public IActionResult GetAccountByID(int AccountID)
        {
            if (AccountID < 0)
            {
                BadRequest();
            }
            var account = _accountRepo.GetAccountByID(AccountID);
            return Ok(account);
        }


    }
}
