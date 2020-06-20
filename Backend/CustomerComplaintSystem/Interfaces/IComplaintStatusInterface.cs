using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IComplaintStatusInterface
    {
        ICollection<ComplaintStatus> GetAllComplaintStatuses();

        ComplaintStatus GetComplaintStatusByID(int ComplaintStatusID);

        void CreateComplaintStatus (ComplaintStatus NewComplaintStatus);

        int UpdateComplaintStatus(int ComplaintStatusID, ComplaintStatus ComplaintStatusObject);

        void DeleteComplaintStatus(int ComplaintStatusID);
    }
}
