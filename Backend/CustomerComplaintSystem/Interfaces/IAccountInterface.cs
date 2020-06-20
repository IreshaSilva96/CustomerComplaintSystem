using System;
using System.Collections;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IAccountInterface
    {
        ICollection<Account> GetAllAccounts();

        Account GetAccountByID(int AccounID);
    }
}
