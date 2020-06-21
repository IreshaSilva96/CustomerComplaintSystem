using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class AccountHolderRepository : IAccountHolderInterface
    {
        ApplicationDbContext _applicationDbContext;

        public AccountHolderRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }

        public ICollection<AccountHolder> GetAllAccountHolders()
        {
            var accounthholders = _applicationDbContext.AccountHolder.ToList();
            return accounthholders;
        }

        public ICollection<AccountHolder> GetAccountHolderByAttribbute(string Attribute)
        {
            var accountholder = _applicationDbContext.AccountHolder.Where(x => x.AccountHolderID.ToString().Contains(Attribute)
                                                                            || x.FirstName.Contains(Attribute)
                                                                            || x.LastName.Contains(Attribute)
                                                                            || x.NIC.Contains(Attribute)
                                                                            || x.ContactNumber.ToString().Contains(Attribute)
                                                                            || x.Address.Contains(Attribute)
                                                                            || x.Email.Contains(Attribute)).ToList();
            return accountholder;
        }

        public AccountHolder GetAccountHolderByAccountID(int AccountHolderID)
        {
            var accountHolder = _applicationDbContext.AccountHolder.Where(c => c.AccountHolderID == AccountHolderID).SingleOrDefault();
            return accountHolder;
        }
    }
}
