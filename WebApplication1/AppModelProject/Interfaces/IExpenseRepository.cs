using System;
using System.Collections.Generic;
using System.Text;

namespace AppModelProject.Interfaces
{
    public interface IExpenseRepository
    {
        IEnumerable<Expense> GetExpense();
        Expense GetExpenseByID(int expenseId);
        void InsertExpense(Expense expense);
        void DeleteExpense(int expenseID);
        void UpdateExpense(Expense expense);
        void Save();
    }
}
