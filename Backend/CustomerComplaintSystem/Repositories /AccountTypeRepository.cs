using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class AccountTypeRepository : IAccountTypeInterface
    {
        ApplicationDbContext _applicationDbContext;

        public AccountTypeRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }

        public ICollection<AccountType> GetAllAccountTypes()
        {
            var accountTypes = _applicationDbContext.AccountType.ToList();
            return accountTypes;
        }

        public AccountType GetAccountTypeByID(int AccountTypeID)
        {
            var accountType = _applicationDbContext.AccountType.Where(x => x.AccountTypeID == AccountTypeID).SingleOrDefault();
            return accountType;
        }

        public void CreateAccountType(AccountType NewAccountType)
        {
            throw new NotImplementedException();
        }

        public int UpdateAgentType(int AcountTypeID, AccountType AccountTypeOject)
        {
            throw new NotImplementedException();
        }

        public int DeleteAccountType(int AccountTypeID)
        {
            throw new NotImplementedException();
        }
    }
}
