using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class GenderRepository : IGenderInterface
    {
        ApplicationDbContext _applicationDbContext;

        public GenderRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public ICollection<Gender> GetAllGenders()
        {
            var genders = _applicationDbContext.Gender.ToList();
            return genders;
        }


        public Gender GetGenderByID(int GenderID)
        {
            var gender = _applicationDbContext.Gender.Where(x => x.GenderID == GenderID).SingleOrDefault();
            return gender;
        }


        public void CreateGender(Gender NewGender)
        {
            _applicationDbContext.Gender.Add(NewGender);
            _applicationDbContext.SaveChanges();
        }


        public int UpdateGender(int GenderID, Gender GenderObject)
        {
            var gender = _applicationDbContext.Gender.Where(x => x.GenderID == GenderID).SingleOrDefault();

            if (gender == null)
            {
                return 0;
            }
            else
            {
                //gender.GenderID = GenderObject.GenderID;
                gender.GenderName = GenderObject.GenderName;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }


        public void DeleteGender(int GenderID)
        {
            var gender = _applicationDbContext.Gender.Where(x => x.GenderID == GenderID).SingleOrDefault();

            _applicationDbContext.Gender.Remove(gender);
            _applicationDbContext.SaveChanges();
        }

    }
}
