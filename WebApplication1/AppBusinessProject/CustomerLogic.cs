using AppBusinessProject.Interfaces;
using AppModelProject;
using AppModelProject.DTO;
using AppModelProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppBusinessProject
{
    public class CustomerLogic : ICustomerLogic
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly ICustomerRepository _customerRepository;

        public CustomerLogic(IExpenseRepository expenseRepository, ICustomerRepository customerRepository)
        {
            _expenseRepository = expenseRepository;
            _customerRepository = customerRepository;
        }

        public IEnumerable<CustomerDTO> GetCustomers()
        {
            return _customerRepository.GetCustomer();
        }

        public IEnumerable<Expense> GetExpenseByCustomerId(int customerId)
        {
            var list = _expenseRepository.GetExpense();

            return list.Where(x => x.CustomerId == customerId);

        }
    }
}
