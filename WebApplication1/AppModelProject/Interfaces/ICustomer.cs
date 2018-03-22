using AppModelProject.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppModelProject.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerDTO> GetCustomer();
        CustomerDTO GetCustomerByID(int CustomerId);
        void InsertCustomer(CustomerDTO Customer);
        void DeleteCustomer(int CustomerID);
        void UpdateCustomer(CustomerDTO Customer);
        void Save();

    }
}
