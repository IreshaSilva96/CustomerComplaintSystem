using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class AccountRepository : IAccountInterface
    {
        ApplicationDbContext _applicationDbContext;


        public AccountRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }

        public ICollection<Account> GetAllAccounts()
        {
            var accounts = _applicationDbContext.Account.ToList();
            return accounts;
        }

        public Account GetAccountByID(int AccountID)
        {
            var account = _applicationDbContext.Account.Where(c => c.AccountID == AccountID).SingleOrDefault();
            return account;
        }

        
    }
}
