using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.DTO;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class ComplaintRepository : IComplaintInterface
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ComplaintRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public ICollection<Complaint> GetAllComplaints()
        {
            var complaints = _applicationDbContext.Complaint.ToList();
            return complaints;
        }



        //ICollection<GetAllComplaintsDTO> IComplaintInterface.GetAllComplaints()
        //{
        //    var complaints = (from _complaint in _applicationDbContext.Complaint
        //                      join _account in _applicationDbContext.Account
        //                      on _complaint.AccountID equals _account.AccountID

        //                      join _categoryOfComplaint in _applicationDbContext.CategoryOfComplaint
        //                      on _complaint.CategoryOfComplaintID equals _categoryOfComplaint.CategoryOfComplaintID

        //                      join _productAndService in _applicationDbContext.ProductAndService
        //                      on _complaint.ProductAndServiceID equals _productAndService.ProductAndServiceID

        //                      join _natureOfComplaint in _applicationDbContext.NatureOfComplaint
        //                      on _complaint.NatureOfComplaintID equals _natureOfComplaint.NatureOfComplaintID

        //                      join _Agent in _applicationDbContext.Agent
        //                      on _complaint.NatureOfComplaintID equals _Agent.NatureOfComplaintID


        //                      select new GetAllComplaintsDTO
        //                      {
        //                          ComplaintID = _complaint.ComplaintID,
        //                          FullName = _complaint.FirstName + " " + _complaint.LastName,
        //                          AccountNumber = _account.AccountNumber,
        //                          NIC = _complaint.NIC,
        //                          ContactNumber = _complaint.ContactNumber,
        //                          Email = _complaint.Email,
        //                          Description = _complaint.Description,
        //                          ComplaintLoggedDate = _complaint.ComplaintLoggedDate,
        //                          CustomerType = _complaint.CustomerType,
        //                          Branch = _complaint.Branch,
        //                          CategoryofComplaint = _categoryOfComplaint.CategoryOfComplaintName,
        //                          ProductandService = _productAndService.ProductAndServiceName,
        //                          NatureOfComplaint = _natureOfComplaint.NatureOfComplaintName,
        //                          ComplaintStatus = _complaint.ComplaintStatus,
        //                          Agent = _Agent.AgentUserName

        //                      }).ToList();

        //    return complaints;
        //}


        public Complaint GetComplaintByID(int ComplaintID)
        {
            var complaint = _applicationDbContext.Complaint.Where(x => x.ComplaintID == ComplaintID).SingleOrDefault();
            return complaint;
        }


        public void CreateComplaint(Complaint NewComplaint)
        {
            _applicationDbContext.Complaint.Add(NewComplaint);
            _applicationDbContext.SaveChanges();
        }

    }
}
