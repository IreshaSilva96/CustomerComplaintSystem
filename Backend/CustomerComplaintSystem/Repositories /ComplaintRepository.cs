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
        //                      join _gender in _applicationDbContext.Gender
        //                      on _complaint.GenderID equals _gender.GenderID
        //                      join _customerType in _applicationDbContext.CustomerType
        //                      on _complaint.CustomerTypeID equals _customerType.CustomerTypeID
        //                      join _branch in _applicationDbContext.Branch
        //                      on _complaint.BranchID equals _branch.BranchID
        //                      join _categoryOfComplaint in _applicationDbContext.CategoryOfComplaint
        //                      on _complaint.CategoryOfComplaintID equals _categoryOfComplaint.CategoryOfComplaintID
        //                      join _productAndService in _applicationDbContext.ProductAndService
        //                      on _categoryOfComplaint.CategoryOfComplaintID equals _productAndService.ProductAndServiceID
        //                      join _natureOfComplaint in _applicationDbContext.NatureOfComplaint
        //                      on _productAndService.ProductAndServiceID equals _natureOfComplaint.ProductAndServiceID
        //                      join _complaintStatus in _applicationDbContext.ComplaintStatus
        //                      on _complaint.ComplaintStatusID equals _complaintStatus.ComplaintStatusID
        //                      join _Agent in _applicationDbContext.Agent
        //                      on _natureOfComplaint.NatureOfComplaintID equals _Agent.NatureOfComplaintID

        //                      select new GetAllComplaintsDTO
        //                      {
        //                          ComplaintID = _complaint.ComplaintID,
        //                          FullName = _complaint.FirstName + _complaint.LastName,
        //                          AccountNumber = _account.AccountNumber,
        //                          NIC = _complaint.NIC,
        //                          ContactNumber = _complaint.ContactNumber,

        //                          Gender = _gender.GenderName,
        //                          CategoryofComplaint = _categoryOfComplaint.CategoryOfComplaintName,
        //                          ProductandService = _productAndService.ProductAndServiceName,
        //                          NatureOfComplaint = _natureOfComplaint.NatureOfComplaintName,

        //                          ComplaintStatus = _complaintStatus.ComplaintStatusName,
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
