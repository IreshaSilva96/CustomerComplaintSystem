using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class ComplaintStatusRepository : IComplaintStatusInterface
    {
        ApplicationDbContext _applicationDbContext;

        public ComplaintStatusRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }



        public ICollection<ComplaintStatus> GetAllComplaintStatuses()
        {
            var complaintStatuses = _applicationDbContext.ComplaintStatus.ToList();
            return complaintStatuses;
        }


        public ComplaintStatus GetComplaintStatusByID(int ComplaintStatusID)
        {
            var complaintStatus = _applicationDbContext.ComplaintStatus.Where(x => x.ComplaintStatusID == ComplaintStatusID).SingleOrDefault();
            return complaintStatus;
        }


        public void CreateComplaintStatus(ComplaintStatus NewComplaintStatus)
        {
            _applicationDbContext.ComplaintStatus.Add(NewComplaintStatus);
            _applicationDbContext.SaveChanges();
        }


        public int UpdateComplaintStatus(int ComplaintStatusID, ComplaintStatus ComplaintStatusObject)
        {
            var complaintStatus = _applicationDbContext.ComplaintStatus.Where(x => x.ComplaintStatusID == ComplaintStatusID).SingleOrDefault();

            if (complaintStatus == null)
            {
                return 0;
            }
            else
            {
                //complaintStatus.ComplaintStatusID = ComplaintStatusObject.ComplaintStatusID;
                complaintStatus.ComplaintStatusName = ComplaintStatusObject.ComplaintStatusName;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }


        public void DeleteComplaintStatus(int ComplaintStatusID)
        {
            var complaintStatus = _applicationDbContext.ComplaintStatus.Where(x => x.ComplaintStatusID == ComplaintStatusID).SingleOrDefault();

            _applicationDbContext.ComplaintStatus.Remove(complaintStatus);
            _applicationDbContext.SaveChanges();
        }
    }
}
