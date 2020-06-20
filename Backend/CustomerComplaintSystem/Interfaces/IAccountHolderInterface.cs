using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IAccountHolderInterface
    {
        ICollection<AccountHolder> GetAllAccountHolders();

        ICollection<AccountHolder> GetAccountHolderByAttribbute(string Attribute);

        AccountHolder GetAccountHolderByAccountID(int AccountID);
    }
}
