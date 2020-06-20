using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class BranchRepository : IBranchInterface
    {
        ApplicationDbContext _applicationDbContext;

        public BranchRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }

        public ICollection<Branch> GetAllBranches()
        {
            var branches = _applicationDbContext.Branch.ToList();
            return branches;
        }


        public Branch GetBranchByID(int BranchID)
        {
            var branch = _applicationDbContext.Branch.Where(x => x.BranchID == BranchID).SingleOrDefault();
            return branch;
        }


        public void CreateBranch(Branch NewBranch)
        {
            _applicationDbContext.Branch.Add(NewBranch);
            _applicationDbContext.SaveChanges();
        }


        public int UpdateBranch(int BranchID, Branch BranchObject)
        {
            var branch = _applicationDbContext.Branch.Where(x => x.BranchID == BranchID).SingleOrDefault();

            if (branch == null)
            {
                return 0;
            }
            else
            {
                //branch.BranchID = BranchObject.BranchID;
                branch.BranchName = BranchObject.BranchName;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }


        public void DeleteBranch(int BranchID)
        {
            var branch = _applicationDbContext.Branch.Where(x => x.BranchID == BranchID).SingleOrDefault();

            _applicationDbContext.Branch.Remove(branch);
            _applicationDbContext.SaveChanges();
        }
    }
}
