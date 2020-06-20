using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface ICategoryOfComplaintInterface
    {
        ICollection<CategoryOfComplaint> GetAllCategoriesOfComplaint();

        CategoryOfComplaint GetCategoryOfComplaintByID(int CategoryOfComplaintID);

        void CreateCategoryOfComplaint(CategoryOfComplaint NewCategoryOfComplaint);

        int UpdateCategoryOfComplaint(int CategoryOfComplaintID, CategoryOfComplaint CategoryOfComplaintObject);

        void DeleteCategoryOfComplaint(int CategoryOfComplaintID);
    }
}
