using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class NatureOfComplaintRepository : INatureOfComplaintInterface
    {
        ApplicationDbContext _applicationDbContext;

        public NatureOfComplaintRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }



        public ICollection<NatureOfComplaint> GetAllNaturesOfComplaint()
        {
            var naturesOfComplaint = _applicationDbContext.NatureOfComplaint.ToList();
            return naturesOfComplaint;
        }


        public NatureOfComplaint GetNatureOfComplaintByID(int NatureOfComplaintID)
        {
            var natureOfComplaint = _applicationDbContext.NatureOfComplaint.Where(x => x.NatureOfComplaintID == NatureOfComplaintID).SingleOrDefault();
            return natureOfComplaint;
        }


        public void CreateNatureOfComplaint(NatureOfComplaint NewNatureOfComplaint)
        {
            _applicationDbContext.NatureOfComplaint.Add(NewNatureOfComplaint);
            _applicationDbContext.SaveChanges();
        }


        public int UpdateNatureOfComplaint(int NatureOfComplaintID, NatureOfComplaint NatureOfComplaintObject)
        {
            var natureOfComplaint = _applicationDbContext.NatureOfComplaint.Where(x => x.NatureOfComplaintID == NatureOfComplaintID).SingleOrDefault();

            if (natureOfComplaint == null)
            {
                return 0;
            }
            else
            {
                natureOfComplaint.NatureOfComplaintName= NatureOfComplaintObject.NatureOfComplaintName;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }


        public void DeleteNatureOfComplaint(int NatureOfComplaintID)
        {
            var natureOfComplaint = _applicationDbContext.NatureOfComplaint.Where(x => x.NatureOfComplaintID == NatureOfComplaintID).SingleOrDefault();

            _applicationDbContext.NatureOfComplaint.Remove(natureOfComplaint);
            _applicationDbContext.SaveChanges();
        }
    }
}
