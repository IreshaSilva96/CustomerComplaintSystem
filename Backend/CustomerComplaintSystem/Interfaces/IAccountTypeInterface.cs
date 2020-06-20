using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IAccountTypeInterface
    {
        ICollection<AccountType> GetAllAccountTypes();

        AccountType GetAccountTypeByID(int AccountTypeID);

        void CreateAccountType(AccountType NewAccountType);

        int UpdateAgentType(int AcountTypeID, AccountType AccountTypeOject);

        int DeleteAccountType(int AccountTypeID);
    }
}
