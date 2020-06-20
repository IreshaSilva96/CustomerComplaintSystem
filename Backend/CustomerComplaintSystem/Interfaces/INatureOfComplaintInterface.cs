using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface INatureOfComplaintInterface
    {
        ICollection<NatureOfComplaint> GetAllNaturesOfComplaint();

        NatureOfComplaint GetNatureOfComplaintByID(int NatureOfComplaintID);

        void CreateNatureOfComplaint(NatureOfComplaint NewNatureOfComplaint);

        int UpdateNatureOfComplaint(int NatureOfComplaintID, NatureOfComplaint NatureOfComplaintObject);

        void DeleteNatureOfComplaint(int NatureOfComplaintID);
    }
}
