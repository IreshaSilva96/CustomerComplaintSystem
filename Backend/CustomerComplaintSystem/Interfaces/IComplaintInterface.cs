using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IComplaintInterface 
    {
        //ICollection<GetAllComplaintsDTO> GetAllComplaints();

        ICollection<Complaint> GetAllComplaints();

        Complaint GetComplaintByID(int ComplaintID);

        void CreateComplaint(Complaint NewComplaint);
    }
}
