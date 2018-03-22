using System;
using System.Collections.Generic;
using System.Text;

namespace AppModelProject.DTO
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public List<Expense> ExpenseList { get; set; }
    }
}
