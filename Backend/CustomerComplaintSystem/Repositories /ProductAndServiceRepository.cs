using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class ProductAndServiceRepository : IProductAndServiceInterface
    {
        ApplicationDbContext _applicationDbContext;

        public ProductAndServiceRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }


        public ICollection<ProductAndService> GetAllProductsAndServices()
        {
            var productsAndServices = _applicationDbContext.ProductAndService.ToList();
            return productsAndServices;
        }


        public ProductAndService GetProductAndServiceByID(int ProductAndServiceID)
        {
            var productAndService = _applicationDbContext.ProductAndService.Where(x => x.ProductAndServiceID == ProductAndServiceID).SingleOrDefault();
            return productAndService;
        }


        public void CreateProductAndService(ProductAndService NewProductAndService)
        {
            _applicationDbContext.ProductAndService.Add(NewProductAndService);
            _applicationDbContext.SaveChanges();
        }


        public int UpdateProductAndService(int ProductAndServiceID, ProductAndService ProductAndServiceObject)
        {
            var productAndService = _applicationDbContext.ProductAndService.Where(x => x.ProductAndServiceID == ProductAndServiceID).SingleOrDefault();

            if (productAndService == null)
            {
                return 0;
            }
            else
            {
                productAndService.ProductAndServiceName = productAndService.ProductAndServiceName;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }


        public void DeleteProductAndService(int ProductAndServiceID)
        {
            var productAndService = _applicationDbContext.ProductAndService.Where(x => x.ProductAndServiceID == ProductAndServiceID).SingleOrDefault();

            _applicationDbContext.ProductAndService.Remove(productAndService);
            _applicationDbContext.SaveChanges();
        }

        
    }
}
