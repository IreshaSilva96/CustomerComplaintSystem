using System;
using System.Collections.Generic;
using CustomerComplaintSystem.Entities;

namespace CustomerComplaintSystem.Interfaces
{
    public interface ICustomerTypeInterface
    {
        ICollection<CustomerType> GetAllCustomerTypes();

        CustomerType GetCustomerTypeByID(int CustomerTypeID);

        void CreateCustomerType(CustomerType NewCustomerType);

        int UpdateCustomerType(int CustomerTypeID, CustomerType CustomerTypeObject);

        void DeleteCustomerType(int CustomerTypeID);
    }
}
