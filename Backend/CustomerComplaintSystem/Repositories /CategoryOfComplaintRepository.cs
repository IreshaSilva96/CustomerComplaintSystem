using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class CategoryOfComplaintRepository : ICategoryOfComplaintInterface
    {
        ApplicationDbContext _applicationDbContext;

        public CategoryOfComplaintRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }


        public ICollection<CategoryOfComplaint> GetAllCategoriesOfComplaint()
        {
            var categoriesOfComplaint = _applicationDbContext.CategoryOfComplaint.ToList();
            return categoriesOfComplaint;
        }


        public CategoryOfComplaint GetCategoryOfComplaintByID(int CategoryOfComplaintID)
        {
            var categoryOfComplaint = _applicationDbContext.CategoryOfComplaint.Where(x => x.CategoryOfComplaintID == CategoryOfComplaintID).SingleOrDefault();
            return categoryOfComplaint;
        }


        public void CreateCategoryOfComplaint(CategoryOfComplaint NewCategoryOfComplaint)
        {
            _applicationDbContext.CategoryOfComplaint.Add(NewCategoryOfComplaint);
            _applicationDbContext.SaveChanges();
        }


        public int UpdateCategoryOfComplaint(int CategoryOfComplaintID, CategoryOfComplaint CategoryOfComplaintObject)
        {
            var categoryOfComplaint = _applicationDbContext.CategoryOfComplaint.Where(x => x.CategoryOfComplaintID == CategoryOfComplaintID).SingleOrDefault();

            if (categoryOfComplaint == null)
            {
                return 0;
            }
            else
            {
                //categoryOfComplaint.CategoryOfComplaintID = CategoryOfComplaintObject.CategoryOfComplaintID;
                categoryOfComplaint.CategoryOfComplaintName = CategoryOfComplaintObject.CategoryOfComplaintName;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }


        public void DeleteCategoryOfComplaint(int CategoryOfComplaintID)
        {
            var categoryOfComplaint = _applicationDbContext.CategoryOfComplaint.Where(x => x.CategoryOfComplaintID == CategoryOfComplaintID).SingleOrDefault();

            _applicationDbContext.CategoryOfComplaint.Remove(categoryOfComplaint);
            _applicationDbContext.SaveChanges();
        }
        
    }
}
