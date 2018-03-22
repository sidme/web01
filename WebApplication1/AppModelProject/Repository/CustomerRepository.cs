using AppModelProject.DTO;
using AppModelProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppModelProject.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _appDbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CustomerDTO> GetCustomer()
        {
            throw new NotImplementedException();
        }

        public CustomerDTO GetCustomerByID(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public void InsertCustomer(CustomerDTO Customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int CustomerID)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerDTO Customer)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
