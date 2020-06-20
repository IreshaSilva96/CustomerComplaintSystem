using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IGenderInterface
    {
        ICollection<Gender> GetAllGenders();

        Gender GetGenderByID(int GenderID);

        void CreateGender(Gender NewGender);

        int UpdateGender(int GenderID, Gender GenderObject);

        void DeleteGender(int GenderID);
    }
}
