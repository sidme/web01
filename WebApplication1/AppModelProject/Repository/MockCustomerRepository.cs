using AppModelProject.DTO;
using AppModelProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppModelProject.Repository
{
    public class MockCustomerRepository : ICustomerRepository
    {
        public void DeleteCustomer(int CustomerID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDTO> GetCustomer()
        {
            return new List<CustomerDTO>()
            {
                new CustomerDTO{CustomerId = 1, CustomerName = "Customer 1"},
                new CustomerDTO{CustomerId = 3, CustomerName = "Customer 3"},
                new CustomerDTO{CustomerId = 2, CustomerName = "Customer 2"},
                new CustomerDTO{CustomerId = 4, CustomerName = "Customer 4"},

            };
        }

        public CustomerDTO GetCustomerByID(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public void InsertCustomer(CustomerDTO Customer)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerDTO Customer)
        {
            throw new NotImplementedException();
        }
    }
}
