using System;
using System.Collections.Generic;
using System.Text;

namespace AppModelProject
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Expense> ExpenseList{ get; set; }

    }
}
