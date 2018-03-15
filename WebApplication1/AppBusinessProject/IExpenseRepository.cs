using AppModelProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBusinessProject
{
    public interface IExpenseRepository : IDisposable
    {
        IEnumerable<Expense> GetExpense();
        Expense GetExpenseByID(int expenseId);
        void InsertExpense(Expense expense);
        void DeleteExpense(int expenseID);
        void UpdateExpense(Expense expense);
        void Save();
    }
}
