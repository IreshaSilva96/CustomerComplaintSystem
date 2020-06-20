using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface IProductAndServiceInterface
    {
        ICollection<ProductAndService> GetAllProductsAndServices();

        ProductAndService GetProductAndServiceByID(int ProductAndServiceID);

        void CreateProductAndService(ProductAndService NewProductAndService);

        int UpdateProductAndService(int ProductAndServiceID, ProductAndService ProductAndServiceObject);

        void DeleteProductAndService(int ProductAndServiceID);
    }
}
