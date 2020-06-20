using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IBranchInterface
    {
        ICollection<Branch> GetAllBranches();

        Branch GetBranchByID(int BranchID);

        void CreateBranch(Branch NewBranch);

        int UpdateBranch(int BranchID, Branch BranchObject);

        void DeleteBranch(int BranchID);
    }
}
