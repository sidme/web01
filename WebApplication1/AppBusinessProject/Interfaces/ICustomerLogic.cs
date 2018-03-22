using AppModelProject;
using AppModelProject.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBusinessProject.Interfaces
{
    public interface ICustomerLogic
    {
        IEnumerable<Expense> GetExpenseByCustomerId(int customerId);

        IEnumerable<CustomerDTO> GetCustomers();
    }
}
