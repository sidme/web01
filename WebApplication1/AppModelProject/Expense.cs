using System;

namespace AppModelProject
{
    public class Expense
    {
        public int ExpenseId { get; set; }

        public decimal Amount { get; set; }

        public string PaidTo { get; set; }

        public DateTime ExpenseDateTime { get; set; }

        public string Description { get; set; }

        public int CustomerId { get; set; }

    }
}
