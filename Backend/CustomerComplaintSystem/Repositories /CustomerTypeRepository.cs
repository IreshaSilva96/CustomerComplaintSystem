using System;
using System.Collections.Generic;
using System.Linq;
using CustomerComplaintSystem.DataBase;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;

namespace CustomerComplaintSystem.Repositories
{
    public class CustomerTypeRepository : ICustomerTypeInterface
    {
        ApplicationDbContext _applicationDbContext;

        public CustomerTypeRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }


        public ICollection<CustomerType> GetAllCustomerTypes()
        {
            var customerTypes = _applicationDbContext.CustomerType.ToList();
            return customerTypes;
        }


        public CustomerType GetCustomerTypeByID(int CustomerTypeID)
        {
            var customerType = _applicationDbContext.CustomerType.Where(x => x.CustomerTypeID == CustomerTypeID).SingleOrDefault();
            return customerType;
        }


        public void CreateCustomerType(CustomerType NewCustomerType)
        {
            _applicationDbContext.CustomerType.Add(NewCustomerType);
            _applicationDbContext.SaveChanges();
        }


        public int UpdateCustomerType(int CustomerTypeID, CustomerType CustomerTypeObject)
        {
            var customerType = _applicationDbContext.CustomerType.Where(x => x.CustomerTypeID == CustomerTypeID).SingleOrDefault();

            if (customerType == null)
            {
                return 0;
            }
            else
            {
                //customerType.CustomerTypeID = CustomerTypeObject.CustomerTypeID;
                customerType.CustomerTypeName = CustomerTypeObject.CustomerTypeName;
                _applicationDbContext.SaveChanges();
                return 1;
            }
        }

        public void DeleteCustomerType(int CustomerTypeID)
        {
            var customerType = _applicationDbContext.CustomerType.Where(x => x.CustomerTypeID == CustomerTypeID).SingleOrDefault();

            _applicationDbContext.CustomerType.Remove(customerType);
            _applicationDbContext.SaveChanges();
        }
    }
}
